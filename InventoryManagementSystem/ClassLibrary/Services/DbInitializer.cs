using InventoryManagementSystem.ClassLibrary.Models;
using Class_Library.Context;
using System.Linq;

namespace Class_Library.Services
{
    public static class DbInitializer
    {
        public static void Seed(InventoryManagementContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { catname = "Beverages" },
                    new Category { catname = "Bakery" },
                    new Category { catname = "Dairy" },
                    new Category { catname = "Fruits" },
                    new Category { catname = "Vegetables" },
                    new Category { catname = "Meat" },
                    new Category { catname = "Canned Goods" },
                    new Category { catname = "Snacks" },
                    new Category { catname = "Cleaning" },
                    new Category { catname = "Personal Care" }
                );
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { pname = "Milk 1L", pqty = 50, pprice = 35, pcategory = "Dairy" },
                    new Product { pname = "Bread", pqty = 100, pprice = 10, pcategory = "Bakery" },
                    new Product { pname = "Coca Cola", pqty = 20, pprice = 15, pcategory = "Beverages" },
                    new Product { pname = "Apples KG", pqty = 30, pprice = 60, pcategory = "Fruits" },
                    new Product { pname = "Rice 1KG", pqty = 4, pprice = 30, pcategory = "Canned Goods" }, 
                    new Product { pname = "Chicken KG", pqty = 15, pprice = 150, pcategory = "Meat" },
                    new Product { pname = "Soap", pqty = 40, pprice = 12, pcategory = "Personal Care" },
                    new Product { pname = "Chips", pqty = 2, pprice = 10, pcategory = "Snacks" }, 
                    new Product { pname = "Dish Soap", pqty = 12, pprice = 45, pcategory = "Cleaning" },
                    new Product { pname = "Tuna Can", pqty = 3, pprice = 55, pcategory = "Canned Goods" }
                );
                context.SaveChanges();
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer { cname = "Ahmed Ali", cphone = "01011111111" },
                    new Customer { cname = "Sara Mohamed", cphone = "01222222222" },
                    new Customer { cname = "Mona Hassan", cphone = "01133333333" },
                    new Customer { cname = "Omar Zaki", cphone = "01544444444" },
                    new Customer { cname = "Laila Ezz", cphone = "01055555555" },
                    new Customer { cname = "Hany Saad", cphone = "01266666666" },
                    new Customer { cname = "Nour Mahmoud", cphone = "01177777777" },
                    new Customer { cname = "Karim Fawzy", cphone = "01588888888" },
                    new Customer { cname = "Eman Khalil", cphone = "01099999999" },
                    new Customer { cname = "Tarek Adel", cphone = "01200000000" }
                );
                context.SaveChanges();
            }
        }
    }
}