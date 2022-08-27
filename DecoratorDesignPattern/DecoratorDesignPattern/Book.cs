using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class Book
    {
        private string title;

       public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public virtual int SetDimension(int lenth, int breadth, int height)
        {
            return lenth * breadth * height;
        }

        public virtual void Display()
        {
            Console.WriteLine(Title);
        }

    }
}
