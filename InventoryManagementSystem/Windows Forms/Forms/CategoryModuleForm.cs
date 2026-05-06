using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;

namespace Windows_Forms.Forms
{
    public partial class CategoryModuleForm : Form
    {
        private readonly CategoryRepository _categoryRepo;

        public CategoryModuleForm()
        {
            InitializeComponent();
            _categoryRepo = new CategoryRepository(Program.DbContext);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e) => this.Dispose();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCatName.Text))
                {
                    MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!txtCatName.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Category Name must contain letters only!");
                    return;
                }
                if (MessageBox.Show("Save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _categoryRepo.Add(new Category { catname = txtCatName.Text.Trim() });
                    _categoryRepo.Save();
                    MessageBox.Show("Category saved successfully.");
                    Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void Clear() => txtCatName.Clear();

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear(); btnSave.Enabled = true; btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCatName.Text))
                {
                    MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!txtCatName.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Category Name must contain letters only!");
                    return;
                }
                if (MessageBox.Show("Update this category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int catid = int.Parse(lblCatId.Text);
                    var category = _categoryRepo.GetById(catid);
                    if (category != null)
                    {
                        category.catname = txtCatName.Text.Trim();
                        _categoryRepo.Update(category);
                        _categoryRepo.Save();
                        MessageBox.Show("Category updated successfully!");
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}