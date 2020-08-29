using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlywayAirlines.Repositories;

namespace FlywayAirlines.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public List<User> getAll()
        {
            return userRepository.getAll();
        }

        public bool create(string firstName, string lastName, string email, string password)
        {
            return userRepository.create(firstName, lastName, email, password);
        }

        public bool update(int id, string firstName, string lastName, string email, string password)
        {
            return userRepository.update(id, firstName, lastName, email, password);
        }

        public bool remove(int id)
        {
            return userRepository.remove(id);
        }

        public User findById(int id)
        {
            return userRepository.findById(id);
        }

        public User findByEmail(string email)
        {
            return userRepository.findByEmail(email);
        }

        public User find(string email, string password)
        {
            return userRepository.find(email, password);
        }
    }
}
