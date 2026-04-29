using Class_Library.Context;
using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;


namespace Windows_Forms.Forms
{
    public partial class CategoryModuleForm : Form
    {
        // ✅ بدل SqlConnection استخدمنا InventoryManagementContext
        private InventoryManagementContext db = new InventoryManagementContext();

        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?",
                    "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // ✅ EF Add بدل INSERT INTO SQL string
                    var newCategory = new Category
                    {
                        catname = txtCatName.Text
                    };

                    db.Categories.Add(newCategory);
                    db.SaveChanges();

                    MessageBox.Show("Category has been successfully saved.");
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
            txtCatName.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled   = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Category?",
                    "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // ✅ EF Find + تعديل بدل UPDATE SQL string
                    int catid = int.Parse(lblCatId.Text);
                    var category = db.Categories.Find(catid);

                    if (category != null)
                    {
                        category.catname = txtCatName.Text;
                        db.SaveChanges();
                        MessageBox.Show("Category has been successfully updated!");
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
