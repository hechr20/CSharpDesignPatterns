using Microsoft.EntityFrameworkCore;
using ORMSample.Contexts;
using ORMSample.Models;

using (var db = new DatabaseContext())
{

    var product = new Product() { Price = 100, Description = "Movie" };
    db.Products.Add(product);
    db.SaveChanges();

    foreach (var p in db.Products)
    {
        Console.WriteLine("{0} {1} {2}", p.ProductId, p.Description, p.Price);
    }

}

using (var db = new DatabaseContext())
{
    var product = db.Products.SingleOrDefault();

    if (product != null)
    {
        var item = new OrderItem
        {
            Quantity = 1,
            Product = product
        };
        db.OrderItems.Add(item);
        db.SaveChanges();

        Console.WriteLine("{0} {1} Product: {2}", item.OrderItemId, item.Quantity, item.Product.Description);
    }
}

// Create
using (var db = new DatabaseContext())
{
    var order = db.Orders.SingleOrDefault();
    var item = db.OrderItems.SingleOrDefault();
    item.OrderId = order.OrderId;
    db.SaveChanges();
}

// Update
using (var db = new DatabaseContext())
{
    var item = db.OrderItems.SingleOrDefault();
    item.Quantity++;
    db.SaveChanges();
}

// Delete
using (var db = new DatabaseContext())
{

    var item = db.OrderItems.Include(i => i.Product).SingleOrDefault();

    item.Product = null;
    db.SaveChanges();

    var product = db.Products.SingleOrDefault();
    db.Products.Remove(product);
    db.SaveChanges();
}