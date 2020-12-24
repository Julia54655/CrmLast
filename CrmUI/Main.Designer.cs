
namespace CrmUI
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecialistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSpecialistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServiceToolStripMenuItem,
            this.SpecialistToolStripMenuItem,
            this.ClientToolStripMenuItem,
            this.CheckToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.menuToolStripMenuItem.Text = "Меню";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // ServiceToolStripMenuItem
            // 
            this.ServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddServiceToolStripMenuItem});
            this.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem";
            this.ServiceToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.ServiceToolStripMenuItem.Text = "Услуга";
            this.ServiceToolStripMenuItem.Click += new System.EventHandler(this.ServiceToolStripMenuItem_Click);
            // 
            // AddServiceToolStripMenuItem
            // 
            this.AddServiceToolStripMenuItem.Name = "AddServiceToolStripMenuItem";
            this.AddServiceToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.AddServiceToolStripMenuItem.Text = "Добавить";
            this.AddServiceToolStripMenuItem.Click += new System.EventHandler(this.AddServiceToolStripMenuItem_Click);
            // 
            // SpecialistToolStripMenuItem
            // 
            this.SpecialistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSpecialistToolStripMenuItem1});
            this.SpecialistToolStripMenuItem.Name = "SpecialistToolStripMenuItem";
            this.SpecialistToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.SpecialistToolStripMenuItem.Text = "Специалист";
            this.SpecialistToolStripMenuItem.Click += new System.EventHandler(this.SpecialistToolStripMenuItem_Click_1);
            // 
            // AddSpecialistToolStripMenuItem1
            // 
            this.AddSpecialistToolStripMenuItem1.Name = "AddSpecialistToolStripMenuItem1";
            this.AddSpecialistToolStripMenuItem1.Size = new System.Drawing.Size(192, 34);
            this.AddSpecialistToolStripMenuItem1.Text = "Добавить";
            this.AddSpecialistToolStripMenuItem1.Click += new System.EventHandler(this.AddSpecialistToolStripMenuItem1_Click);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClientToolStripMenuItem2});
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.ClientToolStripMenuItem.Text = "Клиент";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click_1);
            // 
            // AddClientToolStripMenuItem2
            // 
            this.AddClientToolStripMenuItem2.Name = "AddClientToolStripMenuItem2";
            this.AddClientToolStripMenuItem2.Size = new System.Drawing.Size(192, 34);
            this.AddClientToolStripMenuItem2.Text = "Добавить";
            this.AddClientToolStripMenuItem2.Click += new System.EventHandler(this.AddClientToolStripMenuItem2_Click);
            // 
            // CheckToolStripMenuItem
            // 
            this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
            this.CheckToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.CheckToolStripMenuItem.Text = "Чек";
            this.CheckToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpecialistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSpecialistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddClientToolStripMenuItem2;
    }
}

