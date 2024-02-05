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
            this.ctxMSRegular.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select favorite national team";
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(236, 35);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(327, 28);
            this.cbTeams.TabIndex = 1;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(750, 507);
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
            this.flpLeft.Location = new System.Drawing.Point(12, 90);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(424, 360);
            this.flpLeft.TabIndex = 3;
            // 
            // flpRight
            // 
            this.flpRight.AutoScroll = true;
            this.flpRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpRight.Location = new System.Drawing.Point(487, 90);
            this.flpRight.Name = "flpRight";
            this.flpRight.Size = new System.Drawing.Size(424, 361);
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
            // Favorite_National_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 569);
            this.Controls.Add(this.flpRight);
            this.Controls.Add(this.flpLeft);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.label1);
            this.Name = "Favorite_National_Team";
            this.Text = "Favorites";
            this.ctxMSRegular.ResumeLayout(false);
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
    }
}