using StackStudentsAzureDevOps.Models;
using StackStudentsAzureDevOps.Services.InMemoryData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StackStudentsAzureDevOps.Services
{
    public class UserService
    {
        public List<User> GetAll()
        {
            return ApplicationDbContext.Users;
        }

        public User Get(Guid id)
        {
            return ApplicationDbContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
