namespace Internal_1
{
    partial class task6
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
            btn1 = new Button();
            txt1 = new TextBox();
            label1 = new Label();
            lb1 = new ListBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(68, 157);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 0;
            btn1.Text = "Convert";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(68, 84);
            txt1.Name = "txt1";
            txt1.Size = new Size(271, 27);
            txt1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 30);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Word Frequency";
            // 
            // lb1
            // 
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 20;
            lb1.Location = new Point(80, 254);
            lb1.Name = "lb1";
            lb1.Size = new Size(320, 184);
            lb1.TabIndex = 3;
            // 
            // task6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(lb1);
            Controls.Add(label1);
            Controls.Add(txt1);
            Controls.Add(btn1);
            Name = "task6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task-6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private TextBox txt1;
        private Label label1;
        private ListBox lb1;
    }
}