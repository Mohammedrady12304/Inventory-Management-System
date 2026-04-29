using Class_Library.Context;
using Class_Library.Services;
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
                .UseSqlServer(@"Server=.;Database=InventoryManagementSystem;Integrated Security=True;TrustServerCertificate=True;")
                .Options;

            DbContext = new InventoryManagementContext(options);

            //DbInitializer.Seed(DbContext);

            Application.Run(new LoginForm());
        }
    }
}