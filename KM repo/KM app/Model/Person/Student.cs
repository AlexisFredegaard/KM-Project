using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM_app
{
    class Student : Person
    {
        private int kmPoints;
        private string rank;

        //this is the awkwardly long constructor of the student that inherates from Person
        public Student(
            string name, string username, string password, int iD, string adress, int phoneNumber,
            string email, int kmPoints, string rank) 
            :base(name,username,password,iD,adress,phoneNumber,email)
        {
            // test thinggy doesn't need all these stuffs, only new things.

            //this.Name = name;
            //this.Username = username;
            //this.Password = password;
            //this.ID = iD;
            //this.Adress = adress;
            //this.PhoneNumber = phoneNumber;
            //this.Email = email;

            this.kmPoints = kmPoints;
            this.rank = rank;
            
        }
        


        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        
        public int KmPoints
        {
            get { return kmPoints; }
            set { kmPoints = value; }
        }
        


    }
}
