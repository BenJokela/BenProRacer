namespace ProRacer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParticipants = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSponsor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiResults = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRaceParticipants = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRaceByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlbPartic = new System.Windows.Forms.ToolStripButton();
            this.tlbRace = new System.Windows.Forms.ToolStripButton();
            this.tlbSponsor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbResults = new System.Windows.Forms.ToolStripButton();
            this.tlbReg = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new MdiTabControl.TabControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiMaintenance,
            this.tsmiReports,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(41, 23);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Image = global::ProRacer.Properties.Resources.iconfinder_Cancel_1493282;
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.Size = new System.Drawing.Size(101, 24);
            this.tsmiFileExit.Text = "E&xit";
            this.tsmiFileExit.Click += new System.EventHandler(this.tsmiFileExit_Click);
            // 
            // tsmiMaintenance
            // 
            this.tsmiMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiParticipants,
            this.tsmiRace,
            this.tsmiSponsor,
            this.toolStripMenuItem1,
            this.tsmiResults,
            this.tsmiRegistration,
            this.toolStripMenuItem2});
            this.tsmiMaintenance.Name = "tsmiMaintenance";
            this.tsmiMaintenance.Size = new System.Drawing.Size(100, 23);
            this.tsmiMaintenance.Text = "&Maintenance";
            // 
            // tsmiParticipants
            // 
            this.tsmiParticipants.Image = global::ProRacer.Properties.Resources.iconfinder_Run_73224;
            this.tsmiParticipants.Name = "tsmiParticipants";
            this.tsmiParticipants.Size = new System.Drawing.Size(153, 24);
            this.tsmiParticipants.Text = "&Participants";
            this.tsmiParticipants.Click += new System.EventHandler(this.tsmiParticipants_Click);
            // 
            // tsmiRace
            // 
            this.tsmiRace.Image = global::ProRacer.Properties.Resources.iconfinder_start_flag_finish_race_races_3982459;
            this.tsmiRace.Name = "tsmiRace";
            this.tsmiRace.Size = new System.Drawing.Size(153, 24);
            this.tsmiRace.Text = "&Race";
            this.tsmiRace.Click += new System.EventHandler(this.tsmiRace_Click);
            // 
            // tsmiSponsor
            // 
            this.tsmiSponsor.Image = global::ProRacer.Properties.Resources.iconfinder_lowercase_letter_s_blue_3052278;
            this.tsmiSponsor.Name = "tsmiSponsor";
            this.tsmiSponsor.Size = new System.Drawing.Size(153, 24);
            this.tsmiSponsor.Text = "&Sponsor";
            this.tsmiSponsor.Click += new System.EventHandler(this.tsmiSponsor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // tsmiResults
            // 
            this.tsmiResults.Image = global::ProRacer.Properties.Resources.iconfinder_sport_badges_08_2064038;
            this.tsmiResults.Name = "tsmiResults";
            this.tsmiResults.Size = new System.Drawing.Size(153, 24);
            this.tsmiResults.Text = "R&esults";
            this.tsmiResults.Click += new System.EventHandler(this.tsmiResults_Click);
            // 
            // tsmiRegistration
            // 
            this.tsmiRegistration.Image = global::ProRacer.Properties.Resources.iconfinder_Application_46710;
            this.tsmiRegistration.Name = "tsmiRegistration";
            this.tsmiRegistration.Size = new System.Drawing.Size(153, 24);
            this.tsmiRegistration.Text = "Re&gistration";
            this.tsmiRegistration.Click += new System.EventHandler(this.tsmiRegistration_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // tsmiReports
            // 
            this.tsmiReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRaceParticipants,
            this.tsmiRaceByDate});
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(68, 23);
            this.tsmiReports.Text = "Rep&orts";
            // 
            // tsmiRaceParticipants
            // 
            this.tsmiRaceParticipants.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRaceParticipants.Image")));
            this.tsmiRaceParticipants.Name = "tsmiRaceParticipants";
            this.tsmiRaceParticipants.Size = new System.Drawing.Size(183, 24);
            this.tsmiRaceParticipants.Text = "R&ace Participants";
            this.tsmiRaceParticipants.ToolTipText = "Race Participants";
            this.tsmiRaceParticipants.Click += new System.EventHandler(this.tsmiRaceParticipants_Click);
            // 
            // tsmiRaceByDate
            // 
            this.tsmiRaceByDate.Image = global::ProRacer.Properties.Resources.iconfinder_calendar_1055101;
            this.tsmiRaceByDate.Name = "tsmiRaceByDate";
            this.tsmiRaceByDate.Size = new System.Drawing.Size(183, 24);
            this.tsmiRaceByDate.Text = "Ra&ce by Date";
            this.tsmiRaceByDate.ToolTipText = "Race By Date";
            this.tsmiRaceByDate.Click += new System.EventHandler(this.tsmiRaceByDate_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(49, 23);
            this.tsmiHelp.Text = "&Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(118, 24);
            this.tsmiAbout.Text = "A&bout";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbPartic,
            this.tlbRace,
            this.tlbSponsor,
            this.toolStripSeparator1,
            this.tlbResults,
            this.tlbReg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlbPartic
            // 
            this.tlbPartic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbPartic.Image = global::ProRacer.Properties.Resources.iconfinder_Run_73224;
            this.tlbPartic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbPartic.Name = "tlbPartic";
            this.tlbPartic.Size = new System.Drawing.Size(23, 22);
            this.tlbPartic.Text = "Participants";
            this.tlbPartic.ToolTipText = "Participants";
            this.tlbPartic.Click += new System.EventHandler(this.tsmiParticipants_Click);
            // 
            // tlbRace
            // 
            this.tlbRace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbRace.Image = global::ProRacer.Properties.Resources.iconfinder_start_flag_finish_race_races_3982459;
            this.tlbRace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbRace.Name = "tlbRace";
            this.tlbRace.Size = new System.Drawing.Size(23, 22);
            this.tlbRace.Text = "Race";
            this.tlbRace.ToolTipText = "Race";
            this.tlbRace.Click += new System.EventHandler(this.tsmiRace_Click);
            // 
            // tlbSponsor
            // 
            this.tlbSponsor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbSponsor.Image = global::ProRacer.Properties.Resources.iconfinder_lowercase_letter_s_blue_3052278;
            this.tlbSponsor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbSponsor.Name = "tlbSponsor";
            this.tlbSponsor.Size = new System.Drawing.Size(23, 22);
            this.tlbSponsor.Text = "Sponsor";
            this.tlbSponsor.Click += new System.EventHandler(this.tsmiSponsor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(8, 25);
            // 
            // tlbResults
            // 
            this.tlbResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbResults.Image = global::ProRacer.Properties.Resources.iconfinder_sport_badges_08_2064038;
            this.tlbResults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbResults.Name = "tlbResults";
            this.tlbResults.Size = new System.Drawing.Size(23, 22);
            this.tlbResults.Text = "Results";
            this.tlbResults.Click += new System.EventHandler(this.tsmiResults_Click);
            // 
            // tlbReg
            // 
            this.tlbReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbReg.Image = global::ProRacer.Properties.Resources.iconfinder_Application_46710;
            this.tlbReg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbReg.Name = "tlbReg";
            this.tlbReg.Size = new System.Drawing.Size(23, 22);
            this.tlbReg.Text = "Registration";
            this.tlbReg.Click += new System.EventHandler(this.tsmiRegistration_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss1,
            this.tss2,
            this.tss3,
            this.tss4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(139, 19);
            this.tss1.Text = "toolStripStatusLabel1";
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(139, 19);
            this.tss2.Text = "toolStripStatusLabel2";
            // 
            // tss3
            // 
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(139, 19);
            this.tss3.Text = "toolStripStatusLabel3";
            // 
            // tss4
            // 
            this.tss4.Name = "tss4";
            this.tss4.Size = new System.Drawing.Size(139, 19);
            this.tss4.Text = "toolStripStatusLabel4";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.MenuRenderer = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(800, 483);
            this.tabControl1.TabCloseButtonImage = null;
            this.tabControl1.TabCloseButtonImageDisabled = null;
            this.tabControl1.TabCloseButtonImageHot = null;
            this.tabControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiRaceParticipants;
        private System.Windows.Forms.ToolStripMenuItem tsmiRaceByDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlbResults;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaintenance;
        private System.Windows.Forms.ToolStripMenuItem tsmiParticipants;
        private System.Windows.Forms.ToolStripMenuItem tsmiRace;
        private System.Windows.Forms.ToolStripMenuItem tsmiSponsor;
        private System.Windows.Forms.ToolStripMenuItem tsmiResults;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistration;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripButton tlbSponsor;
        private System.Windows.Forms.ToolStripButton tlbRace;
        private System.Windows.Forms.ToolStripButton tlbReg;
        private System.Windows.Forms.ToolStripButton tlbPartic;
        internal System.Windows.Forms.ToolStripStatusLabel tss1;
        internal System.Windows.Forms.ToolStripStatusLabel tss2;
        internal System.Windows.Forms.ToolStripStatusLabel tss3;
        internal System.Windows.Forms.ToolStripStatusLabel tss4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private MdiTabControl.TabControl tabControl1;
    }
}

