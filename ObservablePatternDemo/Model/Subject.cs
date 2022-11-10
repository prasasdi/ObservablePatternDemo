using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePatternDemo.Model
{
    internal class Subject : ISubject
    {
        readonly User _user;

        public event Action<User> UserChanged;

        public Subject(string name, int age)
        {
            _user = new User
            {
                Name = name,
                Age = age
            };
        }

        public void UpdateUserAge(int age)
        {
            _user.Age = age;
            if (UserChanged != null) UserChanged(_user);
        }
    }
}
