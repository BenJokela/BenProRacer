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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlbReports = new System.Windows.Forms.ToolStripButton();
            this.tlbResults = new System.Windows.Forms.ToolStripButton();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.enterResultsToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.functionsToolStripMenuItem.Text = "F&unctions";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbReports,
            this.tlbResults,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlbReports
            // 
            this.tlbReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbReports.Image = global::ProRacer.Properties.Resources.iconfinder_custom_reports_63120;
            this.tlbReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbReports.Name = "tlbReports";
            this.tlbReports.Size = new System.Drawing.Size(23, 22);
            this.tlbReports.Text = "toolStripButton1";
            this.tlbReports.Click += new System.EventHandler(this.tlbReports_Click);
            // 
            // tlbResults
            // 
            this.tlbResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbResults.Image = global::ProRacer.Properties.Resources.iconfinder_sport_badges_08_2064038;
            this.tlbResults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbResults.Name = "tlbResults";
            this.tlbResults.Size = new System.Drawing.Size(23, 22);
            this.tlbResults.Text = "toolStripButton1";
            this.tlbResults.Click += new System.EventHandler(this.tlbResults_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::ProRacer.Properties.Resources.iconfinder_print_172530;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ProRacer.Properties.Resources.iconfinder_Cancel_1493282;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.reportToolStripMenuItem.Text = "&Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // enterResultsToolStripMenuItem
            // 
            this.enterResultsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enterResultsToolStripMenuItem.Image")));
            this.enterResultsToolStripMenuItem.Name = "enterResultsToolStripMenuItem";
            this.enterResultsToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.enterResultsToolStripMenuItem.Text = "&Enter Results";
            this.enterResultsToolStripMenuItem.Click += new System.EventHandler(this.enterResultsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss1,
            this.tss2,
            this.tss3,
            this.tss4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlbReports;
        private System.Windows.Forms.ToolStripButton tlbResults;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss1;
        private System.Windows.Forms.ToolStripStatusLabel tss2;
        private System.Windows.Forms.ToolStripStatusLabel tss3;
        private System.Windows.Forms.ToolStripStatusLabel tss4;
    }
}

