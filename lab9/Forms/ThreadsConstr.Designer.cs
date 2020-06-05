namespace XMLGUI
{
    partial class ThreadConstr
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
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableView = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.setTimeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.filterToolStripMenuItem.Text = "Set number of threads";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // setTimeToolStripMenuItem
            // 
            this.setTimeToolStripMenuItem.Name = "setTimeToolStripMenuItem";
            this.setTimeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.setTimeToolStripMenuItem.Text = "Set time ";
            this.setTimeToolStripMenuItem.Click += new System.EventHandler(this.setTimeToolStripMenuItem_Click);
            // 
            // tableView
            // 
            this.tableView.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tableView.BackColor = System.Drawing.Color.White;
            this.tableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableView.Location = new System.Drawing.Point(9, 25);
            this.tableView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableView.Multiline = true;
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tableView.Size = new System.Drawing.Size(614, 315);
            this.tableView.TabIndex = 1;
            this.tableView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ThreadConstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 350);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ThreadConstr";
            this.Text = "Chat";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.TextBox tableView;
        private System.Windows.Forms.ToolStripMenuItem setTimeToolStripMenuItem;
    }
}

