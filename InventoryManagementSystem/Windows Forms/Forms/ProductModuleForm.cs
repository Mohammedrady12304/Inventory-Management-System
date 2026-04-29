
using Class_Library.Context;
using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;

namespace Windows_Forms.Forms
{
    public partial class ProductModuleForm : Form
    {
        private InventoryManagementContext db = new InventoryManagementContext();

        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            comboCat.Items.Clear();

            var categories = db.Categories
                .Select(c => c.catname)
                .ToList();

            foreach (var cat in categories)
            {
                comboCat.Items.Add(cat);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?",
                    "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var newProduct = new Product
                    {
                        pname = txtPName.Text,
                        pqty = Convert.ToInt16(txtPQty.Text),
                        pprice = (int)Convert.ToDecimal(txtPPrice.Text),
                        pdescription = txtPDes.Text,
                        pcategory = comboCat.Text
                    };

                    db.Products.Add(newProduct);
                    db.SaveChanges();

                    MessageBox.Show("Product has been successfully saved.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtPName.Clear();
            txtPQty.Clear();
            txtPPrice.Clear();
            txtPDes.Clear();
            comboCat.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?",
                    "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int pid = int.Parse(lblPid.Text);
                    var product = db.Products.Find(pid);

                    if (product != null)
                    {
                        product.pname = txtPName.Text;
                        product.pqty = Convert.ToInt16(txtPQty.Text);
                        product.pprice =(int) Convert.ToDecimal(txtPPrice.Text);
                        product.pdescription = txtPDes.Text;
                        product.pcategory = comboCat.Text;

                        db.SaveChanges();
                        MessageBox.Show("Product has been successfully updated!");
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
