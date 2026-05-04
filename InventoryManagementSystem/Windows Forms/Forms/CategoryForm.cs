using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;

namespace Windows_Forms.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryRepository _categoryRepo;

        public CategoryForm()
        {
            InitializeComponent();
            _categoryRepo = new CategoryRepository(Program.DbContext);
            LoadCategories();
        }

        public void LoadCategories()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            foreach (var category in _categoryRepo.GetAll())
            {
                i++;
                dgvCategory.Rows.Add(i, category.catid, category.catname);
                dgvCategory.Rows[dgvCategory.Rows.Count - 1].Tag = category;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new CategoryModuleForm();
            f.btnUpdate.Enabled = false; f.btnSave.Enabled = true;
            f.ShowDialog(); LoadCategories();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            var category = dgvCategory.Rows[e.RowIndex].Tag as Category;
            if (category == null) return;

            if (colName == "Edit")
            {
                var f = new CategoryModuleForm();
                f.lblCatId.Text = category.catid.ToString();
                f.txtCatName.Text = category.catname;
                f.btnSave.Enabled = false; f.btnUpdate.Enabled = true;
                f.ShowDialog(); LoadCategories();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show($"Delete '{category.catname}'? Products will be unlinked.",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _categoryRepo.Delete(category.catid);
                    _categoryRepo.Save();
                    MessageBox.Show("Category deleted!");
                    LoadCategories();
                }
            }
            else if (colName == "ViewProducts")
            {
                var fullCat = _categoryRepo.GetByIdWithProducts(category.catid);
                if (fullCat != null) new CategoryProductsForm(fullCat).ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            dgvCategory.Rows.Clear();
            int i = 0;
            foreach (var cat in _categoryRepo.GetAll()
                .Where(c => c.catname.ToLower().Contains(search) || c.catid.ToString().Contains(search)))
            {
                i++;
                dgvCategory.Rows.Add(i, cat.catid, cat.catname);
                dgvCategory.Rows[dgvCategory.Rows.Count - 1].Tag = cat;
            }
        }
    }
}