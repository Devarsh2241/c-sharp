namespace Internal_1
{
    partial class task2
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
            btnsubmit = new Button();
            txt1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(148, 198);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(94, 29);
            btnsubmit.TabIndex = 0;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(59, 118);
            txt1.Name = "txt1";
            txt1.Size = new Size(294, 27);
            txt1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 51);
            label1.Name = "label1";
            label1.Size = new Size(232, 20);
            label1.TabIndex = 2;
            label1.Text = "Check String is Pallindrome or not";
            // 
            // task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(label1);
            Controls.Add(txt1);
            Controls.Add(btnsubmit);
            Name = "task2";
            Text = "Task-2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsubmit;
        private TextBox txt1;
        private Label label1;
    }
}