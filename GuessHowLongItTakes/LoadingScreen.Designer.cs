
namespace GuessHowLongItTakes
{
    partial class LoadingScreen
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
            this.components = new System.ComponentModel.Container();
            this.header1 = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.header1.ForeColor = System.Drawing.Color.White;
            this.header1.Location = new System.Drawing.Point(67, 34);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(285, 47);
            this.header1.TabIndex = 7;
            this.header1.Text = "Loading...";
            this.header1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadLabel
            // 
            this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.loadLabel.ForeColor = System.Drawing.Color.White;
            this.loadLabel.Location = new System.Drawing.Point(67, 144);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(285, 140);
            this.loadLabel.TabIndex = 8;
            this.loadLabel.Text = "0";
            this.loadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTick
            // 
            this.timerTick.Interval = 50;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.header1);
            this.Name = "LoadingScreen";
            this.Size = new System.Drawing.Size(420, 420);
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.Timer timerTick;
    }
}
