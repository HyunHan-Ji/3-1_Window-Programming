using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdControlWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(courseTree.SelectedNode.Text);
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            if (courseTree.SelectedNode.Nodes.Count == 0)
            {
                courseTree.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("자식노드가 있으므로 삭제 불가", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            courseTree.SelectedNode.Nodes.Add(textBox1.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TreeNode SearchedNode = SearchNode(courseTree.Nodes, textBox1.Text);
            if (SearchedNode != null)
            {
                courseTree.SelectedNode = SearchedNode;
            }
            else
            {
                MessageBox.Show("검색된 노드가 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TreeNode SearchNode(TreeNodeCollection treeNode, string str)
        {
            foreach (TreeNode node in treeNode)
            {
                if (node.Text == str)
                    return node;

                TreeNode findNode = SearchNode(node.Nodes, str);

                if (findNode != null)
                    return findNode;
            }
            return null;
        }


        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }
}
