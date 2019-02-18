using System;
namespace DemoPattern.StepHelpers
{
    class UserCreadentials
    {
        private string _userName = null;
        private string _userPassword = null;
       


        public string UserName
        {
            get
            {
                if (_userName != null)
                {
                    return _userName;
                }
                else
                {
                    throw new ArgumentNullException("UserName is not defined.");
                }
            }
            set
            {
                _userName = value;
            }
        }

        public string UserPassword
        {
            get
            {
                if (_userPassword != null)
                {
                    return _userPassword;
                }
                else
                {
                    throw new ArgumentNullException("User password is not defined.");
                }
            }
            set
            {
                _userPassword = value;
            }
        }

    }
}
