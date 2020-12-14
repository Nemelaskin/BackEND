using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Models
{
    public class Account
    {
        private int IdAccount;
        private int FullName;
        private int Mail;
        private int PasswordAcc;
        private int Role;
        public int idAccount { get { return IdAccount; } set { IdAccount = value; } }
        public int fullName { get { return FullName; } set { FullName = value; } }
        public int mail { get { return Mail; } set { Mail = value; } }
        public int passwordAcc { get { return PasswordAcc; } set { PasswordAcc = value; } }
        public int role { get { return Role; } set { Role = value; } }
    }
}
