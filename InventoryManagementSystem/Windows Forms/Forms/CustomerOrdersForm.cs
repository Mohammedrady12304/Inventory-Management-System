using InventoryManagementSystem.ClassLibrary.Models;

namespace Windows_Forms.Forms
{
    public partial class CustomerOrdersForm : Form
    {
        private readonly Customer _customer;
        private DataGridView dgv = null!;

        public CustomerOrdersForm(Customer customer)
        {
            _customer = customer;
            InitForm();
            LoadOrders();
        }

        private void InitForm()
        {
            this.Text = $"Orders for: {_customer.cname}";
            this.Font = new Font("Century Gothic", 9F);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(700, 450);
            this.BackColor = Color.White;

            var headerPanel = new Panel { BackColor = Color.DodgerBlue, Dock = DockStyle.Top, Height = 49 };
            var lblTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(5, 14),
                Text = $"Orders — {_customer.cname} | Phone: {_customer.cphone}"
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
                new DataGridViewTextBoxColumn { Name = "ColNo",    HeaderText = "No"         },
                new DataGridViewTextBoxColumn { Name = "ColOid",   HeaderText = "Order ID"   },
                new DataGridViewTextBoxColumn { Name = "ColDate",  HeaderText = "Date"       },
                new DataGridViewTextBoxColumn { Name = "ColProd",  HeaderText = "Product"    },
                new DataGridViewTextBoxColumn { Name = "ColQty",   HeaderText = "Qty"        },
                new DataGridViewTextBoxColumn { Name = "ColPrice", HeaderText = "Unit Price" },
                new DataGridViewTextBoxColumn { Name = "ColTotal", HeaderText = "Total"      }
            });

            this.Controls.Add(dgv);
            this.Controls.Add(headerPanel);
        }

        private void LoadOrders()
        {
            dgv.Rows.Clear();
            int i = 1;
            foreach (var order in _customer.Orders.OrderByDescending(o => o.odate))
                dgv.Rows.Add(i++, order.oid, order.odate.ToString("dd/MM/yyyy"),
                    order.Product?.pname ?? "N/A", order.qty, order.price, order.total);
        }
    }
}