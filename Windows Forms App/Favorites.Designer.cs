namespace Windows_Forms_App
{
    partial class Favorite_National_Team
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.flpLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.ctxMSRegular = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMIAddFavorite = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tMIRankings = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMISettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMSRegular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select favorite national team";
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(524, 529);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(327, 28);
            this.cbTeams.TabIndex = 1;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(524, 576);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(161, 50);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Save Favorite Team";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // flpLeft
            // 
            this.flpLeft.AutoScroll = true;
            this.flpLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpLeft.Location = new System.Drawing.Point(12, 54);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(424, 396);
            this.flpLeft.TabIndex = 3;
            // 
            // flpRight
            // 
            this.flpRight.AutoScroll = true;
            this.flpRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpRight.Location = new System.Drawing.Point(487, 54);
            this.flpRight.Name = "flpRight";
            this.flpRight.Size = new System.Drawing.Size(424, 397);
            this.flpRight.TabIndex = 4;
            // 
            // ctxMSRegular
            // 
            this.ctxMSRegular.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMSRegular.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIAddFavorite});
            this.ctxMSRegular.Name = "ctxMSRegular";
            this.ctxMSRegular.Size = new System.Drawing.Size(186, 28);
            // 
            // tSMIAddFavorite
            // 
            this.tSMIAddFavorite.Name = "tSMIAddFavorite";
            this.tSMIAddFavorite.Size = new System.Drawing.Size(185, 24);
            this.tSMIAddFavorite.Text = "Add to favorites";
            this.tSMIAddFavorite.Click += new System.EventHandler(this.tSMIAddFavorite_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayer.Location = new System.Drawing.Point(30, 461);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(250, 250);
            this.pbPlayer.TabIndex = 5;
            this.pbPlayer.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(286, 461);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(94, 29);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMIRankings,
            this.tSMISettings,
            this.tSMIExit});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(926, 28);
            this.msMain.TabIndex = 7;
            this.msMain.Text = "MenuStrip";
            // 
            // tMIRankings
            // 
            this.tMIRankings.Name = "tMIRankings";
            this.tMIRankings.Size = new System.Drawing.Size(82, 24);
            this.tMIRankings.Text = "Rankings";
            this.tMIRankings.Click += new System.EventHandler(this.tMIRankings_Click);
            // 
            // tSMISettings
            // 
            this.tSMISettings.Name = "tSMISettings";
            this.tSMISettings.Size = new System.Drawing.Size(76, 24);
            this.tSMISettings.Text = "Settings";
            this.tSMISettings.Click += new System.EventHandler(this.tSMISettings_Click);
            // 
            // tSMIExit
            // 
            this.tSMIExit.ForeColor = System.Drawing.Color.Red;
            this.tSMIExit.Name = "tSMIExit";
            this.tSMIExit.Size = new System.Drawing.Size(47, 24);
            this.tSMIExit.Text = "Exit";
            this.tSMIExit.Click += new System.EventHandler(this.tSMIExit_Click);
            // 
            // Favorite_National_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 725);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.flpRight);
            this.Controls.Add(this.flpLeft);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.msMain;
            this.Name = "Favorite_National_Team";
            this.Text = "Favorites";
            this.ctxMSRegular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbTeams;
        private Button btnContinue;
        private FlowLayoutPanel flpLeft;
        private FlowLayoutPanel flpRight;
        private ContextMenuStrip ctxMSRegular;
        private ToolStripMenuItem tSMIAddFavorite;
        private PictureBox pbPlayer;
        private Button btnUpload;
        private MenuStrip msMain;
        private ToolStripMenuItem tMIRankings;
        private ToolStripMenuItem tSMISettings;
        private ToolStripMenuItem tSMIExit;
    }
}