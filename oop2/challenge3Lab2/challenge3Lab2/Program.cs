using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MUser> users = new List<MUser>();
            LoadUserDataFromFile("user_data.txt", users);

            Console.WriteLine("Welcome to the Sign-Up/Sign-In application!");

            while (true)
            {
                Console.WriteLine("\n1. Sign Up");
                Console.WriteLine("2. Sign In");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SignUp(users);
                        break;
                    case "2":
                        SignIn(users);
                        break;
                    case "3":
                        Console.WriteLine("Exiting the application...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void SignUp(List<MUser> users)
        {
            Console.Write("\nEnter username: ");
            string username = Console.ReadLine();

            // Check if the username already exists
            if (users.Exists(u => u.Username == username))
            {
                Console.WriteLine("Username already exists. Please choose a different one.");
                return;
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter role: ");
            string role = Console.ReadLine();

            MUser newUser = new MUser(username, password, role);
            users.Add(newUser);

            Console.WriteLine("User signed up successfully!");
            SaveUsersToFile("user_data.txt", users);
        }

        static void SignIn(List<MUser> users)
        {
            Console.Write("\nEnter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            MUser user = users.Find(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine($"Welcome, {user.Username}! Your role is {user.Role}.");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
        }
        static void LoadUserDataFromFile(string filename, List<MUser> users)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string username = parts[0];
                        string password = parts[1];
                        string role = parts[2];
                        MUser user = new MUser(username, password, role);
                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading user data: {ex.Message}");
            }

        }
        static void SaveUsersToFile(string fileName, List<MUser> users)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (MUser user in users)
                {
                    writer.WriteLine($"{user.Username},{user.Password},{user.Role}");
                }
            }
        }


    }
}

