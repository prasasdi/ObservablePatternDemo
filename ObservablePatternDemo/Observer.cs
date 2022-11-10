using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservablePatternDemo.Model;

namespace ObservablePatternDemo
{
    internal class Observer
    {

        public Observer(ISubject subject)
        {
            subject.UserChanged += Subject_UserChanged;
        }

        private void Subject_UserChanged(User obj)
        {
            Console.WriteLine( $"Name : {obj.Name}, Age : {obj.Age}");
        }

    }
}
