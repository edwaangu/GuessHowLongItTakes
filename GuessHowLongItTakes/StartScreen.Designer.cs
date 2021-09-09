
namespace GuessHowLongItTakes
{
    partial class StartScreen
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
            this.player4Choice = new System.Windows.Forms.TextBox();
            this.player3Choice = new System.Windows.Forms.TextBox();
            this.player2Choice = new System.Windows.Forms.TextBox();
            this.player1Choice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.header1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player4Choice
            // 
            this.player4Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.player4Choice.Location = new System.Drawing.Point(246, 260);
            this.player4Choice.MaxLength = 3;
            this.player4Choice.Name = "player4Choice";
            this.player4Choice.Size = new System.Drawing.Size(100, 29);
            this.player4Choice.TabIndex = 11;
            // 
            // player3Choice
            // 
            this.player3Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.player3Choice.Location = new System.Drawing.Point(66, 260);
            this.player3Choice.MaxLength = 3;
            this.player3Choice.Name = "player3Choice";
            this.player3Choice.Size = new System.Drawing.Size(100, 29);
            this.player3Choice.TabIndex = 10;
            // 
            // player2Choice
            // 
            this.player2Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.player2Choice.Location = new System.Drawing.Point(246, 173);
            this.player2Choice.MaxLength = 3;
            this.player2Choice.Name = "player2Choice";
            this.player2Choice.Size = new System.Drawing.Size(100, 29);
            this.player2Choice.TabIndex = 9;
            // 
            // player1Choice
            // 
            this.player1Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.player1Choice.Location = new System.Drawing.Point(66, 173);
            this.player1Choice.MaxLength = 3;
            this.player1Choice.Name = "player1Choice";
            this.player1Choice.Size = new System.Drawing.Size(100, 29);
            this.player1Choice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "will the computer guess first?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header1
            // 
            this.header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.header1.ForeColor = System.Drawing.Color.White;
            this.header1.Location = new System.Drawing.Point(71, 34);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(285, 47);
            this.header1.TabIndex = 6;
            this.header1.Text = "What number...";
            this.header1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(115, 321);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(175, 53);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Go!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(246, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Player 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Player 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(246, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Player 4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(46, 377);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(330, 26);
            this.errorLabel.TabIndex = 17;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.player4Choice);
            this.Controls.Add(this.player3Choice);
            this.Controls.Add(this.player2Choice);
            this.Controls.Add(this.player1Choice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(420, 420);
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player4Choice;
        private System.Windows.Forms.TextBox player3Choice;
        private System.Windows.Forms.TextBox player2Choice;
        private System.Windows.Forms.TextBox player1Choice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorLabel;
    }
}
