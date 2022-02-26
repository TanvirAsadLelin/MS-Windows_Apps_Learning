namespace CheckListBox_WindowsApps
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxItems = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxGetItem = new System.Windows.Forms.ListBox();
            this.listBoxIndexItems = new System.Windows.Forms.ListBox();
            this.btnGetItems = new System.Windows.Forms.Button();
            this.btnItemIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check list box demo";
            // 
            // checkedListBoxItems
            // 
            this.checkedListBoxItems.FormattingEnabled = true;
            this.checkedListBoxItems.Items.AddRange(new object[] {
            "Reading",
            "Writing",
            "Coding",
            "Browsing",
            "Cricket",
            "Football"});
            this.checkedListBoxItems.Location = new System.Drawing.Point(102, 140);
            this.checkedListBoxItems.Name = "checkedListBoxItems";
            this.checkedListBoxItems.Size = new System.Drawing.Size(155, 157);
            this.checkedListBoxItems.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select your hobbies";
            // 
            // listBoxGetItem
            // 
            this.listBoxGetItem.FormattingEnabled = true;
            this.listBoxGetItem.ItemHeight = 16;
            this.listBoxGetItem.Location = new System.Drawing.Point(80, 363);
            this.listBoxGetItem.Name = "listBoxGetItem";
            this.listBoxGetItem.Size = new System.Drawing.Size(212, 116);
            this.listBoxGetItem.TabIndex = 3;
            // 
            // listBoxIndexItems
            // 
            this.listBoxIndexItems.FormattingEnabled = true;
            this.listBoxIndexItems.ItemHeight = 16;
            this.listBoxIndexItems.Location = new System.Drawing.Point(402, 360);
            this.listBoxIndexItems.Name = "listBoxIndexItems";
            this.listBoxIndexItems.Size = new System.Drawing.Size(203, 116);
            this.listBoxIndexItems.TabIndex = 3;
            // 
            // btnGetItems
            // 
            this.btnGetItems.Location = new System.Drawing.Point(137, 323);
            this.btnGetItems.Name = "btnGetItems";
            this.btnGetItems.Size = new System.Drawing.Size(75, 23);
            this.btnGetItems.TabIndex = 4;
            this.btnGetItems.Text = "Get items";
            this.btnGetItems.UseVisualStyleBackColor = true;
            this.btnGetItems.Click += new System.EventHandler(this.btnGetItems_Click);
            // 
            // btnItemIndex
            // 
            this.btnItemIndex.Location = new System.Drawing.Point(433, 321);
            this.btnItemIndex.Name = "btnItemIndex";
            this.btnItemIndex.Size = new System.Drawing.Size(130, 23);
            this.btnItemIndex.TabIndex = 4;
            this.btnItemIndex.Text = "Get item index";
            this.btnItemIndex.UseVisualStyleBackColor = true;
            this.btnItemIndex.Click += new System.EventHandler(this.btnItemIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btnItemIndex);
            this.Controls.Add(this.btnGetItems);
            this.Controls.Add(this.listBoxIndexItems);
            this.Controls.Add(this.listBoxGetItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxItems);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxGetItem;
        private System.Windows.Forms.ListBox listBoxIndexItems;
        private System.Windows.Forms.Button btnGetItems;
        private System.Windows.Forms.Button btnItemIndex;
    }
}

