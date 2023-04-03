using CarManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagment.Domain.Entity
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int EngineCapacity { get; set; }
        public DateTime InsuranceData { get; set; }
        public DateTime TechnicalData { get; set; }

        public Car(int id, string name, int typeId, int engineCapacity, DateTime dateIns, DateTime dateTech)
        {
            Id = id;
            Name = name;
            TypeId = typeId;
            EngineCapacity = engineCapacity;
            InsuranceData = dateIns;
            TechnicalData = dateTech;
        }
    }
}
