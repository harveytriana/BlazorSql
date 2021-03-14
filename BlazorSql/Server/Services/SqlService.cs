// ======================================
//  Blazor Spread. LHTV
// ======================================
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSql.Server.Services
{
    public class SqlService<T> : IDataService<T> where T : class, new()
    {
        readonly SqlContext _context;

        public SqlService(SqlContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(T item)
        {
            try {
                await _context.AddAsync(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception exception) {
                ErrorMessage( exception.Message);
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            try {
                var i = await Read(id);
                if (i != null) {
                    _context.Remove<T>(i);
                    await _context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception exception) {
                ErrorMessage( exception.Message);
            }
            return false;
        }

        public async Task<IEnumerable<T>> Items()
        {
            try {
                return _context.Set<T>().AsEnumerable();
            }
            catch (Exception exception) {
                ErrorMessage( exception.Message);
            }
            await Task.Delay(100); // escape
            return new List<T>();
        }

        public async Task<T> Read(int id)
        {
            try {
                return await _context.FindAsync<T>(id);
            }
            catch (Exception exception) {
                ErrorMessage( exception.Message);
            }
            return null;
        }

        public async Task<bool> Update(T item)
        {
            try {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception exception) {
                ErrorMessage( exception.Message);
            }
            return false;
        }

        static void ErrorMessage(string error)
        {
            //TODO error log or something
            Trace.WriteLine("Exception:\n" + error);
        }
    }
}
