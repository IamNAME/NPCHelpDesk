using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk
{
    public class User
    {
        private int _userid;
        private string _fName;
        private string _lName;
        private string _email;
        private string _phone;
        //private string _role;//Student/Staff 
        //add room #


        #region Properties
        public int UserID
        {
            get
            {
                return _userid;
            }

            set
            {
                _userid = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _fName;
            }

            set
            {
                _fName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lName;
            }

            set
            {
                _lName = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
        public string Role
        {
            get
            {
                return _role;
            }

            set
            {
                _role = value;
            }
        }
        #endregion
        #region Constructors
        public User()
        {
            //Default constructor
        }
        #endregion
    }