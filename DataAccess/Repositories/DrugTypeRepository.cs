using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DrugTypeRepository : IRepository<DrugType>
    {
        public bool Create(DrugType entity)
        {
            try
            {
                DbContext.DrugTypes.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(DrugType entity)
        {
            try
            {
                DbContext.DrugTypes.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DrugType Get(Predicate<DrugType> filter)
        {
            try
            {
                return filter == null ? DbContext.DrugTypes[0]
                    : DbContext.DrugTypes.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DrugType> GetAll(Predicate<DrugType> filter = null)
        {
            try
            {
                return filter == null ? DbContext.DrugTypes
                    : DbContext.DrugTypes.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(DrugType entity)
        {
            try
            {
                DrugType dbDrugType = Get(dt => dt.Id == entity.Id);
                dbDrugType = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
