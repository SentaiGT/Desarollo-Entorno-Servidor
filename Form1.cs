namespace WinFormsApp1
{
    public partial class label1 : Form
    {
        public label1()
        {
            InitializeComponent();
        }

        private void label1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }
    }
}
