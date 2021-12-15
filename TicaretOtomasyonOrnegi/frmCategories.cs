using BusinessLayer;
using System;
using System.Windows.Forms;

namespace TicaretOtomasyonOrnegi
{
    public partial class frmCategories : Form
    {
        CategoryManager categoryManager;
        public frmCategories()
        {
            InitializeComponent();
            categoryManager = new CategoryManager();

        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            // FillTreeView();
            FillListBox();
        }

        private void FillListBox()
        {
            lbCategories.DataSource = null;
            lbCategories.DisplayMember = "Name";
            lbCategories.ValueMember = "Id";
            lbCategories.DataSource = categoryManager.GetCategories();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region TreeView Deneme
            //if (txtParent.Text != null)
            //{
            //    TreeNode ekle = new TreeNode();

            //    TreeNode child = new TreeNode(txtName.Text);

            //    TreeNode[] array = new TreeNode[] { child };

            //    ekle = new TreeNode(txtParent.Text, array);
            //    trvCategory.Nodes.Add(ekle);
            //}
            //else
            //{
            //    MessageBox.Show("Ana Kategori Girmediniz!.");
            //} 
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //trvCategory.Nodes[Convert.ToInt32(txtName.Text)].Nodes.Add(txtParent.Text, txtName.Text);
        }



        private void FillTreeView()
        {
            //treeView1.Nodes.Clear();

            //foreach (Category item in categoryManager.GetCategories())
            //{

            //    if (item.ParentId==null)
            //    {
            //        TreeNode parent = new TreeNode(item.Name);
            //        parent.Tag = item;

            //        foreach (Category cat in categoryManager.GetCategories())
            //        {
            //            if (cat.ParentId==item.Id)
            //            {
            //                TreeNode child = new TreeNode(cat.Name);
            //                child.Tag = cat;
            //                parent.Nodes.Add(child);
            //            }
            //        }

            //        treeView1.Nodes.Add(parent);
            //    }
            //}

            //treeView1.ExpandAll();

        }


    }
}
