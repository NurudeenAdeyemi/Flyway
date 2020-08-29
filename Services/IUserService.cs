using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlywayAirlines.Services
{
    public interface IUserService
    {
        public List<User> getAll();

        public bool create(string firstName, string lastName, string email, string password);

        public bool update(int id, string firstName, string lastName, string email, string password);

        public bool remove(int id);

        public User findById(int id);

        public User findByEmail(string email);

        public User find(string email, string password);
    }
}
