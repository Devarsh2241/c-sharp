namespace Internal_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task1 task1 = new task1();
            task1.Show();
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task2 task2 = new task2();
            task2.Show();
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Due to COVID,it is under process");
        }

        private void task4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task4 task4 = new task4();
            task4.Show();
        }

        private void task5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task5 task5 = new task5();
            task5.Show();
        }

        private void task6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task6 task6 = new task6();
            task6.Show();
        }

        private void task7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task7 task7 = new task7();
            task7.Show();
        }

        private void task8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task8 task8 = new task8();
            task8.Show();
        }
    }
}