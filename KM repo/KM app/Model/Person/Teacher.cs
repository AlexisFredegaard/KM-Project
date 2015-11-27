using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM_app
{
    class Teacher : Person
    {   //teacher rank
        private string rank;


        public Teacher(string name, string username, string password, int iD, string adress, int phoneNumber,
            string email, string rank)
            : base(name,username,password,iD,adress,phoneNumber,email)
        {
            //this.Name = name;
            //this.Username = username;
            //this.Password = password;
            //this.ID = iD;
            //this.Adress = adress;
            //this.PhoneNumber = phoneNumber;
            //this.Email = email;
            this.rank = rank;

        }





        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        
    }
}
