using BusinessLayer;
using Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TicaretOtomasyonOrnegi
{
    public partial class frmProducts : Form
    {
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=TicaretUygulamasiDB;Trusted_Connection=true";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter da;

        private Control _lastActiveTextControl = null;
        private ProductManager _productManager;
        private CategoryManager cm;

        public frmProducts()
        {
            InitializeComponent();
            _productManager = new ProductManager();
            cm = new CategoryManager();
            connection = new SqlConnection(connectionString);
            //command = connection.CreateCommand();
            //da = new SqlDataAdapter(command);

            splitContainer1.Cursor = Cursors.Default;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is TextBox)
                {
                    control.GotFocus += Textbox_GotFocus;
                }
            }
        }

        private void Textbox_GotFocus(object sender, EventArgs e)
        {
            _lastActiveTextControl = sender as Control;
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (_lastActiveTextControl != null)
            {
                ((TextBox)_lastActiveTextControl).Cut();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (_lastActiveTextControl != null)
            {
                ((TextBox)_lastActiveTextControl).Copy();
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (_lastActiveTextControl != null)
            {
                ((TextBox)_lastActiveTextControl).Paste();
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = txtName.Text?.Trim(),
                Description = txtDesc.Text?.Trim(),
                IsSale = chkIsSale.Checked,
                Stock = (int)nudStock.Value,
                StockUnit = txtStockUnit.Text?.Trim(),
                UnitPrice = nudUnitPrice.Value,
                CategoryId = 2, // todo 
                SupplierId = 1  // todo
            };

            try
            {
                bool result = _productManager.Create(product);

                if (result)
                {
                    DataGridViewDoldur();

                    MessageBox.Show("Ürün eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürün eklenemedi. Beklenmedik bir hata oluştu.", "Hata var!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata var!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Product product;
        private void btnProductSave_Click(object sender, EventArgs e)
        {

            ProductManager productManager = new ProductManager();

            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            product = new Product()
            {

                Name = txtName.Text.Trim(),
                Description = txtDesc.Text?.Trim(),
                IsSale = chkIsSale.Checked,
                Stock = (int)nudStock.Value,
                StockUnit = txtStockUnit.Text?.Trim(),
                UnitPrice = nudUnitPrice.Value,
                CategoryId = 2, // todo 
                SupplierId = 1  // todo

            };
            productManager.Update(product, id);

            DataGridViewDoldur();


        }
        #region BURAKKKKKK
        //private DataTable ListOfProduct(string query)
        //{
        //    DataTable dt = new DataTable();
        //    command.CommandText = query;
        //    //command.Parameters.Clear();
        //    da.Fill(dt);

        //    return dt;
        //} 
        #endregion




        private void dgvProducts_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            #region Gizleme denemesi
            //foreach (DataGridView item in dgvProducts.Rows)
            //{

            //    if (dgvProducts.SelectedRows.Equals(item.Rows))
            //    {
            //        item.Visible = true;
            //    }
            //    else
            //    {
            //        item.Visible = false;
            //    }
            //} 
            #endregion

            txtName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            nudUnitPrice.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            nudStock.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            txtStockUnit.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            cmbSuppliers.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            txtDesc.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {


        }

        private void DataGridViewDoldur()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Products";
            command = connection.CreateCommand();
            command.CommandText = query;
            da = new SqlDataAdapter(command);
            da.Fill(dt);

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = dt;
        }

        private void btnProductDel_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();

            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            product = new Product()
            {

                Name = txtName.Text.Trim(),
                Description = txtDesc.Text?.Trim(),
                IsSale = chkIsSale.Checked,
                Stock = (int)nudStock.Value,
                StockUnit = txtStockUnit.Text?.Trim(),
                UnitPrice = nudUnitPrice.Value,
                CategoryId = 2, // todo 
                SupplierId = 1  // todo

            };
            productManager.Delete(product, id);

            DataGridViewDoldur();
        }

        TreeNode tParent;
        private void FillTreeView()
        {

            trvCategory.Nodes.Clear();

            foreach (Category item in cm.GetCategories())
            {
                if (item.ParentId == null)
                {
                    tParent = new TreeNode(item.Name);
                    tParent.Tag = item;

                    foreach (Category itemChild in cm.GetCategories())
                    {
                        if (itemChild.ParentId == item.Id)
                        {
                            TreeNode tChild = new TreeNode(itemChild.Name);
                            tChild.Tag = itemChild;
                            tParent.Nodes.Add(tChild);
                        }
                    }

                    trvCategory.Nodes.Add(tParent);
                }
            }

            trvCategory.ExpandAll();

            //trvCategory.Nodes.Clear();

            //foreach (Category item in cm.GetCategories())
            //{

            //    if (item.ParentId == null)
            //    {
            //        TreeNode parent = new TreeNode(item.Name);
            //        parent.Tag = item;

            //        foreach (Category cat in cm.GetCategories())
            //        {
            //            if (cat.ParentId == item.Id)
            //            {
            //                TreeNode child = new TreeNode(cat.Name);
            //                child.Tag = cat;
            //                parent.Nodes.Add(child);
            //            }
            //        }

            //        trvCategory.Nodes.Add(parent);
            //    }
            //}

            //trvCategory.ExpandAll();

        }

        private void frmProducts_Load_1(object sender, EventArgs e)
        {
            DataGridViewDoldur();
            FillTreeView();
        }
    }
}
