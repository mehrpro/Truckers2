using System.Linq;

namespace TruckerApp
{

    public class Counter
    {
        private TruckersEntities db = new TruckersEntities();
        public int Packet()=> db.Queues.Count(x => x.Type_FK == 2 && x.SeriesID_FK == PublicVar.SeriesID);
        public int Faleh() =>  db.Queues.Count(x => x.Type_FK == 1 && x.SeriesID_FK == PublicVar.SeriesID);
        public int Gandom()=>  db.Queues.Count(x => x.Type_FK == 3 && x.SeriesID_FK == PublicVar.SeriesID);
        public int Clinker() => db.Queues.Count(x => x.Type_FK == 4 && x.SeriesID_FK == PublicVar.SeriesID);
        public int Member() => db.Queues.Count(x => x.GroupCommission == 30 && x.SeriesID_FK == PublicVar.SeriesID);
        public int noMember() => db.Queues.Count(x => x.GroupCommission == 31 && x.SeriesID_FK == PublicVar.SeriesID);
        public int Other()=> db.Queues.Count(x => x.GroupCommission == 32 && x.SeriesID_FK == PublicVar.SeriesID);

    }
}