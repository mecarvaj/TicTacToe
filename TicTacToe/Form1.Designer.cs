namespace TicTacToe
{
    partial class fTicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pGame = new Panel();
            b3x3 = new Button();
            b3x2 = new Button();
            b3x1 = new Button();
            b2x3 = new Button();
            b2x2 = new Button();
            b2x1 = new Button();
            b1x3 = new Button();
            b1x2 = new Button();
            b1x1 = new Button();
            bReset = new Button();
            pGame.SuspendLayout();
            SuspendLayout();
            // 
            // pGame
            // 
            pGame.BackColor = SystemColors.ControlLightLight;
            pGame.Controls.Add(b3x3);
            pGame.Controls.Add(b3x2);
            pGame.Controls.Add(b3x1);
            pGame.Controls.Add(b2x3);
            pGame.Controls.Add(b2x2);
            pGame.Controls.Add(b2x1);
            pGame.Controls.Add(b1x3);
            pGame.Controls.Add(b1x2);
            pGame.Controls.Add(b1x1);
            pGame.Location = new Point(95, 95);
            pGame.Name = "pGame";
            pGame.Size = new Size(360, 360);
            pGame.TabIndex = 1;
            // 
            // b3x3
            // 
            b3x3.FlatAppearance.BorderColor = Color.White;
            b3x3.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b3x3.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b3x3.FlatStyle = FlatStyle.Flat;
            b3x3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b3x3.Location = new Point(240, 240);
            b3x3.Name = "b3x3";
            b3x3.Size = new Size(120, 120);
            b3x3.TabIndex = 18;
            b3x3.UseVisualStyleBackColor = true;
            b3x3.Click += onFieldClicked;
            // 
            // b3x2
            // 
            b3x2.FlatAppearance.BorderColor = Color.White;
            b3x2.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b3x2.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b3x2.FlatStyle = FlatStyle.Flat;
            b3x2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b3x2.Location = new Point(120, 240);
            b3x2.Name = "b3x2";
            b3x2.Size = new Size(120, 120);
            b3x2.TabIndex = 17;
            b3x2.UseVisualStyleBackColor = true;
            b3x2.Click += onFieldClicked;
            // 
            // b3x1
            // 
            b3x1.FlatAppearance.BorderColor = Color.White;
            b3x1.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b3x1.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b3x1.FlatStyle = FlatStyle.Flat;
            b3x1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b3x1.Location = new Point(0, 240);
            b3x1.Name = "b3x1";
            b3x1.Size = new Size(120, 120);
            b3x1.TabIndex = 16;
            b3x1.UseVisualStyleBackColor = true;
            b3x1.Click += onFieldClicked;
            // 
            // b2x3
            // 
            b2x3.FlatAppearance.BorderColor = Color.White;
            b2x3.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b2x3.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b2x3.FlatStyle = FlatStyle.Flat;
            b2x3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b2x3.Location = new Point(240, 120);
            b2x3.Name = "b2x3";
            b2x3.Size = new Size(120, 120);
            b2x3.TabIndex = 15;
            b2x3.UseVisualStyleBackColor = true;
            b2x3.Click += onFieldClicked;
            // 
            // b2x2
            // 
            b2x2.FlatAppearance.BorderColor = Color.White;
            b2x2.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b2x2.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b2x2.FlatStyle = FlatStyle.Flat;
            b2x2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b2x2.Location = new Point(120, 120);
            b2x2.Name = "b2x2";
            b2x2.Size = new Size(120, 120);
            b2x2.TabIndex = 14;
            b2x2.UseVisualStyleBackColor = true;
            b2x2.Click += onFieldClicked;
            // 
            // b2x1
            // 
            b2x1.FlatAppearance.BorderColor = Color.White;
            b2x1.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b2x1.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b2x1.FlatStyle = FlatStyle.Flat;
            b2x1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b2x1.Location = new Point(0, 120);
            b2x1.Name = "b2x1";
            b2x1.Size = new Size(120, 120);
            b2x1.TabIndex = 13;
            b2x1.UseVisualStyleBackColor = true;
            b2x1.Click += onFieldClicked;
            // 
            // b1x3
            // 
            b1x3.FlatAppearance.BorderColor = Color.White;
            b1x3.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b1x3.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b1x3.FlatStyle = FlatStyle.Flat;
            b1x3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b1x3.Location = new Point(240, 0);
            b1x3.Name = "b1x3";
            b1x3.Size = new Size(120, 120);
            b1x3.TabIndex = 12;
            b1x3.UseVisualStyleBackColor = true;
            b1x3.Click += onFieldClicked;
            // 
            // b1x2
            // 
            b1x2.FlatAppearance.BorderColor = Color.White;
            b1x2.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b1x2.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b1x2.FlatStyle = FlatStyle.Flat;
            b1x2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b1x2.Location = new Point(120, 0);
            b1x2.Name = "b1x2";
            b1x2.Size = new Size(120, 120);
            b1x2.TabIndex = 11;
            b1x2.UseVisualStyleBackColor = true;
            b1x2.Click += onFieldClicked;
            // 
            // b1x1
            // 
            b1x1.FlatAppearance.BorderColor = Color.White;
            b1x1.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            b1x1.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            b1x1.FlatStyle = FlatStyle.Flat;
            b1x1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            b1x1.Location = new Point(0, 0);
            b1x1.Name = "b1x1";
            b1x1.Size = new Size(120, 120);
            b1x1.TabIndex = 10;
            b1x1.UseVisualStyleBackColor = true;
            b1x1.Click += onFieldClicked;
            // 
            // bReset
            // 
            bReset.FlatAppearance.BorderColor = Color.White;
            bReset.FlatAppearance.MouseDownBackColor = Color.White;
            bReset.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            bReset.FlatStyle = FlatStyle.Flat;
            bReset.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bReset.Location = new Point(368, 12);
            bReset.Name = "bReset";
            bReset.Size = new Size(87, 54);
            bReset.TabIndex = 4;
            bReset.Text = "Reset";
            bReset.UseVisualStyleBackColor = true;
            bReset.Click += bReset_Click;
            // 
            // fTicTacToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(534, 511);
            Controls.Add(bReset);
            Controls.Add(pGame);
            Name = "fTicTacToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            pGame.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pGame;
        private Button bReset;
        private Button b3x3;
        private Button b3x2;
        private Button b3x1;
        private Button b2x3;
        private Button b2x2;
        private Button b2x1;
        private Button b1x3;
        private Button b1x2;
        private Button b1x1;
    }
}