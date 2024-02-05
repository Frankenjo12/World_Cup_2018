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
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.lbMatches = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tMIFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Ranking";
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 20;
            this.lbPlayers.Location = new System.Drawing.Point(124, 66);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(617, 224);
            this.lbPlayers.TabIndex = 4;
            // 
            // lbMatches
            // 
            this.lbMatches.FormattingEnabled = true;
            this.lbMatches.ItemHeight = 20;
            this.lbMatches.Location = new System.Drawing.Point(124, 296);
            this.lbMatches.Name = "lbMatches";
            this.lbMatches.Size = new System.Drawing.Size(617, 224);
            this.lbMatches.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matches";
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMIFavorites});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(757, 28);
            this.msMain.TabIndex = 8;
            this.msMain.Text = "MenuStrip";
            // 
            // tMIFavorites
            // 
            this.tMIFavorites.Name = "tMIFavorites";
            this.tMIFavorites.Size = new System.Drawing.Size(81, 24);
            this.tMIFavorites.Text = "Favorites";
            this.tMIFavorites.Click += new System.EventHandler(this.tMIFavorites_Click);
            // 
            // Rankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 538);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMatches);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.label1);
            this.Name = "Rankings";
            this.Text = "Rankings";
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
    }
}