using System;
using System.Collections.Generic;
using System.Text;

namespace SingeltonDesignPattern
{
    public class Singelton
    {
        private static Lazy<Singelton> instance = null;
        public static Lazy<Singelton> GetInstance()
        {
            if (instance is null)
                instance = new Lazy<Singelton>();
            return instance;
        }
        private Singelton()
        {
        }
    }
}
// Lazy<T>	A wrapper class that provides lazy initialization semantics for any class library or user-defined type.
/*
 * Lazy initialization of an object means that its creation is deferred until it is first used. Lazy initialization is primarily used to improve performance, avoid wasteful computation, and reduce program memory requirements. These are the most common
 * scenarios:
   When you have an object that is expensive to create, and the program might not use it. For example, assume that you have in memory a Customer object that has an Orders property that contains a large array of Order objects that, to be initialized, 
   requires a database connection. If the user never asks to display the Orders or use the data in a computation, then there is no reason to use system memory or computing cycles to create it. By using Lazy<Orders> to declare the Orders object for 
   lazy initialization, you can avoid wasting system resources when the object is not used.
*/