using ClothesStoreManagementSystem.Helpers;
using ClothesStoreManagementSystem.Models;
using ClothesStoreManagementSystem.Operations.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreManagementSystem.Operations.Concrete
{
    public class UserManager : IUserOperation
    {
        public Result Add(User model)
        {

            #region Check Password or Username is empty

            if (string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))
            {
                return new Result("Username or Password is empty", false);
            }

            #endregion

            #region Check User is Already exists or not

            var existingUser = Database.Users.FirstOrDefault(x => x.Username.ToLower() == model.Username.ToLower());

            if (existingUser != null)
            {
                return new Result("This is already exists", false);
            }

            #endregion

            #region Check Password Length

            if (model.Password.Length < 6)
            {
                return new Result("Password is less than six symbol", false);
            }

            #endregion

            // finally add model to users

            model.Password = CryptingHelper.Encrypt(model.Password);

            Database.Users.Add(model);

            return new Result("User added successfully", true);
        }

        public Result Delete(User model)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return Database.Users;
        }

        public int GetNextId()
        {
           return Database.Users.Max(x => x.ID) + 1;
        }

        public Result Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
