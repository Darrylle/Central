using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralCode
{
    public class LoginUser
    {
  
        /// <summary>
        /// This allows a new user account to be created.
        /// </summary>
        /// <param name="UserName">Username they have entered.</param>
        /// <param name="UserPW">Unencrypted password.</param>
        /// <param name="Email">Their contact email address.</param>
        /// <returns>OK if no error, or an error message if a problem is encountered.</returns>
        public ErrMsg CreateAcc(
                        string UserName, 
                        string UserPW, 
                        string Email)
        {            
            // 1. Does username exists? Reject - inform user...
            if (UserExists(UserName) == true)
            {
                return ErrMsg.UserExists;
            }

            // 2. Is password strength weak? Reject - inform user...
            if (PassWordFail(UserPW) == true)
            {
                return ErrMsg.PasswordFail;
            }

            // 3. Is email address formatted incorrectly? Reject - inform user...
            if (EmailFail(Email) == true)
            {
                return ErrMsg.EmailFail;
            }

            // 4. Does email address already exist? 
            //    Inform user and ask if they want to reset password...
            if (EmailExists(Email) == true)
            {
                return ErrMsg.EmailExists;
            }

            // 5. All ok ... create account on system
            string UserID = CreateAccount(UserName, UserPW , Email);

            // 6. Send confirmation email to ensure email IS theirs...
            SendConfirmation(Email, UserID);
            
            return ErrMsg.OK;    
        }

        public string Login(
                        string UserName,
                        string UserPW)
        {
            if((UserName == "dave") && (UserPW == "password"))
                return "1";
            else
                return "";    
        }


        /// <summary>
        /// Check if username already stored.
        /// </summary>
        /// <param name="UserName">The entered username.</param>
        /// <returns>True is the username already exists, false if not.</returns>
        protected bool UserExists(string UserName)
        {
            //Default for now...
            return false;
        }

        /// <summary>
        /// Check if password adheres to password strength rule.
        /// </summary>
        /// <param name="UserPW">Password entered by user.</param>
        /// <returns>False if password strength rule broken.</returns>
        protected bool PassWordFail(string UserPW)
        {
            //Default for now...
            return false;
        }

        /// <summary>
        /// Check if email string is correct email format.
        /// </summary>
        /// <param name="Email">Email address entered by user.</param>
        /// <returns>False is email format is incorrect.</returns>
        protected bool EmailFail(string Email)
        {
            //Default for now...
            return false;
        }

        /// <summary>
        /// Check if email already exists in database.
        /// </summary>
        /// <param name="Email">Email address entered by user.</param>
        /// <returns>Returns true if email already exists on system.</returns>
        protected bool EmailExists(string Email)
        {
            //Default for now...
            return false;
        }

        /// <summary>
        /// Send email to email address provided by user to ensure 
        /// that it belongs to them.
        /// </summary>
        /// <param name="Email">Email address entered by user.</param>
        /// <param name="UserID">UserID created by system.</param>
        protected void SendConfirmation(string Email, string UserID)
        {
            //tba
        }

        /// <summary>
        /// Create the user account with provided details.
        /// </summary>
        /// <param name="UserName">Username provided by user.</param>
        /// <param name="PassWord">Password provided by user.</param>
        /// <param name="Email">Email address provided by user.</param>
        /// <returns></returns>
        protected string CreateAccount(string UserName, string PassWord, string Email)
        {
            //tba
            return "1";    //Temp - tba
        }
    }
        
    /// <summary>
    /// Used to return consistent indication of success / failure.
    /// </summary>
    public enum ErrMsg 
    {
        OK,
        UserExists,            
        PasswordFail, 
        EmailFail,
        EmailExists
    }
    
}
