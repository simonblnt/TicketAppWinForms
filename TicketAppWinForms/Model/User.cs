using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAppWinForms.Model
{
    public class User
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public int AccountTypeId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(int id, string accountName, int accountTypeId, string password, string firstName, string lastName) {
            this.Id = id;
            this.AccountName = accountName;
            this.AccountTypeId = accountTypeId;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
