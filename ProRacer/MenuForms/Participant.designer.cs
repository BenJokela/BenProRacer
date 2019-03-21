namespace ProRacer
{
    partial class Participant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Participant));
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkMember = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNonBinary = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboSponsor = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlNav.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(402, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 31);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.btnLast);
            this.pnlNav.Controls.Add(this.btnFirst);
            this.pnlNav.Controls.Add(this.btnPrevious);
            this.pnlNav.Controls.Add(this.btnNext);
            this.pnlNav.Location = new System.Drawing.Point(190, 354);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(244, 43);
            this.pnlNav.TabIndex = 19;
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLast.Location = new System.Drawing.Point(187, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(55, 36);
            this.btnLast.TabIndex = 8;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFirst.Location = new System.Drawing.Point(5, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(55, 36);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrevious.Location = new System.Drawing.Point(66, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(55, 36);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNext.Location = new System.Drawing.Point(126, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 36);
            this.btnNext.TabIndex = 7;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(129, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 31);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(220, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(311, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 31);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkMember
            // 
            this.chkMember.AutoSize = true;
            this.chkMember.Location = new System.Drawing.Point(391, 265);
            this.chkMember.Name = "chkMember";
            this.chkMember.Size = new System.Drawing.Size(94, 19);
            this.chkMember.TabIndex = 14;
            this.chkMember.Text = "IAC Member";
            this.chkMember.UseVisualStyleBackColor = true;
            this.chkMember.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdoFemale_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNonBinary);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Location = new System.Drawing.Point(391, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rdoNonBinary
            // 
            this.rdoNonBinary.AutoSize = true;
            this.rdoNonBinary.Location = new System.Drawing.Point(41, 67);
            this.rdoNonBinary.Name = "rdoNonBinary";
            this.rdoNonBinary.Size = new System.Drawing.Size(85, 19);
            this.rdoNonBinary.TabIndex = 2;
            this.rdoNonBinary.TabStop = true;
            this.rdoNonBinary.Text = "Non Binary";
            this.rdoNonBinary.UseVisualStyleBackColor = true;
            this.rdoNonBinary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdoFemale_MouseClick);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(41, 42);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(53, 19);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdoFemale_MouseClick);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(41, 19);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(67, 19);
            this.rdoFemale.TabIndex = 0;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdoFemale_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboSponsor);
            this.panel2.Controls.Add(this.cboCountry);
            this.panel2.Controls.Add(this.txtRank);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(36, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 100);
            this.panel2.TabIndex = 12;
            // 
            // cboSponsor
            // 
            this.cboSponsor.FormattingEnabled = true;
            this.cboSponsor.Location = new System.Drawing.Point(129, 67);
            this.cboSponsor.Name = "cboSponsor";
            this.cboSponsor.Size = new System.Drawing.Size(162, 21);
            this.cboSponsor.TabIndex = 6;
            this.cboSponsor.SelectionChangeCommitted += new System.EventHandler(this.EnterEditMode);
            this.cboSponsor.Validating += new System.ComponentModel.CancelEventHandler(this.cboSponsor_Validating);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(129, 11);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(162, 21);
            this.cboCountry.TabIndex = 5;
            this.cboCountry.SelectionChangeCommitted += new System.EventHandler(this.EnterEditMode);
            this.cboCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cboCountry_Validating);
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(129, 41);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(51, 20);
            this.txtRank.TabIndex = 4;
            this.txtRank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditMode);
            this.txtRank.Validating += new System.ComponentModel.CancelEventHandler(this.txtRank_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sponsor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "World Rank:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Home Country:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 93);
            this.panel1.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 50);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(167, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditMode);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(124, 21);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(167, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditMode);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(627, 437);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkMember);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Participant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Participant_FormClosing);
            this.Load += new System.EventHandler(this.Participant_Load);
            this.pnlNav.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNonBinary;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboSponsor;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

