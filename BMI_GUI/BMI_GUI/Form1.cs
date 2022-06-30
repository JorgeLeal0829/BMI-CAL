namespace BMI_GUI
{
    public partial class Form1 : Form
    {
        int H;
        int W;
        int bmi;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            W = int.Parse(textBox1.Text);
            H = int.Parse(textBox2.Text);
            bmi = ((int)(W / Math.Pow(H, 2) * 703)); //BMI formula in C# 
            textBox3.Text = String.Format("{0:f}",bmi);


            


            

        }
    }
}