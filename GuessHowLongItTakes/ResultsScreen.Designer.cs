
namespace GuessHowLongItTakes
{
    partial class ResultsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerWinsLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerWinsLabel
            // 
            this.playerWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.playerWinsLabel.ForeColor = System.Drawing.Color.White;
            this.playerWinsLabel.Location = new System.Drawing.Point(66, 76);
            this.playerWinsLabel.Name = "playerWinsLabel";
            this.playerWinsLabel.Size = new System.Drawing.Size(285, 47);
            this.playerWinsLabel.TabIndex = 8;
            this.playerWinsLabel.Text = "Player # Wins!";
            this.playerWinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(31, 176);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(353, 71);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Their guess \'000\' took \'#\' tries";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.playerWinsLabel);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(420, 420);
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playerWinsLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}
