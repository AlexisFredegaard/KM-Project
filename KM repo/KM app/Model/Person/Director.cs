using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM_app
{
    class Director : Person
    {
        public Director(string name, string username, string password, int iD, string adress, int phoneNumber, string email)
            :base(name,username,password,iD,adress,phoneNumber,email)
        {
            //all should be covered  in the superclass.

            //this.Name = name;
            //this.Username = username;
            //this.Password = password;
            //this.ID = iD;
            //this.Adress = adress;
            //this.PhoneNumber = phoneNumber;
            //this.Email = email;
            

        }



    }
}
