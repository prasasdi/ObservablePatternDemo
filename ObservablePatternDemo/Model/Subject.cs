using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePatternDemo.Model
{
    internal class Subject : IObservable<User>, IDisposable
    {
        readonly User _user;

        public event Action<User> UserChanged; // remove soon

        private IList<IObserver<User>> _observers = new List<IObserver<User>>();

        public Subject(string name, int age)
        {
            _user = new User
            {
                Name = name,
                Age = age
            };
        }

        // delete soon
        public void UpdateUserAge(int age)
        {
            _user.Age = age;
            foreach (var observer in _observers)
            {
                observer.OnNext(_user);
            }
        }

        public IDisposable Subscribe(IObserver<User> observer)
        {
            _observers.Add(observer);
            observer.OnNext(_user);
            return this;
        }

        public void Dispose()
        {
            _observers.Clear();
        }
    }
}
