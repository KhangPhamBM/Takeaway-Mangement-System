using Microsoft.EntityFrameworkCore;
using SnackDeliveryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackDeliveryLibrary.Repository
{
    public class AccountReposotory : IRepository<Account>
    {
        SnackDeliveryContext db = new SnackDeliveryContext();
        public async Task Add(Account entity)
        {
            db.Accounts.Add(entity);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var accountToDelete = await GetById(id);
            if(accountToDelete != null)
            {
                accountToDelete.Deleted = true;
            }
        }

        public async Task<List<Account>> GetAll()
        {
           var accountList = await db.Accounts.ToListAsync();
            return accountList;
        }

        public async Task<Account> GetById(int id)
        {
            var account = await db.Accounts.FirstOrDefaultAsync(a => a.Id == id);
            return account;
        }

        public async Task Update(int id, Account entity)
        {
            var accountToUpdate = await GetById(id);
            if(accountToUpdate != null)
            {
                accountToUpdate.Name = entity.Name;
                accountToUpdate.PhoneNumber = entity.PhoneNumber;
                accountToUpdate.IsAdmin = entity.IsAdmin;
                accountToUpdate.Deleted = entity.Deleted;
            }
        }

        public async Task<bool> CheckLogin(string phoneNumber, string password)
        {
            var account = await db.Accounts.FirstOrDefaultAsync(a => a.PhoneNumber == phoneNumber);
            if(account == null )
            {
                throw new Exception("Invalid Phonenumber");
            }
            if(!account.Password.Equals(password))
            {
                throw new Exception("Wrong Password");
            }
        }
    }
}
