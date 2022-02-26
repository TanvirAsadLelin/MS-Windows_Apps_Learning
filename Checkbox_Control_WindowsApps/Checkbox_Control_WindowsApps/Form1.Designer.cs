namespace Checkbox_Control_WindowsApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSamsung = new System.Windows.Forms.CheckBox();
            this.checkBoxNokia = new System.Windows.Forms.CheckBox();
            this.checkBoxSymphonoy = new System.Windows.Forms.CheckBox();
            this.checkBoxRedmi = new System.Windows.Forms.CheckBox();
            this.checkBoxOppo = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.checkBoxEnable = new System.Windows.Forms.CheckBox();
            this.btnMybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your favourite mobile company";
            // 
            // checkBoxSamsung
            // 
            this.checkBoxSamsung.AutoSize = true;
            this.checkBoxSamsung.Location = new System.Drawing.Point(50, 84);
            this.checkBoxSamsung.Name = "checkBoxSamsung";
            this.checkBoxSamsung.Size = new System.Drawing.Size(86, 20);
            this.checkBoxSamsung.TabIndex = 1;
            this.checkBoxSamsung.Text = "Samsung";
            this.checkBoxSamsung.UseVisualStyleBackColor = true;
            this.checkBoxSamsung.CheckedChanged += new System.EventHandler(this.checkBoxSamsung_CheckedChanged);
            // 
            // checkBoxNokia
            // 
            this.checkBoxNokia.AutoSize = true;
            this.checkBoxNokia.Location = new System.Drawing.Point(50, 117);
            this.checkBoxNokia.Name = "checkBoxNokia";
            this.checkBoxNokia.Size = new System.Drawing.Size(65, 20);
            this.checkBoxNokia.TabIndex = 1;
            this.checkBoxNokia.Text = "Nokia";
            this.checkBoxNokia.UseVisualStyleBackColor = true;
            this.checkBoxNokia.CheckedChanged += new System.EventHandler(this.checkBoxNokia_CheckedChanged);
            // 
            // checkBoxSymphonoy
            // 
            this.checkBoxSymphonoy.AutoSize = true;
            this.checkBoxSymphonoy.Location = new System.Drawing.Point(50, 147);
            this.checkBoxSymphonoy.Name = "checkBoxSymphonoy";
            this.checkBoxSymphonoy.Size = new System.Drawing.Size(101, 20);
            this.checkBoxSymphonoy.TabIndex = 1;
            this.checkBoxSymphonoy.Text = "Symphonoy";
            this.checkBoxSymphonoy.UseVisualStyleBackColor = true;
            this.checkBoxSymphonoy.CheckedChanged += new System.EventHandler(this.checkBoxSymphonoy_CheckedChanged);
            // 
            // checkBoxRedmi
            // 
            this.checkBoxRedmi.AutoSize = true;
            this.checkBoxRedmi.Location = new System.Drawing.Point(50, 179);
            this.checkBoxRedmi.Name = "checkBoxRedmi";
            this.checkBoxRedmi.Size = new System.Drawing.Size(69, 20);
            this.checkBoxRedmi.TabIndex = 1;
            this.checkBoxRedmi.Text = "Redmi";
            this.checkBoxRedmi.UseVisualStyleBackColor = true;
            this.checkBoxRedmi.CheckedChanged += new System.EventHandler(this.checkBoxRedmi_CheckedChanged);
            // 
            // checkBoxOppo
            // 
            this.checkBoxOppo.AutoSize = true;
            this.checkBoxOppo.Location = new System.Drawing.Point(50, 209);
            this.checkBoxOppo.Name = "checkBoxOppo";
            this.checkBoxOppo.Size = new System.Drawing.Size(63, 20);
            this.checkBoxOppo.TabIndex = 1;
            this.checkBoxOppo.Text = "Oppo";
            this.checkBoxOppo.UseVisualStyleBackColor = true;
            this.checkBoxOppo.CheckedChanged += new System.EventHandler(this.checkBoxOppo_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(50, 252);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 47);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // checkBoxEnable
            // 
            this.checkBoxEnable.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxEnable.Image")));
            this.checkBoxEnable.Location = new System.Drawing.Point(50, 328);
            this.checkBoxEnable.Name = "checkBoxEnable";
            this.checkBoxEnable.Size = new System.Drawing.Size(104, 59);
            this.checkBoxEnable.TabIndex = 3;
            this.checkBoxEnable.Text = "Enable";
            this.checkBoxEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxEnable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBoxEnable.UseVisualStyleBackColor = true;
            this.checkBoxEnable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnMybutton
            // 
            this.btnMybutton.Enabled = false;
            this.btnMybutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMybutton.Location = new System.Drawing.Point(196, 328);
            this.btnMybutton.Name = "btnMybutton";
            this.btnMybutton.Size = new System.Drawing.Size(141, 45);
            this.btnMybutton.TabIndex = 4;
            this.btnMybutton.Text = "My button";
            this.btnMybutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMybutton);
            this.Controls.Add(this.checkBoxEnable);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.checkBoxOppo);
            this.Controls.Add(this.checkBoxRedmi);
            this.Controls.Add(this.checkBoxSymphonoy);
            this.Controls.Add(this.checkBoxNokia);
            this.Controls.Add(this.checkBoxSamsung);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSamsung;
        private System.Windows.Forms.CheckBox checkBoxNokia;
        private System.Windows.Forms.CheckBox checkBoxSymphonoy;
        private System.Windows.Forms.CheckBox checkBoxRedmi;
        private System.Windows.Forms.CheckBox checkBoxOppo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox checkBoxEnable;
        private System.Windows.Forms.Button btnMybutton;
    }
}

