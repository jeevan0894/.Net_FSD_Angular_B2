using Microsoft.Extensions.Configuration;
using ProductApp.Data;

//using week6handson.day3.data;
using week6handson.day3.entities;

class Program
{
    static void Main()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        ProductDataAccess dataAccess = new ProductDataAccess(config);

        while (true)
        {
            Console.WriteLine("\nPRODUCT MANAGEMENT SYSTEM");
            Console.WriteLine("1. Insert Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");

            Console.Write("Choose option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:
                        Product p = new Product();

                        Console.Write("Product Name: ");
                        p.ProductName = Console.ReadLine();

                        Console.Write("Category: ");
                        p.Category = Console.ReadLine();

                        Console.Write("Price: ");
                        p.price = Convert.ToDouble(Console.ReadLine());

                        dataAccess.InsertProduct(p);

                        Console.WriteLine("Product Added Successfully!");
                        break;

                    case 2:
                        var products = dataAccess.GetAllProducts();

                        foreach (var item in products)
                        {
                            Console.WriteLine($"{item.ProductId} | {item.ProductName} | {item.Category} | {item.price}");
                        }
                        break;

                    case 3:
                        Product updateProduct = new Product();

                        Console.Write("Enter Product Id: ");
                        updateProduct.ProductId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("New Name: ");
                        updateProduct.ProductName = Console.ReadLine();

                        Console.Write("New Category: ");
                        updateProduct.Category = Console.ReadLine();

                        Console.Write("New Price: ");
                        updateProduct.price = Convert.ToDouble(Console.ReadLine());

                        dataAccess.UpdateProduct(updateProduct);

                        Console.WriteLine("Product Updated Successfully!");
                        break;

                    case 4:
                        Console.Write("Enter Product Id to delete: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        dataAccess.DeleteProduct(id);

                        Console.WriteLine("Product Deleted Successfully!");
                        break;

                    case 5:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}