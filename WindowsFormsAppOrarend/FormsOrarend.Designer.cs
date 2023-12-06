namespace WindowsFormsAppOrarend
{
    partial class FormsOrarend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsOrarend));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.műveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beszúrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_OrarendNapok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_BelepettTanar = new System.Windows.Forms.TextBox();
            this.listBox_Orarend = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.műveletekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // műveletekToolStripMenuItem
            // 
            this.műveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beszúrásToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.műveletekToolStripMenuItem.Name = "műveletekToolStripMenuItem";
            this.műveletekToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.műveletekToolStripMenuItem.Text = "Műveletek";
            // 
            // beszúrásToolStripMenuItem
            // 
            this.beszúrásToolStripMenuItem.Name = "beszúrásToolStripMenuItem";
            this.beszúrásToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.beszúrásToolStripMenuItem.Text = "Beszúrás";
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // listBox_OrarendNapok
            // 
            this.listBox_OrarendNapok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox_OrarendNapok.FormattingEnabled = true;
            this.listBox_OrarendNapok.ItemHeight = 29;
            this.listBox_OrarendNapok.Location = new System.Drawing.Point(12, 32);
            this.listBox_OrarendNapok.Name = "listBox_OrarendNapok";
            this.listBox_OrarendNapok.Size = new System.Drawing.Size(281, 236);
            this.listBox_OrarendNapok.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(299, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bejelentkezett:";
            // 
            // textBox_BelepettTanar
            // 
            this.textBox_BelepettTanar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_BelepettTanar.Location = new System.Drawing.Point(476, 40);
            this.textBox_BelepettTanar.Name = "textBox_BelepettTanar";
            this.textBox_BelepettTanar.Size = new System.Drawing.Size(265, 34);
            this.textBox_BelepettTanar.TabIndex = 3;
            // 
            // listBox_Orarend
            // 
            this.listBox_Orarend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox_Orarend.FormattingEnabled = true;
            this.listBox_Orarend.ItemHeight = 29;
            this.listBox_Orarend.Location = new System.Drawing.Point(12, 338);
            this.listBox_Orarend.Name = "listBox_Orarend";
            this.listBox_Orarend.Size = new System.Drawing.Size(729, 178);
            this.listBox_Orarend.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Órarend megjelenítése";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormsOrarend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(753, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_Orarend);
            this.Controls.Add(this.textBox_BelepettTanar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_OrarendNapok);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormsOrarend";
            this.Text = "Órarend";
            this.Load += new System.EventHandler(this.FormsOrarend_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem műveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beszúrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_OrarendNapok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BelepettTanar;
        private System.Windows.Forms.ListBox listBox_Orarend;
        private System.Windows.Forms.Button button1;
    }
}