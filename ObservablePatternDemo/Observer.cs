using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ObservablePatternDemo.Model;

namespace ObservablePatternDemo
{
    internal class Observer : IObserver<User>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Complete");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Error : {error.Message}");
        }

        public void OnNext(User value)
        {
            Console.WriteLine($"Name : {value.Name}, Age : {value.Age}");
        }
    }
}
