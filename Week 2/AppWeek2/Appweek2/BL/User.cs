using System.Collections.Generic;
using System.IO;
using System;

namespace App
{
    internal class User
    {
        public string Username;
        public string Password;
        public string Role;

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public static User SignIn(string username, string password, List<User> users)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Console.WriteLine("Valid User");
                    return user;
                }
            }
            Console.WriteLine("Invalid User");
            return null;
        }

        public static void SignUp(string path, string username, string password, string role, List<User> users)
        {
            User newUser = new User(username, password, role);
            users.Add(newUser);
            SaveUserData(path, users);
        }

        private static void SaveUserData(string path, List<User> users)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var user in users)
                {
                    writer.WriteLine($"{user.Username},{user.Password},{user.Role}");
                }
            }
        }
    }

    internal class Product
    {
        public int Id;
        public string Name;
        public double Price;    

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price:C}";
        }
    }

    internal class ProductManager
    {
        private List<Product> products;

        public ProductManager(string filePath)
        {
            products = new List<Product>();
            LoadProducts(filePath);
        }

        private void LoadProducts(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        double price = double.Parse(parts[2]);
                        products.Add(new Product(id, name, price));
                    }
                }
            }
        }

        public void SaveProducts(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var product in products)
                {
                    writer.WriteLine($"{product.Id},{product.Name},{product.Price}");
                }
            }
        }

        public void CreateProduct(int id, string name, double price)
        {
            products.Add(new Product(id, name, price));
        }

        public void ReadProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void UpdateProduct(int id, string newName, double newPrice)
        {
            Product product = products.Find(p => p.Id == id);
            if (product != null)
            {
                product.Name = newName;
                product.Price = newPrice;
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        public void DeleteProduct(int id)
        {
            Product product = products.Find(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}