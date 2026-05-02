using Class_Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var categories = _categoryRepo.GetAll();
            foreach (var category in categories)
            {
                i++;
                dgvCategory.Rows.Add(i, category.catid, category.catname);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModuleForm categoryModuleForm = new CategoryModuleForm();
            categoryModuleForm.btnUpdate.Enabled = false;
            categoryModuleForm.btnSave.Enabled = true;
            categoryModuleForm.ShowDialog();
            LoadCategories();
        }
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvCategory.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                CategoryModuleForm categoryModule = new CategoryModuleForm();
                categoryModule.lblCatId.Text = dgvCategory.Rows[e.RowIndex].Cells["ColCatId"].Value.ToString();
                categoryModule.txtCatName.Text = dgvCategory.Rows[e.RowIndex].Cells["ColCatName"].Value.ToString();
                categoryModule.btnSave.Enabled = false;
                categoryModule.btnUpdate.Enabled = true;
                categoryModule.ShowDialog();
                LoadCategories();
            }
            else if (colName == "Delete")
            {
                int catId = int.Parse(dgvCategory.Rows[e.RowIndex].Cells["ColCatId"].Value.ToString()!);
                if (MessageBox.Show($"Are you sure you want to delete this category?",
                    "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _categoryRepo.Delete(catId);
                    _categoryRepo.Save();
                    MessageBox.Show("Category deleted successfully!");
                }
            }

            LoadCategories();
        }

      
    }
}
