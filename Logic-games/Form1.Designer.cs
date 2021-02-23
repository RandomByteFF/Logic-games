namespace Logic_games
{
    partial class LogicGames
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
            this.sudokuButton = new System.Windows.Forms.Button();
            this.snakeButton = new System.Windows.Forms.Button();
            this.battleshipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sudokuButton
            // 
            this.sudokuButton.Location = new System.Drawing.Point(200, 120);
            this.sudokuButton.Name = "sudokuButton";
            this.sudokuButton.Size = new System.Drawing.Size(100, 40);
            this.sudokuButton.TabIndex = 0;
            this.sudokuButton.Text = "Sudoku";
            this.sudokuButton.UseVisualStyleBackColor = true;
            this.sudokuButton.Click += new System.EventHandler(this.sudokuButton_Click);
            // 
            // snakeButton
            // 
            this.snakeButton.Location = new System.Drawing.Point(200, 180);
            this.snakeButton.Name = "snakeButton";
            this.snakeButton.Size = new System.Drawing.Size(100, 40);
            this.snakeButton.TabIndex = 1;
            this.snakeButton.Text = "Snake";
            this.snakeButton.UseVisualStyleBackColor = true;
            this.snakeButton.Click += new System.EventHandler(this.snakeButton_Click);
            // 
            // battleshipButton
            // 
            this.battleshipButton.Location = new System.Drawing.Point(200, 240);
            this.battleshipButton.Name = "battleshipButton";
            this.battleshipButton.Size = new System.Drawing.Size(100, 40);
            this.battleshipButton.TabIndex = 2;
            this.battleshipButton.Text = "Battleship";
            this.battleshipButton.UseVisualStyleBackColor = true;
            this.battleshipButton.Click += new System.EventHandler(this.battleshipButton_Click);
            // 
            // LogicGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 391);
            this.Controls.Add(this.battleshipButton);
            this.Controls.Add(this.snakeButton);
            this.Controls.Add(this.sudokuButton);
            this.Name = "LogicGames";
            this.Text = "Logic Games";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sudokuButton;
        private System.Windows.Forms.Button snakeButton;
        private System.Windows.Forms.Button battleshipButton;
    }
}

