using System;

namespace App
{
    public class Program
    {
        internal static void SortByUsername(User[] users)
        {
            Array.Sort(users, (u1, u2) => u1.username.CompareTo(u2.username)); 
        }

        internal static void FilterByBirthYear(User[] users, int year)
        {
            foreach (var user in users)
            {
                if (user.getBirthYear() >= year)
                {
                    Console.WriteLine(user.name);
                }
            }
        }

        internal static void Login(User[] users, string username, string password)
        {
            foreach (var user in users)
            {
                if (user.username == username)
                {
                    if (user.VerifyPassword(password))
                    {
                        user.isLogged = true; 
                        Console.WriteLine("Login successful.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password.");
                        return;
                    }
                }
            }
            Console.WriteLine("User not found.");
        }
        
        internal static void LogOut(User[] users, string username)
        {
            foreach (var user in users)
            {
                if (user.username == username)
                {
                    if (user.isLogged)
                    {
                        user.isLogged = false;
                        Console.WriteLine($"Successfully logged out. Goodbye, {username}.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("User did not logged in to log out!");
                        return;
                    }
                }
            }
            Console.WriteLine("User not found!");
        }

        internal static User[] CreateUser(User[] users, User newUser)
        {
            User[] newArray = new User[users.Length + 1];

            Array.Copy(users, newArray, users.Length);

            newArray[newArray.Length - 1] = newUser;

            Console.WriteLine($"User '{newUser.username}' successfully added to the new array.");
            return newArray;
        }
        
        internal static (User[], bool) DeleteUser(User[] users, string username)
        {
            int indexToDelete = -1;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].username == username) 
                {
                    indexToDelete = i;
                    break;
                }
            }

            if (indexToDelete == -1)
            {
                Console.WriteLine("User not found!");
                return (users, false);
            }

            User[] newArray = new User[users.Length - 1];
            
            Array.Copy(users, 0, newArray, 0, indexToDelete);
            
            Array.Copy(users, indexToDelete + 1, newArray, indexToDelete, users.Length - indexToDelete - 1);

            Console.WriteLine($"User '{username}' successfully deleted.");
            return (newArray, true);
        }
        
        public static void Main(string[] args)
        {
            User[] users = new User[0]; 
            
            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine("name:");
                string name = Console.ReadLine();
                Console.WriteLine("surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("age:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("gender:");
                string gender = Console.ReadLine();
                Console.WriteLine("nationality:");
                string nationality = Console.ReadLine();
                Console.WriteLine("username:");
                string username = Console.ReadLine();
                Console.WriteLine("email:");
                string email = Console.ReadLine();
                Console.WriteLine("password:");
                string password = Console.ReadLine();
                Console.WriteLine("bio:");
                string bio = Console.ReadLine();
                
                User user = new User(name, surname, age, gender, nationality, username, email, password, bio);
                
                users = CreateUser(users, user); 
            }
        }
    }
}