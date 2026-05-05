using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;

namespace Windows_Forms.Forms
{
    public partial class ProductModuleForm : Form
    {
        private readonly ProductRepository _productRepo;
        private readonly CategoryRepository _categoryRepo;

        public ProductModuleForm()
        {
            InitializeComponent();
            _productRepo = new ProductRepository(Program.DbContext);
            _categoryRepo = new CategoryRepository(Program.DbContext);
            LoadCategory();
        }

        public void LoadCategory()
        {
            comboCat.DisplayMember = "catname";
            comboCat.ValueMember = "catid";
            comboCat.DataSource = _categoryRepo.GetAll().ToList();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e) => this.Dispose();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                {
                    return;

                }

                if (MessageBox.Show("Are you sure you want to save this product?",
                    "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var selectedCat = comboCat.SelectedItem as Category;

                    var newProduct = new Product
                    {
                        pname = txtPName.Text,
                        pqty = Convert.ToInt32(txtPQty.Text),
                        pprice = Convert.ToInt32(txtPPrice.Text),
                        pdescription = txtPDes.Text,
                        catid = selectedCat?.catid
                    };

                    _productRepo.Add(newProduct);
                    _productRepo.Save();

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
            txtPName.Clear(); txtPQty.Clear(); txtPPrice.Clear(); txtPDes.Clear();
            if (comboCat.Items.Count > 0) comboCat.SelectedIndex = 0;
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
                if (!ValidateInputs())
                {
                    return;
                }
                    

                if (MessageBox.Show("Are you sure you want to update this product?",
                    "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int pid = int.Parse(lblPid.Text);
                    var product = _productRepo.GetById(pid);
                    if (product != null)
                    {
                        var selectedCat = comboCat.SelectedItem as Category;
                        product.pname = txtPName.Text;
                        product.pqty = Convert.ToInt32(txtPQty.Text);
                        product.pprice = Convert.ToInt32(txtPPrice.Text);
                        product.pdescription = txtPDes.Text;
                        product.catid = selectedCat?.catid;
                        _productRepo.Update(product);
                        _productRepo.Save();
                        MessageBox.Show("Product has been successfully updated!");
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e) { }



        private bool ValidateInputs()
        {
           
            if (string.IsNullOrWhiteSpace(txtPName.Text))
            {
                MessageBox.Show("Product name is required.");
                return false;
            }

           

            if (txtPName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Product name cannot contain numbers.");
                return false;
            }

          
            if (!int.TryParse(txtPPrice.Text, out int price))
            {
                MessageBox.Show("Price must be a valid number.");
                return false;
            }

            if (price < 0)
            {
                MessageBox.Show("Price cannot be negative.");
                return false;
            }

           
            txtPPrice.Text = price.ToString();

            return true;
        }
    }
}