using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorLeaflet.Samples.Data
{
    public class CargoServices
    {
        
        private CargoDbContext dbContext;
      

        #region Constructor
        public CargoServices(CargoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods

        public async Task<List<Cargo>> GetCargoAsync()
        {
            return await dbContext.Cargo.ToListAsync();
        }


        public async Task<Cargo> AddCargoAsync(Cargo cargo)
        {
            try
            {
                dbContext.Cargo.Add(cargo);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return cargo;
        }

        public async Task<Cargo> UpdateCargoAsync(Cargo cargo)
        {
            try
            {
                var productExist = dbContext.Cargo.FirstOrDefault(p => p.Id == cargo.Id);
                if (productExist != null)
                {
                    dbContext.Update(cargo);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cargo;
        }

        public async Task DeleteCargoAsync(Cargo cargo)
        {
            try
            {
                dbContext.Cargo.Remove(cargo);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
