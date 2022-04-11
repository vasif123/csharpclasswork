using System;
using System.Collections.Generic;
using System.Text;

namespace csharphomework
{
    class userdata
    {
        private string _user;
        private string _password;
        
        public string User
        {
            get
            {
                return _user;
            }
            set
            {

            }
        }

         public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                int count = 0;
                int count1 = 0;
                int count2 = 0;
                if (value.Length >= 8)
                {
                    foreach (char item in value)
                    {
                        if (char.IsUpper(item))
                        {
                            count++;
                        }
                        else if (char.IsDigit(item))
                        {
                            count1++;
                        }
                        else if (char.IsLower(item))
                        {
                            count2++;
                        }
                    }
                }
            }
        }
        
    }
}
