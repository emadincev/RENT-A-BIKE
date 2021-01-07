using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RentBusiness
    {
        private readonly RentRepository rentRepository;

        public RentBusiness()
        {
            this.rentRepository = new RentRepository();
        }
        public List<User> GetAllUsers()
        {
            return this.rentRepository.GetAllUsers();
        }
        public List<Product> GetAllProducts()
        {
            return this.rentRepository.GetAllProducts();
        }
        public bool InsertProduct (Product p)
        {
            if (this.rentRepository.InserProduct(p) > 0)
            {
                return true;
            }
            return false;
        }
        public bool InserUser(User u)
        {
            if (this.rentRepository.InserUser(u) > 0)
            {
                return true;
            }
            return false;
        }
        public bool CheckUser(User u)
        {
            List<User> userList = rentRepository.GetAllUsers();
            foreach(User user in userList)
            {
                if(user.Password==u.Password && user.Email == u.Email)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
