using Entities.Models;
using System.Collections.Generic;

namespace DataAccess
{
   public static class DbContext
    {
        public static List<Drug> Drugs { get; }
        public static List<DrugType> DrugTypes { get; }
        static DbContext()
        {
            Drugs = new List<Drug>();
            DrugTypes = new List<DrugType>();

        }

    }
}
