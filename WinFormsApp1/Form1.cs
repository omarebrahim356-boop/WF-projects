namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void t1_Scroll(object sender, EventArgs e)
        {
            GetColor();
        }
        private void GetColor()
        {
            int A = t1.Value;
            int R = t2.Value;
            int G = t3.Value;
            int B = t4.Value;
            pictureBox1.BackColor = Color.FromArgb(A, R, G, B);
        }

        private void t2_Scroll(object sender, EventArgs e)
        {
            GetColor();
        }

        private void t3_Scroll(object sender, EventArgs e)
        {
            GetColor();
        }

        private void t4_Scroll(object sender, EventArgs e)
        {
            GetColor();
        }
    }
}