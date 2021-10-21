using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class DrugTypeServices : IDrugType
    {
        public DrugTypeRepository drugtypeRepository { get; set; }
        private static int count { get; set; }
        public DrugTypeServices()
        {
            drugtypeRepository = new DrugTypeRepository();
        }
        public DrugType Create(DrugType drugtype)
        {
            try
            {
                drugtype.Id = count;
                DrugType isExist = drugtypeRepository.Get(dt => dt.TypeName.ToLower()==drugtype.TypeName.ToLower());
                if (isExist != null) 
                    return null;
                drugtypeRepository.Create(drugtype);
                return drugtype;
                count++;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public DrugType Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public DrugType Get(int Id)
        {
            throw new NotImplementedException();
        }

        public DrugType Get(string TypeName)
        {
            throw new NotImplementedException();
        }

        public List<DrugType> GetAll()
        {
            return drugtypeRepository.GetAll();
        }

        public List<DrugType> GetAll(int DrugCount)
        {
            throw new NotImplementedException();
        }

        public DrugType Update(int Id, DrugType drugtype)
        {
            throw new NotImplementedException();
        }
    }
}

