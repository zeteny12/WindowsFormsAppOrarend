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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.műveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beszúrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Orarend = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            // listBox_Orarend
            // 
            this.listBox_Orarend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBox_Orarend.FormattingEnabled = true;
            this.listBox_Orarend.ItemHeight = 29;
            this.listBox_Orarend.Location = new System.Drawing.Point(0, 32);
            this.listBox_Orarend.Name = "listBox_Orarend";
            this.listBox_Orarend.Size = new System.Drawing.Size(293, 410);
            this.listBox_Orarend.TabIndex = 1;
            // 
            // FormsOrarend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Orarend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormsOrarend";
            this.Text = "Órarend";
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
        private System.Windows.Forms.ListBox listBox_Orarend;
    }
}