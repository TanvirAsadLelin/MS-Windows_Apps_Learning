namespace List_Box_MSWindowsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pigeonsListBox.Items.Add(txtAddItemName.Text);
            txtAddItemName.Clear();
            txtAddItemName.Focus();
        }

        private void btnCountItem_Click(object sender, EventArgs e)
        {
            int count = pigeonsListBox.Items.Count;
            MessageBox.Show("Total item is :"+ count.ToString());
        }

        private void btnSortItem_Click(object sender, EventArgs e)
        {
            pigeonsListBox.Sorted = true;
              
        }

        private void btnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
          //  pigeonsListBox.Items.Remove(pigeonsListBox.SelectedItem);
            pigeonsListBox.Items.RemoveAt(pigeonsListBox.SelectedIndex);

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            pigeonsListBox.Items.Clear();
        }
    }
}