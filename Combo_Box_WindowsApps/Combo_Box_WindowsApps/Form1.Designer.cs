namespace Combo_Box_WindowsApps
{
    partial class MyComboBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myHobbiesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddItem = new System.Windows.Forms.TextBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonCountItem = new System.Windows.Forms.Button();
            this.lblCountItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myHobbiesComboBox
            // 
            this.myHobbiesComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.myHobbiesComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.myHobbiesComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.myHobbiesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myHobbiesComboBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myHobbiesComboBox.ForeColor = System.Drawing.Color.Black;
            this.myHobbiesComboBox.FormattingEnabled = true;
            this.myHobbiesComboBox.Items.AddRange(new object[] {
            "Browsing internet",
            "Writing",
            "Listening",
            "Signing",
            "Swimming",
            "Reading",
            "Cricket",
            "Football",
            ""});
            this.myHobbiesComboBox.Location = new System.Drawing.Point(213, 169);
            this.myHobbiesComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.myHobbiesComboBox.Name = "myHobbiesComboBox";
            this.myHobbiesComboBox.Size = new System.Drawing.Size(419, 25);
            this.myHobbiesComboBox.TabIndex = 0;
            this.myHobbiesComboBox.SelectedIndexChanged += new System.EventHandler(this.myHobbiesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hobbies:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Item:";
            // 
            // textBoxAddItem
            // 
            this.textBoxAddItem.Location = new System.Drawing.Point(213, 43);
            this.textBoxAddItem.Multiline = true;
            this.textBoxAddItem.Name = "textBoxAddItem";
            this.textBoxAddItem.Size = new System.Drawing.Size(249, 34);
            this.textBoxAddItem.TabIndex = 3;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(515, 45);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(94, 29);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonCountItem
            // 
            this.buttonCountItem.Location = new System.Drawing.Point(122, 236);
            this.buttonCountItem.Name = "buttonCountItem";
            this.buttonCountItem.Size = new System.Drawing.Size(123, 29);
            this.buttonCountItem.TabIndex = 5;
            this.buttonCountItem.Text = "Count Item";
            this.buttonCountItem.UseVisualStyleBackColor = true;
            this.buttonCountItem.Visible = false;
            this.buttonCountItem.Click += new System.EventHandler(this.buttonCountItem_Click);
            // 
            // lblCountItem
            // 
            this.lblCountItem.AutoSize = true;
            this.lblCountItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountItem.Location = new System.Drawing.Point(251, 238);
            this.lblCountItem.Name = "lblCountItem";
            this.lblCountItem.Size = new System.Drawing.Size(81, 23);
            this.lblCountItem.TabIndex = 6;
            this.lblCountItem.Text = "lblCount";
            this.lblCountItem.Visible = false;
            // 
            // MyComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.lblCountItem);
            this.Controls.Add(this.buttonCountItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.textBoxAddItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myHobbiesComboBox);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Box Windows Apps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox myHobbiesComboBox;
        private Label label1;
        private Label label2;
        private TextBox textBoxAddItem;
        private Button buttonAddItem;
        private Button buttonCountItem;
        private Label lblCountItem;
    }
}