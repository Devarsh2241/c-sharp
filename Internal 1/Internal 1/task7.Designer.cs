namespace Internal_1
{
    partial class task7
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            lblbinary = new Label();
            lbloctal = new Label();
            lbldesimal = new Label();
            lblhexadesimal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 36);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Number System ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 86);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter a Number ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 144);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Binary Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 189);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "Octal Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 235);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 4;
            label5.Text = "Desimal Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 285);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 5;
            label6.Text = "Hexadesimal Number";
            // 
            // button1
            // 
            button1.Location = new Point(64, 351);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(196, 351);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(334, 351);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 9;
            // 
            // lblbinary
            // 
            lblbinary.AutoSize = true;
            lblbinary.Location = new Point(239, 146);
            lblbinary.Name = "lblbinary";
            lblbinary.Size = new Size(0, 20);
            lblbinary.TabIndex = 10;
            // 
            // lbloctal
            // 
            lbloctal.AutoSize = true;
            lbloctal.Location = new Point(238, 186);
            lbloctal.Name = "lbloctal";
            lbloctal.Size = new Size(0, 20);
            lbloctal.TabIndex = 11;
            // 
            // lbldesimal
            // 
            lbldesimal.AutoSize = true;
            lbldesimal.Location = new Point(238, 231);
            lbldesimal.Name = "lbldesimal";
            lbldesimal.Size = new Size(0, 20);
            lbldesimal.TabIndex = 12;
            // 
            // lblhexadesimal
            // 
            lblhexadesimal.AutoSize = true;
            lblhexadesimal.Location = new Point(233, 288);
            lblhexadesimal.Name = "lblhexadesimal";
            lblhexadesimal.Size = new Size(0, 20);
            lblhexadesimal.TabIndex = 13;
            // 
            // task7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 437);
            Controls.Add(lblhexadesimal);
            Controls.Add(lbldesimal);
            Controls.Add(lbloctal);
            Controls.Add(lblbinary);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "task7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task-7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label lblbinary;
        private Label lbloctal;
        private Label lbldesimal;
        private Label lblhexadesimal;
    }
}