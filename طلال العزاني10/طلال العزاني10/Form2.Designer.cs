namespace واجب_10_برمجة_مرئية
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.إدارةبياناتالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إغلاقالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إدارةبياناتالطلابToolStripMenuItem,
            this.ملفToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // إدارةبياناتالطلابToolStripMenuItem
            // 
            this.إدارةبياناتالطلابToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةطالبToolStripMenuItem,
            this.عرضالطلابToolStripMenuItem});
            this.إدارةبياناتالطلابToolStripMenuItem.Name = "إدارةبياناتالطلابToolStripMenuItem";
            this.إدارةبياناتالطلابToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.إدارةبياناتالطلابToolStripMenuItem.Text = "إدارة بيانات الطلاب";
            // 
            // إضافةطالبToolStripMenuItem
            // 
            this.إضافةطالبToolStripMenuItem.Name = "إضافةطالبToolStripMenuItem";
            this.إضافةطالبToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.إضافةطالبToolStripMenuItem.Text = "إضافة طالب";
            this.إضافةطالبToolStripMenuItem.Click += new System.EventHandler(this.إضافةطالبToolStripMenuItem_Click);
            // 
            // عرضالطلابToolStripMenuItem
            // 
            this.عرضالطلابToolStripMenuItem.Name = "عرضالطلابToolStripMenuItem";
            this.عرضالطلابToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.عرضالطلابToolStripMenuItem.Text = "عرض الطلاب";
            this.عرضالطلابToolStripMenuItem.Click += new System.EventHandler(this.عرضالطلابToolStripMenuItem_Click);
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إغلاقToolStripMenuItem,
            this.إغلاقالكلToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // إغلاقToolStripMenuItem
            // 
            this.إغلاقToolStripMenuItem.Name = "إغلاقToolStripMenuItem";
            this.إغلاقToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.إغلاقToolStripMenuItem.Text = "إغلاق ";
            this.إغلاقToolStripMenuItem.Click += new System.EventHandler(this.إغلاقToolStripMenuItem_Click);
            // 
            // إغلاقالكلToolStripMenuItem
            // 
            this.إغلاقالكلToolStripMenuItem.Name = "إغلاقالكلToolStripMenuItem";
            this.إغلاقالكلToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.إغلاقالكلToolStripMenuItem.Text = "إغلاق الكل";
            this.إغلاقالكلToolStripMenuItem.Click += new System.EventHandler(this.إغلاقالكلToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إدارةبياناتالطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إغلاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إغلاقالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}