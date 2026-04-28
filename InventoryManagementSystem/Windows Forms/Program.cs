using Class_Library.Context;
using Microsoft.EntityFrameworkCore;
using Windows_Forms.Forms;

namespace Windows_Forms
{
    internal static class Program
    {
        public static InventoryManagementContext DbContext { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var options = new DbContextOptionsBuilder<InventoryManagementContext>()
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=dbIMS;Integrated Security=True;TrustServerCertificate=True;")
                .Options;

            DbContext = new InventoryManagementContext(options);
            DbContext.Database.EnsureCreated();

            Application.Run(new CustomerForm());
            //Application.Run(new LoginForm());
            //Application.Run(new UserForm());
        }
    }
}