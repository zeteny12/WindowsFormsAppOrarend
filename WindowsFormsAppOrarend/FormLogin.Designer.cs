namespace WindowsFormsAppOrarend
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Bejelentkezes = new System.Windows.Forms.Button();
            this.textBox_Jelszo = new System.Windows.Forms.TextBox();
            this.textBox_Felhasznalonev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bejelentkezés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(111, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jelszó:";
            // 
            // button_Bejelentkezes
            // 
            this.button_Bejelentkezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_Bejelentkezes.Location = new System.Drawing.Point(136, 236);
            this.button_Bejelentkezes.Name = "button_Bejelentkezes";
            this.button_Bejelentkezes.Size = new System.Drawing.Size(232, 52);
            this.button_Bejelentkezes.TabIndex = 1;
            this.button_Bejelentkezes.Text = "Bejelentkezés";
            this.button_Bejelentkezes.UseVisualStyleBackColor = true;
            this.button_Bejelentkezes.Click += new System.EventHandler(this.button_Bejelentkezes_Click);
            // 
            // textBox_Jelszo
            // 
            this.textBox_Jelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_Jelszo.Location = new System.Drawing.Point(205, 148);
            this.textBox_Jelszo.Name = "textBox_Jelszo";
            this.textBox_Jelszo.Size = new System.Drawing.Size(247, 34);
            this.textBox_Jelszo.TabIndex = 2;
            // 
            // textBox_Felhasznalonev
            // 
            this.textBox_Felhasznalonev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_Felhasznalonev.Location = new System.Drawing.Point(205, 86);
            this.textBox_Felhasznalonev.Name = "textBox_Felhasznalonev";
            this.textBox_Felhasznalonev.Size = new System.Drawing.Size(247, 34);
            this.textBox_Felhasznalonev.TabIndex = 2;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 357);
            this.Controls.Add(this.textBox_Felhasznalonev);
            this.Controls.Add(this.textBox_Jelszo);
            this.Controls.Add(this.button_Bejelentkezes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Bejelentkezes;
        private System.Windows.Forms.TextBox textBox_Jelszo;
        private System.Windows.Forms.TextBox textBox_Felhasznalonev;
    }
}

