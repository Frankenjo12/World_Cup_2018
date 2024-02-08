namespace Windows_Forms_App
{
    partial class Rankings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rankings));
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.lbMatches = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tMIFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPlayers = new System.Windows.Forms.Button();
            this.btnPrintMatches = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbPlayers
            // 
            resources.ApplyResources(this.lbPlayers, "lbPlayers");
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Name = "lbPlayers";
            // 
            // lbMatches
            // 
            resources.ApplyResources(this.lbMatches, "lbMatches");
            this.lbMatches.FormattingEnabled = true;
            this.lbMatches.Name = "lbMatches";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // msMain
            // 
            resources.ApplyResources(this.msMain, "msMain");
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMIFavorites});
            this.msMain.Name = "msMain";
            // 
            // tMIFavorites
            // 
            resources.ApplyResources(this.tMIFavorites, "tMIFavorites");
            this.tMIFavorites.Name = "tMIFavorites";
            this.tMIFavorites.Click += new System.EventHandler(this.tMIFavorites_Click);
            // 
            // btnPrintPlayers
            // 
            resources.ApplyResources(this.btnPrintPlayers, "btnPrintPlayers");
            this.btnPrintPlayers.Name = "btnPrintPlayers";
            this.btnPrintPlayers.UseVisualStyleBackColor = true;
            this.btnPrintPlayers.Click += new System.EventHandler(this.btnPrintPlayers_Click);
            // 
            // btnPrintMatches
            // 
            resources.ApplyResources(this.btnPrintMatches, "btnPrintMatches");
            this.btnPrintMatches.Name = "btnPrintMatches";
            this.btnPrintMatches.UseVisualStyleBackColor = true;
            this.btnPrintMatches.Click += new System.EventHandler(this.btnPrintMatches_Click);
            // 
            // Rankings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrintMatches);
            this.Controls.Add(this.btnPrintPlayers);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMatches);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.label1);
            this.Name = "Rankings";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbPlayers;
        private ListBox lbMatches;
        private Label label3;
        private MenuStrip msMain;
        private ToolStripMenuItem tMIFavorites;
        private Button btnPrintPlayers;
        private Button btnPrintMatches;
    }
}