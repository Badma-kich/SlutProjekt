namespace SlutUppgift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F�nster = new Form2();
            F�nster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F�nster = new Form3();
            F�nster.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form F�nster = new Form4();
            F�nster.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form F�nster = new Form5();
            F�nster.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form F�nster = new Form6();
            F�nster.Show();
        }
    }
}