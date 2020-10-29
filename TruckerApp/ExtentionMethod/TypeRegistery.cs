using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckerApp.Repository;

namespace TruckerApp.ExtentionMethod
{
  public  class TypeRegistery : StructureMap.Registry
    {
        public TypeRegistery()
        {
            var entities = new TruckersEntities();
            For<ICustomReport>().Use<CustomReport>().Ctor<TruckersEntities>("db").Is(entities);
            For<IQueuing>().Use<Queuing>().Ctor<TruckersEntities>("db").Is(entities);
        }
    }
}
