using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CManagement.Model
{
    internal class UserInfo
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"UserId::{UserID}\t UserName::{UserName} \t Password::{Password}\t UserContNo::{ContactNumber}\t Address::{Address}";
        }

        public UserInfo()
        {

        }
        public UserInfo(int userID, string userName, string email, string password, string contactNumber, string address)
        {
            UserID = userID;
            UserName = userName;
            Email = email;
            Password = password;
            ContactNumber = contactNumber;
            Address = address;
        }

    }
}
