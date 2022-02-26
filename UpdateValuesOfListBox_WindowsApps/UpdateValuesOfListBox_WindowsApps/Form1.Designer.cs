namespace UpdateValuesOfListBox_WindowsApps
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
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.textBoxUpdateItem = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxItem
            // 
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 16;
            this.listBoxItem.Items.AddRange(new object[] {
            "Lelin",
            "Asad",
            "Tanvir",
            "Israt",
            "Jahan",
            "Sathi",
            "Tofiz",
            "Kazol",
            "Sattar",
            "Moriom"});
            this.listBoxItem.Location = new System.Drawing.Point(42, 26);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(224, 404);
            this.listBoxItem.TabIndex = 0;
            this.listBoxItem.SelectedIndexChanged += new System.EventHandler(this.listBoxItem_SelectedIndexChanged);
            // 
            // textBoxUpdateItem
            // 
            this.textBoxUpdateItem.Location = new System.Drawing.Point(430, 60);
            this.textBoxUpdateItem.Multiline = true;
            this.textBoxUpdateItem.Name = "textBoxUpdateItem";
            this.textBoxUpdateItem.Size = new System.Drawing.Size(252, 40);
            this.textBoxUpdateItem.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(522, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBoxUpdateItem);
            this.Controls.Add(this.listBoxItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItem;
        private System.Windows.Forms.TextBox textBoxUpdateItem;
        private System.Windows.Forms.Button btnUpdate;
    }
}

