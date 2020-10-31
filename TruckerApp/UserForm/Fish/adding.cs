namespace TruckerApp.UserForm.Fish
{
    public class Adding
    {
        private readonly TruckersEntities _db = new TruckersEntities();
        public string StrNumber { get; private set; }
        public bool addingFish(Queue queue,Cash cash)
        {
            using (var ts = _db.Database.BeginTransaction())
            {
                _db.Queues.Add(queue);
                _db.SaveChanges();
                StrNumber = $"{queue.Number}";
                cash.QueueID_FK = queue.ID;
                cash.userID = PublicVar.UserID;
                cash.seriesID_FK = queue.SeriesID_FK;
                _db.Cashes.Add(cash);
                _db.SaveChanges();
                ts.Commit();
                return true;
            }
            
        }
    }
}