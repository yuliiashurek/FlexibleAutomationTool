using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Services
{
    public class UserRepository : IRepository<User>
    {
        private FlexibleAutomationToolContext _context;

        public UserRepository(FlexibleAutomationToolContext context)
        {
            _context = context;
        }
        public void Create(User user)
        {
            lock (_context)
            {
                _context.Users.Add(user);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(User item)
        {
            throw new NotImplementedException();
        }

        public User? Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
