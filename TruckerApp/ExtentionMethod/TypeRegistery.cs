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
           // var entities = new TruckersEntities();
            For<ICustomReport>().Use<CustomReport>().Ctor<TruckersEntities>("db").Is(new TruckersEntities());
            For<IQueuing>().Use<Queuing>().Ctor<TruckersEntities>("db").Is(new TruckersEntities());
            For<IAdministrator>().Use<Administrator>().Ctor<TruckersEntities>("db").Is(new TruckersEntities());
            For<ICustomers>().Use<Customers>().Ctor<TruckersEntities>("db").Is(new TruckersEntities());
            For<ICounter>().Use<Counter>().Ctor<TruckersEntities>("db").Is(new TruckersEntities());
            For<IReportSender>().Use<ReportSender>().Ctor<TruckersEntities>("db").Is(new TruckersEntities());
            For<IHasherClass>().Use<HasherClass>();
        }
    }
}
