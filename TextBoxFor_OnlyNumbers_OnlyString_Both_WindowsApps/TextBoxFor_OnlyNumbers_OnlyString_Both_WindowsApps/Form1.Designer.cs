namespace TextBoxFor_OnlyNumbers_OnlyString_Both_WindowsApps
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
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBoth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numbers";
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(153, 57);
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(223, 22);
            this.textBoxNumbers.TabIndex = 0;
            this.textBoxNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(153, 129);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(223, 22);
            this.textBoxText.TabIndex = 1;
            this.textBoxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Both";
            // 
            // textBoxBoth
            // 
            this.textBoxBoth.Location = new System.Drawing.Point(153, 202);
            this.textBoxBoth.Name = "textBoxBoth";
            this.textBoxBoth.Size = new System.Drawing.Size(223, 22);
            this.textBoxBoth.TabIndex = 2;
            this.textBoxBoth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBoth_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 298);
            this.Controls.Add(this.textBoxBoth);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxNumbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TextBox validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBoth;
    }
}

