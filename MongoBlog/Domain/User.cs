using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int ID { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required PersonalInfomation PersonalInfomation { get; set; }
        public List<Blog>? Blogs { get; set; } = null;
    }

    public class PersonalInfomation
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public Sex Sex { get; set; } = Sex.None;
        public required Address Address { get; set; }
    }

    public class Address
    {
        public required string Street { get; set; }
        public required string City { get; set; }
        public required string Region { get; set; }
        public required string PostalCode { get; set; }
        public required string Country { get; set; }
    }

    public enum Sex 
    {
        None,
        Man,
        Women
    }
}
