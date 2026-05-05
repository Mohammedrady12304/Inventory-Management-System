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
                var categories = context.Categories.ToDictionary(c => c.catname, c => c.catid);
                context.Products.AddRange(
                    new Product { pname = "Milk 1L",    pqty = 50,  pprice = 35,  pdescription = "Fresh milk 1 liter",     catid = 1 },
                    new Product { pname = "Bread",      pqty = 100, pprice = 10,  pdescription = "Freshly baked bread",    catid = 2 },
                    new Product { pname = "Coca Cola",  pqty = 20,  pprice = 15,  pdescription = "Carbonated soft drink",  catid = 1 },
                    new Product { pname = "Apples KG",  pqty = 30,  pprice = 60,  pdescription = "Fresh apples per kg",   catid = 4 },
                    new Product { pname = "Rice 1KG",   pqty = 4,   pprice = 30,  pdescription = "White rice 1 kilogram", catid = 7 },
                    new Product { pname = "Chicken KG", pqty = 15,  pprice = 150, pdescription = "Fresh chicken per kg",  catid = 6 },
                    new Product { pname = "Soap",       pqty = 40,  pprice = 12,  pdescription = "Hand soap bar",         catid = 10 },
                    new Product { pname = "Chips",      pqty = 2,   pprice = 10,  pdescription = "Potato chips snack",    catid = 8 },
                    new Product { pname = "Dish Soap",  pqty = 12,  pprice = 45,  pdescription = "Dishwashing liquid",    catid = 9 },
                    new Product { pname = "Tuna Can",   pqty = 3,   pprice = 55,  pdescription = "Canned tuna in oil",    catid = 7 }
                );
                context.SaveChanges();
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer { cname = "Ahmed Ali",    cphone = "01011111111" },
                    new Customer { cname = "Sara Mohamed", cphone = "01222222222" },
                    new Customer { cname = "Mona Hassan",  cphone = "01133333333" },
                    new Customer { cname = "Omar Zaki",    cphone = "01544444444" },
                    new Customer { cname = "Laila Ezz",    cphone = "01055555555" },
                    new Customer { cname = "Hany Saad",    cphone = "01266666666" },
                    new Customer { cname = "Nour Mahmoud", cphone = "01177777777" },
                    new Customer { cname = "Karim Fawzy",  cphone = "01588888888" },
                    new Customer { cname = "Eman Khalil",  cphone = "01099999999" },
                    new Customer { cname = "Tarek Adel",   cphone = "01200000000" }
                );
                context.SaveChanges();
            }

            if (!context.Orders.Any())
            {
                var products  = context.Products.ToList();
                var customers = context.Customers.ToList();
                if (products.Any() && customers.Any())
                {
                    context.Orders.AddRange(
                        new Order { odate = System.DateTime.Now.AddDays(-5), pid = products[0].pid, cid = customers[0].cid, qty = 2, price = products[0].pprice, total = products[0].pprice * 2 },
                        new Order { odate = System.DateTime.Now.AddDays(-3), pid = products[1].pid, cid = customers[1].cid, qty = 5, price = products[1].pprice, total = products[1].pprice * 5 },
                        new Order { odate = System.DateTime.Now.AddDays(-2), pid = products[2].pid, cid = customers[2].cid, qty = 3, price = products[2].pprice, total = products[2].pprice * 3 },
                        new Order { odate = System.DateTime.Now.AddDays(-1), pid = products[4].pid, cid = customers[3].cid, qty = 1, price = products[4].pprice, total = products[4].pprice * 1 },
                        new Order { odate = System.DateTime.Now,             pid = products[6].pid, cid = customers[4].cid, qty = 4, price = products[6].pprice, total = products[6].pprice * 4 }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}