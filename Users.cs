using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Manager
{
    public  class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string UID { get; set; }
        public string Address {  get; set; }
        public string MobileNumber {  get; set; }
        public bool IsAdmin { get; set; }
        public Users(int id, string username, string password, string email, string firstName, string lastName, string uID, string address, string mobileNumber, bool isAdmin)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            UID = uID;
            Address = address;
            MobileNumber = mobileNumber;
            IsAdmin = isAdmin;
        }
    }
}
