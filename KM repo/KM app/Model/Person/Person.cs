using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM_app
{
    //Somethin gsomething krav maga
    public abstract class Person //superclass for all persons in the system.
    {
        private string name;
        private string username;
        private string password;
        private int iD;
        private string adress;
        private int phoneNumber;
        private string email;

        public Person(string name, string username,string password, int iD, string adress, int phoneNumber, string email)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.iD = iD;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.email = email;
            
        }
        
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value;}
        }

        
    }
}
