namespace Introduction_windows_Apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("This is from.");

            // MessageBox.Show(txtInput.Text);

            lblShowText.Text = txtInput.Text;

            lblShowText.Visible = true;
           

        }
    }
}