using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public abstract class RepositoryBase<T> where T : class
    {
        protected async Task InvokeQueryAsync(Func<Task> func)
        {
            try
            {
                await func();
            }
            catch(Exception e)
            {
                //TODO: Implement
                throw new NotImplementedException(e.Message);
            }
        }

        public async Task<T> InvokeQueryAsync(Func<Task<T>> func)
        {
            try
            {
                return await func();
            }
            catch(Exception e)
            {
                //TODO: Implement
                throw new NotImplementedException(e.Message);
            }
        }

        public async Task<List<T>> InvokeQueryAsync(Func<Task<List<T>>> func)
        {
            try
            {
                return await func();
            }
            catch (Exception e)
            {
                //TODO: Implement
                throw new NotImplementedException(e.Message);
            }
        }
    }
}
