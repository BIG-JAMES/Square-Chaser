namespace Square_Chaser
{
    partial class game
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.speedtime = new System.Windows.Forms.Timer(this.components);
            this.player1lable = new System.Windows.Forms.Label();
            this.player2lable = new System.Windows.Forms.Label();
            this.speedlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick_1);
            // 
            // speedtime
            // 
            this.speedtime.Interval = 2000;
            this.speedtime.Tick += new System.EventHandler(this.speedtime_Tick);
            // 
            // player1lable
            // 
            this.player1lable.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.player1lable.BackColor = System.Drawing.Color.Transparent;
            this.player1lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1lable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1lable.Location = new System.Drawing.Point(72, 129);
            this.player1lable.Name = "player1lable";
            this.player1lable.Size = new System.Drawing.Size(52, 50);
            this.player1lable.TabIndex = 0;
            this.player1lable.Text = " ͠° ͟ʖ ͡°";
            this.player1lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2lable
            // 
            this.player2lable.BackColor = System.Drawing.Color.Transparent;
            this.player2lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2lable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player2lable.Location = new System.Drawing.Point(287, 200);
            this.player2lable.Name = "player2lable";
            this.player2lable.Size = new System.Drawing.Size(60, 50);
            this.player2lable.TabIndex = 1;
            this.player2lable.Text = "ಠ_ಠ";
            this.player2lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedlable
            // 
            this.speedlable.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.speedlable.BackColor = System.Drawing.Color.Transparent;
            this.speedlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedlable.ForeColor = System.Drawing.Color.Cyan;
            this.speedlable.Location = new System.Drawing.Point(320, 87);
            this.speedlable.Name = "speedlable";
            this.speedlable.Size = new System.Drawing.Size(17, 24);
            this.speedlable.TabIndex = 2;
            this.speedlable.Text = "⚡︎";
            this.speedlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(507, 478);
            this.Controls.Add(this.speedlable);
            this.Controls.Add(this.player2lable);
            this.Controls.Add(this.player1lable);
            this.DoubleBuffered = true;
            this.Name = "game";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer speedtime;
        private System.Windows.Forms.Label player1lable;
        private System.Windows.Forms.Label player2lable;
        private System.Windows.Forms.Label speedlable;

        #endregion
        //private System.Windows.Forms.Label player1Score;
        //private System.Windows.Forms.Label player2Score;
    }
}

