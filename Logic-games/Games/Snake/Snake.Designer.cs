namespace Logic_games
{
    partial class Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.scoreText = new System.Windows.Forms.Label();
            this.recordText = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.endMessage = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.recordIcon = new System.Windows.Forms.PictureBox();
            this.appleIcon = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.scoreText.ForeColor = System.Drawing.Color.White;
            this.scoreText.Location = new System.Drawing.Point(70, 18);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(42, 48);
            this.scoreText.TabIndex = 0;
            this.scoreText.Text = "0";
            // 
            // recordText
            // 
            this.recordText.AutoSize = true;
            this.recordText.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.recordText.ForeColor = System.Drawing.Color.White;
            this.recordText.Location = new System.Drawing.Point(239, 18);
            this.recordText.Name = "recordText";
            this.recordText.Size = new System.Drawing.Size(42, 48);
            this.recordText.TabIndex = 3;
            this.recordText.Text = "0";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.endMessage);
            this.panel.Controls.Add(this.exitButton);
            this.panel.Controls.Add(this.restartButton);
            this.panel.Location = new System.Drawing.Point(348, 277);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 100);
            this.panel.TabIndex = 4;
            // 
            // endMessage
            // 
            this.endMessage.AutoSize = true;
            this.endMessage.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endMessage.ForeColor = System.Drawing.Color.White;
            this.endMessage.Location = new System.Drawing.Point(76, 9);
            this.endMessage.Name = "endMessage";
            this.endMessage.Size = new System.Drawing.Size(104, 26);
            this.endMessage.TabIndex = 2;
            this.endMessage.Text = "Game Over";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(127, 61);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(3, 61);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(120, 23);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(398, 407);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 60);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // recordIcon
            // 
            this.recordIcon.Image = global::Logic_games.Properties.Resources.record;
            this.recordIcon.Location = new System.Drawing.Point(193, 23);
            this.recordIcon.Name = "recordIcon";
            this.recordIcon.Size = new System.Drawing.Size(40, 40);
            this.recordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recordIcon.TabIndex = 2;
            this.recordIcon.TabStop = false;
            // 
            // appleIcon
            // 
            this.appleIcon.Image = global::Logic_games.Properties.Resources.apple;
            this.appleIcon.Location = new System.Drawing.Point(24, 23);
            this.appleIcon.Name = "appleIcon";
            this.appleIcon.Size = new System.Drawing.Size(40, 40);
            this.appleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appleIcon.TabIndex = 1;
            this.appleIcon.TabStop = false;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.recordText);
            this.Controls.Add(this.recordIcon);
            this.Controls.Add(this.appleIcon);
            this.Controls.Add(this.scoreText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Snake_Load);
            this.SizeChanged += new System.EventHandler(this.Snake_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox appleIcon;
        private System.Windows.Forms.PictureBox recordIcon;
        private System.Windows.Forms.Label recordText;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label endMessage;
        private System.Windows.Forms.Button startButton;
    }
}