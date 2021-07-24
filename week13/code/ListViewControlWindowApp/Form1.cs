using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewControlWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem();
            newItem.Text = txtNum.Text;

            ListViewItem.ListViewSubItem SubItemName = new ListViewItem.ListViewSubItem();
            SubItemName.Text = txtName.Text;
            newItem.SubItems.Add(SubItemName);

            ListViewItem.ListViewSubItem SubItemAddress = new ListViewItem.ListViewSubItem();
            SubItemAddress.Text = txtAddress.Text;
            newItem.SubItems.Add(SubItemAddress);

            ListViewItem.ListViewSubItem SubItemPhone = new ListViewItem.ListViewSubItem();
            SubItemPhone.Text = txtPhone.Text;
            newItem.SubItems.Add(SubItemPhone);

            ListViewItem.ListViewSubItem SubItemDept = new ListViewItem.ListViewSubItem();
            SubItemDept.Text = txtDept.Text;
            newItem.SubItems.Add(SubItemDept);

            listView1.Items.Add(newItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selItems = listView1.SelectedItems;
            foreach(ListViewItem item in selItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selItems = listView1.SelectedItems;
            foreach (ListViewItem item in selItems)
            {
                txtNum.Text = item.Text;
                txtName.Text = item.SubItems[1].Text;
                txtAddress.Text = item.SubItems[2].Text;
                txtPhone.Text = item.SubItems[3].Text;
                txtDept.Text = item.SubItems[4].Text;
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            string SelectedView = domainUpDown1.SelectedItem.ToString();

            if (SelectedView == "Detail")
            {
                listView1.View = View.Details;
            }else if (SelectedView == "LargeIcon")
            {
                listView1.View = View.LargeIcon;
            }else if (SelectedView == "SmallIcon")
            {
                listView1.View = View.SmallIcon;
            }else if (SelectedView == "List")
            {
                listView1.View = View.List;
            }
        }
    }
}
