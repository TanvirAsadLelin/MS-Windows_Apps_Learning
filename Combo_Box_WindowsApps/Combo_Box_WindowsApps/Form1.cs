namespace Combo_Box_WindowsApps
{
    public partial class MyComboBox : Form
    {
        public MyComboBox()
        {
            InitializeComponent();
        }

        private void myHobbiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string  itemName = textBoxAddItem.Text;

            myHobbiesComboBox.Items.Add(itemName);
            textBoxAddItem.Clear();
            textBoxAddItem.Focus();

           
        }

        private void buttonCountItem_Click(object sender, EventArgs e)
        {
            int itemCount = myHobbiesComboBox.Items.Count;

            lblCountItem.Text = "Total item" + itemCount.ToString();
        }
    }
}