using System;
using System.Collections.Generic;
using System.IO;

namespace App
{ 

    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            string userPath = "UserData.txt";
            string entityPath = "EntityData.txt";
            int option;

            do
            {
                Console.Clear();
                option = Menu();
                Console.Clear();

                if (option == 1)
                {
                    Console.WriteLine("Sign In");
                    Console.WriteLine("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string password = Console.ReadLine();
                    User signedInUser = User.SignIn(username, password, users);
                    if (signedInUser != null)
                    {
                        if (signedInUser.Role == "admin")
                        {
                            AdminMenu(entityPath);
                        }
                        else
                        {
                            UserMenu();
                        }
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("Sign Up");
                    Console.WriteLine("Enter New Username: ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter New Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("Enter Your Role: ");
                    string role = Console.ReadLine();
                    User.SignUp(userPath, username, password, role, users);
                }
            } while (option != 0);
        }

        static int Menu()
        {
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter Option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        static void AdminMenu(string entityPath)
        {
            ProductManager productManager = new ProductManager(entityPath);
            int option;

            do
            {
                Console.WriteLine("Admin Menu");
                Console.WriteLine("1. Create Product");
                Console.WriteLine("2. Read Products");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("0. Exit Admin Menu");
                Console.WriteLine("Enter Option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Product ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price: ");
                        double price = double.Parse(Console.ReadLine());
                        productManager.CreateProduct(id, name, price);
                        productManager.SaveProducts(entityPath);
                        break;
                    case 2:
                        Console.WriteLine("Products:");
                        productManager.ReadProducts();
                        break;
                    case 3:
                        Console.WriteLine("Enter Product ID to Update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter New Name: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Enter New Price: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        productManager.UpdateProduct(updateId, newName, newPrice);
                        productManager.SaveProducts(entityPath);
                        break;
                    case 4:
                        Console.WriteLine("Enter Product ID to Delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        productManager.DeleteProduct(deleteId);
                        productManager.SaveProducts(entityPath);
                        break;
                    case 0:
                        Console.WriteLine("Exiting Admin Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (option != 0);
        }

        static void UserMenu()
        {
            Console.WriteLine("User Menu");
            Console.WriteLine("Under construction...");
            Console.ReadKey();
        }
    }
}
