﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class Borowable : Decorator
    {
        protected readonly List<string> borrowers = new List<string>();
        // Constructor
        public Borowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }
        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }
        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }
        public override void Display()
        {
            base.Display();
            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
