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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite_National_Team));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbTeams
            // 
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Name = "cbTeams";
            // 
            // btnContinue
            // 
            resources.ApplyResources(this.btnContinue, "btnContinue");
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // flpLeft
            // 
            resources.ApplyResources(this.flpLeft, "flpLeft");
            this.flpLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpLeft.Name = "flpLeft";
            // 
            // flpRight
            // 
            resources.ApplyResources(this.flpRight, "flpRight");
            this.flpRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpRight.Name = "flpRight";
            // 
            // ctxMSRegular
            // 
            resources.ApplyResources(this.ctxMSRegular, "ctxMSRegular");
            this.ctxMSRegular.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMSRegular.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIAddFavorite});
            this.ctxMSRegular.Name = "ctxMSRegular";
            // 
            // tSMIAddFavorite
            // 
            resources.ApplyResources(this.tSMIAddFavorite, "tSMIAddFavorite");
            this.tSMIAddFavorite.Name = "tSMIAddFavorite";
            this.tSMIAddFavorite.Click += new System.EventHandler(this.tSMIAddFavorite_Click);
            // 
            // pbPlayer
            // 
            resources.ApplyResources(this.pbPlayer, "pbPlayer");
            this.pbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.TabStop = false;
            // 
            // btnUpload
            // 
            resources.ApplyResources(this.btnUpload, "btnUpload");
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // msMain
            // 
            resources.ApplyResources(this.msMain, "msMain");
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMIRankings,
            this.tSMISettings,
            this.tSMIExit});
            this.msMain.Name = "msMain";
            // 
            // tMIRankings
            // 
            resources.ApplyResources(this.tMIRankings, "tMIRankings");
            this.tMIRankings.Name = "tMIRankings";
            this.tMIRankings.Click += new System.EventHandler(this.tMIRankings_Click);
            // 
            // tSMISettings
            // 
            resources.ApplyResources(this.tSMISettings, "tSMISettings");
            this.tSMISettings.Name = "tSMISettings";
            this.tSMISettings.Click += new System.EventHandler(this.tSMISettings_Click);
            // 
            // tSMIExit
            // 
            resources.ApplyResources(this.tSMIExit, "tSMIExit");
            this.tSMIExit.ForeColor = System.Drawing.Color.Red;
            this.tSMIExit.Name = "tSMIExit";
            this.tSMIExit.Click += new System.EventHandler(this.tSMIExit_Click);
            // 
            // Favorite_National_Team
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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