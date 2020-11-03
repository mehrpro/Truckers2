using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using TruckerApp.Repository;

namespace TruckerApp.ExtentionMethod
{
  public  class TypeRegistery : Registry
    {
        public TypeRegistery()
        {
            var entities = new TruckersEntities();
            For<ICustomReport>().Use<CustomReport>().Ctor<TruckersEntities>("db").Is(entities);
            For<IQueuing>().Use<Queuing>().Ctor<TruckersEntities>("db").Is(entities);
            For<IAdministrator>().Use<Administrator>().Ctor<TruckersEntities>("db").Is(entities);
            For<ICustomers>().Use<Customers>().Ctor<TruckersEntities>("db").Is(entities);
            For<ICounter>().Use<Counter>().Ctor<TruckersEntities>("db").Is(entities);
            For<IReportSender>().Use<ReportSender>().Ctor<TruckersEntities>("db").Is(entities);
            For<IHasherClass>().Use<HasherClass>();
        }
    }
}
