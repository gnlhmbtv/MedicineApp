using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DrugRepository : IRepository<Drug>
    {
        public bool Create(Drug entity)
        {
            try
            {
                DbContext.Drugs.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Drug entity)
        {
            try
            {
                DbContext.Drugs.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Drug Get(Predicate<Drug> filter)
        {
            try
            {
                return filter==null ? DbContext.Drugs[0]
                    : DbContext.Drugs.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Drug> GetAll(Predicate<Drug> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Drugs
                    : DbContext.Drugs.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Drug entity)
        {
            try
            {
                Drug dbDrug = Get(d => d.Id == entity.Id);
                dbDrug = entity;
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
