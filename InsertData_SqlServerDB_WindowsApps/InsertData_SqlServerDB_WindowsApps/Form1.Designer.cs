namespace InsertData_SqlServerDB_WindowsApps
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.comboBoxCustomerGender = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorProviderCID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCAddress = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Informatoin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID: ";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(319, 101);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(248, 22);
            this.textBoxCustomerID.TabIndex = 0;
            this.textBoxCustomerID.Leave += new System.EventHandler(this.textBoxCustomerID_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name: ";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(319, 153);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(248, 22);
            this.textBoxCustomerName.TabIndex = 1;
            this.textBoxCustomerName.Leave += new System.EventHandler(this.textBoxCustomerName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer Gender: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer Address: ";
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(319, 280);
            this.textBoxCustomerAddress.Multiline = true;
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(248, 74);
            this.textBoxCustomerAddress.TabIndex = 3;
            this.textBoxCustomerAddress.Leave += new System.EventHandler(this.textBoxCustomerAddress_Leave);
            // 
            // comboBoxCustomerGender
            // 
            this.comboBoxCustomerGender.FormattingEnabled = true;
            this.comboBoxCustomerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxCustomerGender.Location = new System.Drawing.Point(319, 215);
            this.comboBoxCustomerGender.Name = "comboBoxCustomerGender";
            this.comboBoxCustomerGender.Size = new System.Drawing.Size(248, 24);
            this.comboBoxCustomerGender.TabIndex = 2;
            this.comboBoxCustomerGender.Leave += new System.EventHandler(this.comboBoxCustomerGender_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(312, 382);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 56);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProviderCID
            // 
            this.errorProviderCID.ContainerControl = this;
            // 
            // errorProviderCName
            // 
            this.errorProviderCName.ContainerControl = this;
            // 
            // errorProviderCGender
            // 
            this.errorProviderCGender.ContainerControl = this;
            // 
            // errorProviderCAddress
            // 
            this.errorProviderCAddress.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 498);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBoxCustomerGender);
            this.Controls.Add(this.textBoxCustomerAddress);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Insert data into SQL DB";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCustomerAddress;
        private System.Windows.Forms.ComboBox comboBoxCustomerGender;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProviderCID;
        private System.Windows.Forms.ErrorProvider errorProviderCName;
        private System.Windows.Forms.ErrorProvider errorProviderCGender;
        private System.Windows.Forms.ErrorProvider errorProviderCAddress;
    }
}

