﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp
{
    public class LocalDBService
    {
        private const string DB_NAME = "DemoLocaLDb.db3";
        private readonly SQLiteAsyncConnection _conection;

        public LocalDBService()
        {
            _conection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _conection.CreateTableAsync<User>();
        }
        public async Task <List<User>> GetUser()
        {
            return await _conection.Table<User>().ToListAsync();
        }
        public async Task <User> GetById(int id)
        {
            return await _conection.Table<User>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task Create(User user)
        {
            await _conection.InsertAsync(user);
        }
        public async Task Update(User user)
        {
            await _conection.UpdateAsync(user);
        }
        public async Task Delete(User user)
        {
            await _conection.DeleteAsync(user);
        }
    }
}
