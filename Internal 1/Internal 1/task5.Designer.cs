namespace Internal_1
{
    partial class task5
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
            txt1 = new TextBox();
            lbl1 = new Label();
            btn1 = new Button();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(35, 88);
            txt1.MaxLength = 80;
            txt1.Name = "txt1";
            txt1.Size = new Size(401, 27);
            txt1.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(50, 280);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 20);
            lbl1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(126, 176);
            btn1.Name = "btn1";
            btn1.Size = new Size(200, 50);
            btn1.TabIndex = 2;
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // task5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(btn1);
            Controls.Add(lbl1);
            Controls.Add(txt1);
            Name = "task5";
            Text = "Task-5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private Label lbl1;
        private Button btn1;
    }
}