
namespace KontrahenciAlt2
{
    partial class Form2
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
            System.Windows.Forms.Label label5;
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNIP = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(137, 125);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 17);
            label5.TabIndex = 9;
            label5.Text = "Adres:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(192, 35);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(525, 22);
            this.textName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wprowadź dane:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma/Imię i Nazwisko:";
            // 
            // textNIP
            // 
            this.textNIP.Location = new System.Drawing.Point(192, 64);
            this.textNIP.Name = "textNIP";
            this.textNIP.Size = new System.Drawing.Size(525, 22);
            this.textNIP.TabIndex = 3;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(192, 93);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(525, 22);
            this.textCity.TabIndex = 4;
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(192, 122);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(525, 22);
            this.textAdress.TabIndex = 5;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(192, 151);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(525, 22);
            this.textPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "NIP/PESEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Miasto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nr tel.:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(192, 180);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 31);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 223);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textAdress);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textNIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Name = "Form2";
            this.Text = "Dodaj kontrahenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNIP;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
    }
}