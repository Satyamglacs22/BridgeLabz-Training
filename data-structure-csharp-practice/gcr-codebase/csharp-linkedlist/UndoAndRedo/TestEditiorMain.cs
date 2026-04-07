using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Assignment.UndoAndRedo
{
    // Node Class
    public class TextNode
    {
        public string Content;
        public TextNode Prev;
        public TextNode Next;

        public TextNode(string content)
        {    
            Content = content;
            Prev = null;
            Next = null;
        }
    }

    // Doubly Linked List for Undo/Redo
    public class TextEditor
    {
        private TextNode head;
        private TextNode tail;
        private TextNode current;
        private int count;
        private const int MAX = 10;

        // Add New Text State
        public void AddState(string text)
        {
            TextNode node = new TextNode(text);

            if (head == null)
            {
                head = tail = current = node;
                count = 1;
                return;
            }

            // Remove redo states
            if (current.Next != null)
            {
                current.Next = null;
                tail = current;
            }

            tail.Next = node;
            node.Prev = tail;
            tail = node;
            current = node;
            count++;

            // Limit history to MAX states
            if (count > MAX)
            {
                head = head.Next;
                head.Prev = null;
                count--;
            }
        }

        // Undo
        public void Undo()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Undo performed");
            }
            else
            {
                Console.WriteLine("No more undo available");
            }
        }

        // Redo
        public void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Redo performed");
            }
            else
            {
                Console.WriteLine("No more redo available");
            }
        }

        // Display Current Text
        public void DisplayCurrent()
        {
            if (current == null)
                Console.WriteLine("Editor empty");
            else
                Console.WriteLine("Current Text: " + current.Content);
        }
    }

    // Main / Utility Class
    public class TextEditorMain
    {
        public static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            int choice;

            do
            {
                Console.WriteLine("\n--- Undo / Redo Text Editor ---");
                Console.WriteLine("1. Type New Text");
                Console.WriteLine("2. Undo");
                Console.WriteLine("3. Redo");
                Console.WriteLine("4. Display Current Text");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text: ");
                        editor.AddState(Console.ReadLine());
                        break;

                    case 2:
                        editor.Undo();
                        break;

                    case 3:
                        editor.Redo();
                        break;

                    case 4:
                        editor.DisplayCurrent();
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
