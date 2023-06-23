namespace Internal_1
{
    partial class task4
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
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            A4 = new Button();
            A5 = new Button();
            A6 = new Button();
            A7 = new Button();
            A8 = new Button();
            A9 = new Button();
            btnreset = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // A1
            // 
            A1.Location = new Point(12, 48);
            A1.Name = "A1";
            A1.Size = new Size(100, 100);
            A1.TabIndex = 0;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_click;
            // 
            // A2
            // 
            A2.Location = new Point(118, 48);
            A2.Name = "A2";
            A2.Size = new Size(100, 100);
            A2.TabIndex = 1;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_click;
            // 
            // A3
            // 
            A3.Location = new Point(224, 48);
            A3.Name = "A3";
            A3.Size = new Size(100, 100);
            A3.TabIndex = 2;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_click;
            // 
            // A4
            // 
            A4.Location = new Point(12, 166);
            A4.Name = "A4";
            A4.Size = new Size(100, 100);
            A4.TabIndex = 3;
            A4.UseVisualStyleBackColor = true;
            A4.Click += button_click;
            // 
            // A5
            // 
            A5.Location = new Point(118, 166);
            A5.Name = "A5";
            A5.Size = new Size(100, 100);
            A5.TabIndex = 4;
            A5.UseVisualStyleBackColor = true;
            A5.Click += button_click;
            // 
            // A6
            // 
            A6.Location = new Point(224, 166);
            A6.Name = "A6";
            A6.Size = new Size(100, 100);
            A6.TabIndex = 5;
            A6.UseVisualStyleBackColor = true;
            A6.Click += button_click;
            // 
            // A7
            // 
            A7.Location = new Point(12, 272);
            A7.Name = "A7";
            A7.Size = new Size(100, 100);
            A7.TabIndex = 6;
            A7.UseVisualStyleBackColor = true;
            A7.Click += button_click;
            // 
            // A8
            // 
            A8.Location = new Point(118, 272);
            A8.Name = "A8";
            A8.Size = new Size(100, 100);
            A8.TabIndex = 7;
            A8.UseVisualStyleBackColor = true;
            A8.Click += button_click;
            // 
            // A9
            // 
            A9.Location = new Point(224, 272);
            A9.Name = "A9";
            A9.Size = new Size(100, 100);
            A9.TabIndex = 8;
            A9.UseVisualStyleBackColor = true;
            A9.Click += button_click;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(370, 93);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(100, 100);
            btnreset.TabIndex = 9;
            btnreset.Text = "RESET";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(370, 226);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(100, 100);
            btnexit.TabIndex = 10;
            btnexit.Text = "EXIT";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // task4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(btnexit);
            Controls.Add(btnreset);
            Controls.Add(A9);
            Controls.Add(A8);
            Controls.Add(A7);
            Controls.Add(A6);
            Controls.Add(A5);
            Controls.Add(A4);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Name = "task4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            ResumeLayout(false);
        }

        #endregion

        private Button A1;
        private Button A2;
        private Button A3;
        private Button A4;
        private Button A5;
        private Button A6;
        private Button A7;
        private Button A8;
        private Button A9;
        private Button btnreset;
        private Button btnexit;
    }
}