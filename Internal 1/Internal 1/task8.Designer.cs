namespace Internal_1
{
    partial class task8
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
            label1 = new Label();
            lblresult = new Label();
            btnconvert = new Button();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(56, 113);
            txt1.Name = "txt1";
            txt1.Size = new Size(332, 27);
            txt1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Change Vowel";
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Location = new Point(56, 250);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(0, 20);
            lblresult.TabIndex = 2;
            // 
            // btnconvert
            // 
            btnconvert.Location = new Point(56, 182);
            btnconvert.Name = "btnconvert";
            btnconvert.Size = new Size(94, 29);
            btnconvert.TabIndex = 3;
            btnconvert.Text = "Convert";
            btnconvert.UseVisualStyleBackColor = true;
            btnconvert.Click += btnconvert_Click;
            // 
            // task8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(btnconvert);
            Controls.Add(lblresult);
            Controls.Add(label1);
            Controls.Add(txt1);
            Name = "task8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task-8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private Label label1;
        private Label lblresult;
        private Button btnconvert;
    }
}