using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NameReference
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Users = new[]
            {
                new User("John", "Doe")
            };

            UserTappedCommand = new Command(user => UserTapped(user as User));
        }

        public IEnumerable<User> Users { get; private set; }

        public ICommand UserTappedCommand { get; private set; }

        private void UserTapped(User user)
        {
            Debug.WriteLine("UserTapped in MainViewModel");
        }
    }
}
