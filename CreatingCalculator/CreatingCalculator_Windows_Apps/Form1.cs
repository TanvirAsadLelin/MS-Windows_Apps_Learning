namespace CreatingCalculator_Windows_Apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstNumber.Text != "" && txtFirstNumber.Text != "")
            {
                int num1 = int.Parse(txtFirstNumber.Text);
                int num2 = int.Parse(txtSecondNumber.Text);

                int result = num1 + num2;

                //  MessageBox.Show("The addition result is " + result.ToString());
                lblShowResult.Text = "The result is " + result.ToString();
                lblShowResult.Visible
                    = true;

            }

            else
            {
                lblShowResult.Text = "Please insert two numbers";

                lblShowResult.Visible = true;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtFirstNumber.Text != "" && txtFirstNumber.Text != "")
            {
                int num1 = int.Parse(txtFirstNumber.Text);
                int num2 = int.Parse(txtSecondNumber.Text);

                int result = num1 - num2;

                //  MessageBox.Show("The addition result is " + result.ToString());
                lblShowResult.Text = "The result is " + result.ToString();
                lblShowResult.Visible
                    = true;

            }

            else
            {
                lblShowResult.Text = "Please insert two numbers";

                lblShowResult.Visible = true;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtFirstNumber.Text != "" && txtFirstNumber.Text != "")
            {
                int num1 = int.Parse(txtFirstNumber.Text);
                int num2 = int.Parse(txtSecondNumber.Text);

                int result = num1 * num2;

                //  MessageBox.Show("The addition result is " + result.ToString());
                lblShowResult.Text = "The result is " + result.ToString();
                lblShowResult.Visible
                    = true;

            }

            else
            {
                lblShowResult.Text = "Please insert two numbers";

                lblShowResult.Visible = true;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtFirstNumber.Text != "" && txtFirstNumber.Text != "")
            {
                int num1 = int.Parse(txtFirstNumber.Text);
                int num2 = int.Parse(txtSecondNumber.Text);

                int result = num1 / num2;

                //  MessageBox.Show("The addition result is " + result.ToString());
                lblShowResult.Text = "The result is " + result.ToString();
                lblShowResult.Visible
                    = true;

            }

            else
            {
                lblShowResult.Text = "Please insert two numbers";

                lblShowResult.Visible = true;
            }
        }
    }
}