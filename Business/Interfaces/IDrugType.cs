using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IDrugType
    {
        DrugType Create(DrugType drugtype);
        DrugType Update(int Id,DrugType drugtype);
        DrugType Delete(int Id);
        DrugType Get(int Id);
        DrugType Get(string TypeName);
        List<DrugType> GetAll();
        List<DrugType> GetAll(int DrugCount);


    }
}
