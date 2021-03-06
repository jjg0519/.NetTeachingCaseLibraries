﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAccountBook
{
    public partial class frmFinanceType : Form
    {
        public frmFinanceType()
        {
            InitializeComponent();
        }
        BllHandler _bllHandler;
        private void frmFinanceType_Load(object sender, EventArgs e)
        {
            _bllHandler = new BllHandler();
            var list = _bllHandler.GetFinanceTypes();

            //递归加载树形菜单
            AddNode(0, trvFinanceType.Nodes, list);
        }
        /// <summary>
        /// 递归加载树形菜单
        /// </summary>
        /// <param name="pid">父ID</param>
        /// <param name="list">菜单集合</param>
        void AddNode(int pid, TreeNodeCollection nodes, List<dynamic> list)
        {
            foreach (var item in list.Where(w => w.pid == pid))
            {
                TreeNode node = nodes.Add(item.id.ToString(), item.typename);
                AddNode(item.id, node.Nodes, list);
            }
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            //类型名称不能为空
            if (txbFinanceTypeName.Text.Trim() != "")
            {
                //获取选中的节点的名称作为父id
                var pid = Convert.ToInt32(trvFinanceType.SelectedNode.Name);
                //向数据添加在型信息
                var id = _bllHandler.AddFinanceType(txbFinanceTypeName.Text, pid);
                //树形菜单中添加选中节点子节点
                trvFinanceType.SelectedNode.Nodes.Add(id.ToString(), txbFinanceTypeName.Text);
            }
        }

        private void 删除类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取选中的节点的名称作为id
            var id = Convert.ToInt32(trvFinanceType.SelectedNode.Name);
            if( _bllHandler.DeleteFinanceType(id))
            {
                trvFinanceType.SelectedNode.Remove();
            }
        }
    }
}
