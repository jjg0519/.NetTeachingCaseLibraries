﻿namespace TestManage
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.老师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考试设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.班级考试设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.试卷管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.考试设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级管理ToolStripMenuItem,
            this.老师管理ToolStripMenuItem,
            this.科目管理ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 班级管理ToolStripMenuItem
            // 
            this.班级管理ToolStripMenuItem.Name = "班级管理ToolStripMenuItem";
            this.班级管理ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.班级管理ToolStripMenuItem.Text = "班级管理";
            this.班级管理ToolStripMenuItem.Click += new System.EventHandler(this.班级管理ToolStripMenuItem_Click);
            // 
            // 老师管理ToolStripMenuItem
            // 
            this.老师管理ToolStripMenuItem.Name = "老师管理ToolStripMenuItem";
            this.老师管理ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.老师管理ToolStripMenuItem.Text = "老师管理";
            this.老师管理ToolStripMenuItem.Click += new System.EventHandler(this.老师管理ToolStripMenuItem_Click);
            // 
            // 科目管理ToolStripMenuItem
            // 
            this.科目管理ToolStripMenuItem.Name = "科目管理ToolStripMenuItem";
            this.科目管理ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.科目管理ToolStripMenuItem.Text = "科目管理";
            this.科目管理ToolStripMenuItem.Click += new System.EventHandler(this.科目管理ToolStripMenuItem_Click);
            // 
            // 考试设置ToolStripMenuItem
            // 
            this.考试设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级考试设置ToolStripMenuItem,
            this.试卷管理ToolStripMenuItem});
            this.考试设置ToolStripMenuItem.Name = "考试设置ToolStripMenuItem";
            this.考试设置ToolStripMenuItem.Size = new System.Drawing.Size(122, 38);
            this.考试设置ToolStripMenuItem.Text = "考试设置";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 846);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1076, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // 班级考试设置ToolStripMenuItem
            // 
            this.班级考试设置ToolStripMenuItem.Name = "班级考试设置ToolStripMenuItem";
            this.班级考试设置ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.班级考试设置ToolStripMenuItem.Text = "班级考试设置";
            this.班级考试设置ToolStripMenuItem.Click += new System.EventHandler(this.班级考试设置ToolStripMenuItem_Click);
            // 
            // 试卷管理ToolStripMenuItem
            // 
            this.试卷管理ToolStripMenuItem.Name = "试卷管理ToolStripMenuItem";
            this.试卷管理ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.试卷管理ToolStripMenuItem.Text = "试卷管理";
            this.试卷管理ToolStripMenuItem.Click += new System.EventHandler(this.试卷管理ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 868);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 老师管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考试设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级考试设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 试卷管理ToolStripMenuItem;
    }
}

