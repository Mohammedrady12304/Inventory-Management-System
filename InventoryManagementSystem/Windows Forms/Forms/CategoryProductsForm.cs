using InventoryManagementSystem.ClassLibrary.Models;

namespace Windows_Forms.Forms
{
    public partial class CategoryProductsForm : Form
    {
        private readonly Category _category;
        private DataGridView dgv = null!;

        public CategoryProductsForm(Category category)
        {
            _category = category;
            InitForm();
            LoadProducts();
        }

        private void InitForm()
        {
            this.Text = $"Products in: {_category.catname}";
            this.Font = new Font("Century Gothic", 9F);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(750, 450);
            this.BackColor = Color.White;

            var headerPanel = new Panel { BackColor = Color.DodgerBlue, Dock = DockStyle.Top, Height = 49 };
            var lblTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(5, 14),
                Text = $"Products in: {_category.catname}  ({_category.Products.Count} items)"
            };
            var btnClose = new Button
            {
                Text = "X",
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Size = new Size(25, 25),
                Location = new Point(this.Width - 40, 12),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Dispose();
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(btnClose);

            var cellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                Font = new Font("Century Gothic", 9F)
            };

            dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                ColumnHeadersDefaultCellStyle = cellStyle,
                ColumnHeadersHeight = 30,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                EnableHeadersVisualStyles = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgv.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "No",    HeaderText = "No"          },
                new DataGridViewTextBoxColumn { Name = "ID",    HeaderText = "Product ID"  },
                new DataGridViewTextBoxColumn { Name = "Name",  HeaderText = "Name"        },
                new DataGridViewTextBoxColumn { Name = "Qty",   HeaderText = "Qty"         },
                new DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Price"       },
                new DataGridViewTextBoxColumn { Name = "Desc",  HeaderText = "Description" }
            });

            this.Controls.Add(dgv);
            this.Controls.Add(headerPanel);
        }

        private void LoadProducts()
        {
            dgv.Rows.Clear();
            int i = 1;
            foreach (var p in _category.Products)
                dgv.Rows.Add(i++, p.pid, p.pname, p.pqty, p.pprice, p.pdescription);
        }
    }
}