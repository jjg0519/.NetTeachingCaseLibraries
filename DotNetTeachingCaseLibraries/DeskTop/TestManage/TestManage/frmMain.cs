﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestManage
{
    public partial class frmMain : Form
    {
        frmClassSetting _frmClass;
        frmTest _frmTest;
        frmTeacherSetting _frmTeacher;
        frmSubjectSetting _frmSubject;
        public frmMain(frmClassSetting frmClass,frmTeacherSetting frmTeacher,frmSubjectSetting frmSubject,frmTest frmTest)
        {
            InitializeComponent();
            _frmClass = frmClass;
            _frmTeacher = frmTeacher;
            _frmTest = frmTest;
            _frmSubject = frmSubject;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void 班级管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmClass.ShowDialog();
        }

        private void 老师管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmTeacher.ShowDialog();
        }

        private void 科目管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmSubject.ShowDialog();
        }
    }
}
