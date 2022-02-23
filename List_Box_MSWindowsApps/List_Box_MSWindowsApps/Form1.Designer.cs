namespace List_Box_MSWindowsApps
{
    partial class Form1
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
            this.pigeonsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddItemName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCountItem = new System.Windows.Forms.Button();
            this.btnSortItem = new System.Windows.Forms.Button();
            this.btnRemoveSelectedItem = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pigeonsListBox
            // 
            this.pigeonsListBox.FormattingEnabled = true;
            this.pigeonsListBox.ItemHeight = 20;
            this.pigeonsListBox.Items.AddRange(new object[] {
            "Shiraji",
            "Lokkha",
            "Koka",
            "Giribaj",
            "Kakji",
            "Bombai",
            "Tailmark",
            "Fantail",
            "Nan",
            "Huma",
            "Shuyachondon",
            "King",
            "Moyna jak",
            "kaldom"});
            this.pigeonsListBox.Location = new System.Drawing.Point(12, 33);
            this.pigeonsListBox.Name = "pigeonsListBox";
            this.pigeonsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pigeonsListBox.Size = new System.Drawing.Size(210, 484);
            this.pigeonsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Item:";
            // 
            // txtAddItemName
            // 
            this.txtAddItemName.Location = new System.Drawing.Point(399, 33);
            this.txtAddItemName.Multiline = true;
            this.txtAddItemName.Name = "txtAddItemName";
            this.txtAddItemName.Size = new System.Drawing.Size(265, 34);
            this.txtAddItemName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(459, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 56);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCountItem
            // 
            this.btnCountItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCountItem.Location = new System.Drawing.Point(459, 172);
            this.btnCountItem.Name = "btnCountItem";
            this.btnCountItem.Size = new System.Drawing.Size(121, 53);
            this.btnCountItem.TabIndex = 4;
            this.btnCountItem.Text = "Count Item";
            this.btnCountItem.UseVisualStyleBackColor = true;
            this.btnCountItem.Click += new System.EventHandler(this.btnCountItem_Click);
            // 
            // btnSortItem
            // 
            this.btnSortItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSortItem.Location = new System.Drawing.Point(459, 254);
            this.btnSortItem.Name = "btnSortItem";
            this.btnSortItem.Size = new System.Drawing.Size(121, 53);
            this.btnSortItem.TabIndex = 5;
            this.btnSortItem.Text = "Sort Item";
            this.btnSortItem.UseVisualStyleBackColor = true;
            this.btnSortItem.Click += new System.EventHandler(this.btnSortItem_Click);
            // 
            // btnRemoveSelectedItem
            // 
            this.btnRemoveSelectedItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSelectedItem.Location = new System.Drawing.Point(415, 336);
            this.btnRemoveSelectedItem.Name = "btnRemoveSelectedItem";
            this.btnRemoveSelectedItem.Size = new System.Drawing.Size(218, 53);
            this.btnRemoveSelectedItem.TabIndex = 6;
            this.btnRemoveSelectedItem.Text = "Remove Selected Item";
            this.btnRemoveSelectedItem.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedItem.Click += new System.EventHandler(this.btnRemoveSelectedItem_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearAll.Location = new System.Drawing.Point(415, 429);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(218, 53);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All Items";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 548);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveSelectedItem);
            this.Controls.Add(this.btnSortItem);
            this.Controls.Add(this.btnCountItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pigeonsListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Box Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox pigeonsListBox;
        private Label label1;
        private TextBox txtAddItemName;
        private Button btnAdd;
        private Button btnCountItem;
        private Button btnSortItem;
        private Button btnRemoveSelectedItem;
        private Button btnClearAll;
    }
}