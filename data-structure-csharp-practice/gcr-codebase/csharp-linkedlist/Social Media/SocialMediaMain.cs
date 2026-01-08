using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.Social_Media
{
    // Friend Node (stores friend IDs)
    public class FriendNode
    {
        public int FriendId;
        public FriendNode Next;

        public FriendNode(int id)
        {
            FriendId = id;
            Next = null;
        }
    }

    // User Node
    public class UserNode
    {
        public int UserId;
        public string Name;
        public int Age;
        public FriendNode Friends;
        public UserNode Next;

        public UserNode(int id, string name, int age)
        {
            UserId = id;
            Name = name;
            Age = age;
            Friends = null;
            Next = null;
        }
    }

    // Singly Linked List for Users
    public class SocialMediaList
    {
        private UserNode head;

        // Add User
        public void AddUser(int id, string name, int age)
        {
            UserNode node = new UserNode(id, name, age);
            node.Next = head;
            head = node;
        }

        // Find User by ID
        private UserNode FindUser(int id)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.UserId == id)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        // Add Friend Connection
        public void AddFriend(int id1, int id2)
        {
            UserNode user1 = FindUser(id1);
            UserNode user2 = FindUser(id2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found");
                return;
            }

            user1.Friends = new FriendNode(id2) { Next = user1.Friends };
            user2.Friends = new FriendNode(id1) { Next = user2.Friends };

            Console.WriteLine("Friend connection added");
        }

        // Remove Friend Connection
        public void RemoveFriend(int id1, int id2)
        {
            RemoveFriendHelper(id1, id2);
            RemoveFriendHelper(id2, id1);
            Console.WriteLine("Friend connection removed");
        }

        private void RemoveFriendHelper(int userId, int friendId)
        {
            UserNode user = FindUser(userId);
            if (user == null || user.Friends == null) return;

            if (user.Friends.FriendId == friendId)
            {
                user.Friends = user.Friends.Next;
                return;
            }

            FriendNode temp = user.Friends;
            while (temp.Next != null && temp.Next.FriendId != friendId)
                temp = temp.Next;

            if (temp.Next != null)
                temp.Next = temp.Next.Next;
        }

        // Display Friends of User
        public void DisplayFriends(int id)
        {
            UserNode user = FindUser(id);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine($"Friends of {user.Name}:");
            FriendNode temp = user.Friends;

            if (temp == null)
            {
                Console.WriteLine("No friends");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine("Friend ID: " + temp.FriendId);
                temp = temp.Next;
            }
        }

        // Search User
        public void SearchUser(int id)
        {
            UserNode user = FindUser(id);
            if (user != null)
                Console.WriteLine($"Found: {user.UserId}, {user.Name}, Age {user.Age}");
            else
                Console.WriteLine("User not found");
        }

        // Count Friends
        public void CountFriends(int id)
        {
            UserNode user = FindUser(id);
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            int count = 0;
            FriendNode temp = user.Friends;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            Console.WriteLine($"{user.Name} has {count} friends");
        }
    }

    // Main / Utility Class
    public class SocialMediaMain
    {
        public static void Main(string[] args)
        {
            SocialMediaList list = new SocialMediaList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Social Media Friend Connections ---");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Add Friend Connection");
                Console.WriteLine("3. Remove Friend Connection");
                Console.WriteLine("4. Display Friends");
                Console.WriteLine("5. Search User");
                Console.WriteLine("6. Count Friends");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("User ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());
                        list.AddUser(id, name, age);
                        break;

                    case 2:
                        Console.Write("Enter User IDs: ");
                        list.AddFriend(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Enter User IDs: ");
                        list.RemoveFriend(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                        break;

                    case 4:
                        Console.Write("Enter User ID: ");
                        list.DisplayFriends(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Enter User ID: ");
                        list.SearchUser(int.Parse(Console.ReadLine()));
                        break;

                    case 6:
                        Console.Write("Enter User ID: ");
                        list.CountFriends(int.Parse(Console.ReadLine()));
                        break;

                    case 0:
                        Console.WriteLine("Program Ended");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
