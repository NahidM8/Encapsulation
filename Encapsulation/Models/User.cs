
namespace Encapsulation.Models
{
    internal class User
    {
        public string Username { get; set; }
        int _age;
        public int Age 
        { 
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                    return;
                }

            }
        }
        string _password = "wrong";
        public string Password 
        { 
            get
            {
                return _password;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                if (value.Length < 8) return;

                if(!PasswordCheck(value)) return;

                _password = value;


            }
        }
        private bool PasswordCheck(string password)
        {
            bool isDigit = false;
            bool isUpper = false;
            foreach (char item in password)
            {
                if (char.IsDigit(item)) isDigit = true;
                if (char.IsUpper(item)) isUpper = true;
            }
            return isDigit&&isUpper;
        }

        public User(string username,string password)
        {
            Username = username;
            Password = password;
        }
    }
}
