//Ben Jokela Feb, 2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProRacer
{
    public partial class Participant : Form
    {
        MainForm myParent;
        public Participant(MainForm parent)
        {
            myParent = parent;
            InitializeComponent();
        }

        int currentParticipant = 0;
        DataTable dtParticipants;
        bool addMode = false;
        private void Participant_Load(object sender, EventArgs e)
        {
            try
            {
                ToggleButtonState(true);

                PopulateCountries();

                DataTable dtSponsors = GetData("SELECT SponsorName, SponsorId FROM Sponsor");

                DataRow row = dtSponsors.NewRow();
                row["SponsorId"] = DBNull.Value;
                row["SponsorName"] = "No Sponsor";
                dtSponsors.Rows.InsertAt(row, 0);

                cboSponsor.DataSource = dtSponsors;
                cboSponsor.DisplayMember = "SponsorName";
                cboSponsor.ValueMember = "SponsorId";

                dtParticipants = GetData("SELECT * FROM Participant ORDER BY LastName");

                PopulateForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void PopulateForm()
        {
            try
            {
                txtFirstName.Text = dtParticipants.Rows[currentParticipant]["FirstName"].ToString();
                txtLastName.Text = dtParticipants.Rows[currentParticipant]["LastName"].ToString();
                cboCountry.SelectedItem = dtParticipants.Rows[currentParticipant]["Country"];
                txtRank.Text = dtParticipants.Rows[currentParticipant]["Rank"].ToString();
                cboSponsor.SelectedValue = dtParticipants.Rows[currentParticipant]["SponsorId"];
                if (dtParticipants.Rows[currentParticipant]["Gender"].ToString() == "O")
                {
                    rdoNonBinary.Checked = true;
                }
                else if (dtParticipants.Rows[currentParticipant]["Gender"].ToString() == "M")
                {
                    rdoMale.Checked = true;
                }
                else if (dtParticipants.Rows[currentParticipant]["Gender"].ToString() == "F")
                {
                    rdoFemale.Checked = true;
                }

                chkMember.Checked = (bool)dtParticipants.Rows[currentParticipant]["IACMember"];

                addMode = false;

                myParent.tss3.Text = $"Position: {currentParticipant + 1} of {dtParticipants.Rows.Count}";
                myParent.tss4.Text = "OK";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void PopulateCountries()
        {
            cboCountry.Items.Add("America");
            cboCountry.Items.Add("Britian"); //misspelled so it will match database
            cboCountry.Items.Add("Canada");
            cboCountry.Items.Add("Italy");
        }
        private DataTable GetData(string sqlStatement)
        {
            SqlConnection conn = new SqlConnection
            (Properties.Settings.Default.cnnString);

            DataTable dt = new DataTable();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                using (cmd)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentParticipant < dtParticipants.Rows.Count - 1)
            {
                currentParticipant++;
                PopulateForm();
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentParticipant != 0)
            {
                currentParticipant--;
                PopulateForm();
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            currentParticipant = dtParticipants.Rows.Count - 1;
            PopulateForm();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentParticipant = 0;
            PopulateForm();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ToggleButtonState(false);

            addMode = true;

            txtFirstName.Text = string.Empty;
            txtFirstName.Focus();
            txtLastName.Text = string.Empty;
            txtRank.Text = string.Empty;
            cboCountry.SelectedIndex = -1;
            cboSponsor.SelectedIndex = 0;
            rdoFemale.Checked = true;
            chkMember.Checked = false;

            myParent.tss3.Text = $"Position: {dtParticipants.Rows.Count + 1} of {dtParticipants.Rows.Count + 1}";
            myParent.tss4.Text = "Add Record in progress...";
        }
        private void ToggleButtonState(bool state)
        {
            btnAdd.Enabled = state;
            btnDelete.Enabled = state;
            btnCancel.Enabled = !state;
            btnUpdate.Enabled = !state;
            btnFirst.Enabled = state;
            btnNext.Enabled = state;
            btnPrevious.Enabled = state;
            btnLast.Enabled = state;
        }
        private string FixApostrophe(string value)
        {
            return value.Replace("'", "''");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    //needs validation
                    string country = string.Empty;
                    if (cboCountry.SelectedIndex == -1)
                    {
                        MessageBox.Show("You must select a country");
                        cboCountry.Focus();
                        return;
                    }
                    else { country = cboCountry.SelectedItem.ToString(); }

                    string lastName = FixApostrophe(txtLastName.Text.Trim());
                    string firstName = FixApostrophe(txtFirstName.Text.Trim());
                    int rank = Convert.ToInt32(txtRank.Text.Trim());
                    string gender = string.Empty;
                    if (rdoFemale.Checked == true) { gender = "F"; }
                    else if (rdoMale.Checked == true) { gender = "M"; }
                    else if (rdoNonBinary.Checked == true) { gender = "O"; }
                    int iacMember = chkMember.Checked ? 1 : 0;
                    int sponsorId = (cboSponsor.SelectedIndex == 0) ? 0 : Convert.ToInt32(cboSponsor.SelectedValue);
                    string sql = string.Empty;
                    if (addMode)
                    {
                        sql = $"INSERT INTO Participant (LastName, FirstName, Country, Rank, Gender, IACMember, SponsorId)" +
                        $" VALUES('{lastName}', '{firstName}', '{country}', {rank}, '{gender}', '{iacMember}', ";

                        sql += (sponsorId == 0) ? $"NULL)" : $"{sponsorId})";

                        SendData(sql);
                    }
                    else
                    {
                        sql = $"UPDATE Participant SET LastName = '{lastName}', FirstName = '{firstName}', " +
                            $"Country = '{country}', Rank = {rank}, Gender = '{gender}', IACMember = {iacMember}, ";

                        sql += (sponsorId == 0) ? $"SponsorId = NULL " : $"SponsorId = {sponsorId} ";

                        sql += $"WHERE ParticipantId = {dtParticipants.Rows[currentParticipant]["ParticipantId"]}";

                        SendData(sql);
                    }
                }
                else
                {
                    myParent.tss4.Text = "Invalid Data. Please fix all errors.";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, sqlEx.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            ToggleButtonState(true);
            PopulateForm();
        }
        private object ExecuteScalar(string sql)
        {
            object retVal;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnString);
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                retVal = cmd.ExecuteScalar();
            }
            return retVal;
        }
            private void SendData(string sql)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnString);
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            if (addMode){ currentParticipant = 0; } 
            dtParticipants = GetData("SELECT * FROM Participant ORDER BY LastName");
            PopulateForm();
        }
        private void EditMode(object sender, KeyPressEventArgs e)
        {
            if (!addMode)
            {
                ToggleButtonState(false);
                myParent.tss4.Text = "Edit in progress...";
            }
        }
        private void EnterEditMode(object sender, EventArgs e)
        {
            if (!addMode)
            {
                ToggleButtonState(false);
                myParent.tss4.Text = "Edit in progress...";
            }
        }
        private void rdoFemale_MouseClick(object sender, MouseEventArgs e)
        {
            if (!addMode)
            {
                ToggleButtonState(false);
                myParent.tss4.Text = "Edit in progress...";
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (currentParticipant == dtParticipants.Rows.Count + 1)
            {
                currentParticipant = 0;
            }
            ToggleButtonState(true);
            PopulateForm();
            errorProvider1.Clear();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Please enter a first name.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, string.Empty);
            }
        }

        private void Participant_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Please enter a last name.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, string.Empty);
            }

        }

        private void cboCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cboCountry.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cboCountry, "Please select a country.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboCountry, string.Empty);
            }
        }

        private void txtRank_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtRank.Text, out int rank) || rank<1 || rank>50 )
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRank, "Rank must be a number between 1 and 50");
            }
            else if (IsDuplicateRank())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRank, "Rank is already assigned to someone else.");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRank, string.Empty);
            }

        }
        private bool IsDuplicateRank()
        {
            if (txtRank.Text != string.Empty)
            {
                string sql = $"SELECT COUNT(*) FROM Participant WHERE Rank = {txtRank.Text}";
                if (!addMode)
                {
                    int currentId = Convert.ToInt16(dtParticipants.Rows[currentParticipant]["ParticipantId"]);
                    sql += $" AND ParticipantID <> {currentId}";
                }
                if (Convert.ToInt16(ExecuteScalar(sql)) > 0)
                
                {
                    return true;
                }
            }
            return false;

        }

        private void cboSponsor_Validating(object sender, CancelEventArgs e)
        {
            //int currentSponsorId;
            if (cboSponsor.SelectedIndex > 0)
            {
                int currentSponsorId = Convert.ToInt16(cboSponsor.SelectedValue);
                string sql = $"SELECT COUNT (*) FROM Participant WHERE SponsorId = {currentSponsorId}";
                if (Convert.ToInt16(ExecuteScalar(sql)) > 6)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cboSponsor, "That Sponsor already sponsors the max (6) participants.");
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cboSponsor, string.Empty);
            }

        }
    }
}
