using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using TruckerApp.ViewModels.Customers;

namespace TruckerApp.Repository
{
    public interface ICustomers : IDisposable
    {
        /// <summary>
        /// ثبت راننده جدید
        /// </summary>
        /// <param name="customer">اطلاعات راننده</param>
        /// <returns></returns>
        Task<bool> AddNewDriver(ViewModelCustomer customer);
        /// <summary>
        /// جستجوی شماره کارت هوشمند
        /// </summary>
        /// <param name="smartcart">شماره کارت هوشمند</param>
        /// <returns></returns>
        Task<bool> FindSmartCart(int smartcart);
        /// <summary>
        /// جستجوی پلاک انگلیسی
        /// </summary>
        /// <param name="plateEn">پلاک انگلیسی</param>
        /// <returns></returns>
        Task<bool> FindPlate(string plateEn);
        /// <summary>
        /// جستجوی راننده براساس کارت هوشمند
        /// </summary>
        /// <param name="smartcart">شماره کارت هوشمند</param>
        /// <returns></returns>
        Task<Driver> FindDriverBySmartCart(int smartcart);
        /// <summary>
        ///  جستجوی راننده براساس پلاک انگلیسی
        /// </summary>
        /// <param name="tag">پلاک انگلیسی</param>
        /// <returns></returns>
        Task<Driver> FindDriverByTag(string tag);
        /// <summary>
        /// ویرایش مشخصات راننده
        /// </summary>
        /// <param name="driver">مشخصات راننده</param>
        /// <returns></returns>
        Task<bool> EditDriver(Driver driver);
        /// <summary>
        /// ویرایش راننده و تغییر پلاک
        /// </summary>
        /// <param name="driver">اطلاعات راننده</param>
        /// <returns></returns>
        Task<bool> EditDriverWithNewPlate(Driver driver);
        /// <summary>
        /// لیست رانندگان
        /// </summary>
        /// <returns></returns>
        Task<List<Driver>> GetAllDriver();
        /// <summary>
        /// لیست رانندگان براساس عضویت
        /// </summary>
        /// <param name="groupId">کد گروه</param>
        /// <returns></returns>
        Task<List<Driver>> GetAllDriverByGroupID(byte groupId);
        /// <summary>
        /// ثبت کمیسیون جدید
        /// </summary>
        /// <param name="group">گروه</param>
        /// <param name="commission">مبلغ</param>
        /// <returns></returns>
        Task<bool> AddNewCommision(byte groupId, int commission);

        /// <summary>
        /// لیست کمسیسون بر اساس گروه ها
        /// </summary>
        /// <param name="groupId">گروه</param>
        /// <returns></returns>
        Task<List<Commission>> GetCommissinByGroupId(byte groupId);


        /// <summary>
        /// انتقال تلفن راننده گان
        /// </summary>
        /// <returns></returns>
        Task<bool> TransfomatorPhone();

        /// <summary>
        /// لیست کامل دفترچه تلفن
        /// </summary>
        /// <returns></returns>
        Task<List<PhoneBook>> GetAllAddressBook();

        /// <summary>
        /// ذخیره و ثبت مخاطب 
        /// </summary>
        /// <param name="addressBook">مخاطب</param>
        /// <returns></returns>
        bool ManageAddressBook(PhoneBook addressBook);
    }

    public class Customers : ICustomers
    {
        private readonly TruckersEntities db;

        public Customers(TruckersEntities db)
        {
            this.db = db;
        }

        public async Task<bool> AddNewDriver(ViewModelCustomer customer)
        {
            try
            {
                if (await FindSmartCart(customer.SmartCart)) return false;
                var newDriver = new Driver
                {
                    DriverID = 0,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    PhoneNumber = customer.PhoneNumber,
                    SmartCart = customer.SmartCart,
                    TagNumber = customer.TagNumber,
                    Tag = customer.Tag,
                    GroupID = customer.GroupID,
                    userID_FK = PublicVar.UserID,
                    editor_FK = null,
                    driver_code = customer.driver_code,
                };
                db.Drivers.Add(newDriver);
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public async Task<bool> FindSmartCart(int smartcart)
        {
            return await db.Drivers.AnyAsync(x => x.SmartCart == smartcart);
        }

        public async Task<bool> FindPlate(string plateEn)
        {
            return await db.Drivers.AnyAsync(x => x.Tag == plateEn);
        }

        public async Task<Driver> FindDriverBySmartCart(int smartcart)
        {
            return await db.Drivers.SingleOrDefaultAsync(x => x.SmartCart == smartcart);

        }

        public async Task<Driver> FindDriverByTag(string tag)
        {
            return await db.Drivers.SingleOrDefaultAsync(x => x.Tag == tag);
        }

        public async Task<bool> EditDriver(Driver driver)
        {
            try
            {
                db.Entry(driver).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> EditDriverWithNewPlate(Driver driver)
        {
            using (var trans = db.Database.BeginTransaction())
            {
                try
                {
                    var oldDriver = await FindDriverByTag(driver.Tag);
                    if (oldDriver == null)
                    {
                        var result = await EditDriver(driver);
                        trans.Commit();
                        return result;
                    }
                    else
                    {
                        oldDriver.Tag = oldDriver.TagNumber = @"No_Set";
                        await db.SaveChangesAsync();
                        var result = await EditDriver(driver);
                        if (result)
                            trans.Commit();
                        else
                            trans.Rollback();
                        return result;
                    }
                }
                catch
                {
                    return false;
                }

            }
        }

        public async Task<List<Driver>> GetAllDriver()
        {
            return await db.Drivers.ToListAsync();
        }

        public async Task<List<Driver>> GetAllDriverByGroupID(byte groupId)
        {
            return await db.Drivers.Where(x => x.GroupID == groupId).ToListAsync();
        }

        public async Task<bool> AddNewCommision(byte groupId, int commission)
        {
            try
            {
                var qry = await db.Commissions.Where(x => x.Groups_FK == groupId).ToListAsync();
                foreach (var item in qry)
                {
                    item.enabled = false;
                }
                var newCommission = new Commission
                {
                    DataRegister = DateTime.Now,
                    Groups_FK = groupId,
                    enabled = true,
                    CommissionPrice = commission,
                    GroupID = 2,
                };
                db.Commissions.Add(newCommission);
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Commission>> GetCommissinByGroupId(byte groupId)
        {
            return await db.Commissions.Where(x => x.Groups_FK == groupId).ToListAsync();

        }

        public async Task<bool> TransfomatorPhone()
        {

            try
            {
                PublicVar.ConterString = @"در حال آماده سازی جدول رانندگان";
                var qryDriver = await db.Drivers.ToListAsync();
                var list = new List<ViewMoelTransformerTel>();
                PublicVar.MasterConter = qryDriver.Count + 10;
                PublicVar.Conter = 1;
                foreach (var item in qryDriver)
                {
                    list.Add(new ViewMoelTransformerTel
                    {
                        Fname = item.FirstName,
                        LName = item.LastName,
                        Mobile = item.PhoneNumber,
                        Jobs = "راننده",
                        DriverID_FK = item.DriverID
                    });
                    PublicVar.Conter++;
                }
                PublicVar.ConterString = @"در حال درج در دفترچه تلفن";
                PublicVar.MasterConter = list.Count + 10;
                PublicVar.Conter = 1;

                foreach (var driver in list)
                {
                    var result = await db.PhoneBooks.AnyAsync(x => x.DriverID_FK == driver.DriverID_FK);
                    if (!result)
                    {
                        var ne = new PhoneBook();
                        ne.Fname = driver.Fname;
                        ne.LName = driver.LName;
                        ne.Mobile = driver.Mobile;
                        ne.Jobs = driver.Jobs;
                        ne.DriverID_FK = (int)driver.DriverID_FK;
                        db.PhoneBooks.Add(ne);
                       var re =  await db.SaveChangesAsync();
                        //var reslt = ManageAddressBook(ne);
                        //if (!reslt) continue;
                    }
                    PublicVar.Conter++;
                }
                PublicVar.ConterString = @"در حال ذخیره سازی دفترچه تلفن";
                //await db.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                var str = e.Message;
                return false;

            }

        }
        public async Task<List<PhoneBook>> GetAllAddressBook()
        {
            return await db.PhoneBooks.ToListAsync();
        }

        public bool ManageAddressBook(PhoneBook addressBook)
        {
            try
            {


                if (addressBook.ID == 0)
                {
                    db.PhoneBooks.Add(addressBook);
                    db.SaveChanges();
                    return true;
                }
                var local = db.Set<PhoneBook>().Local.FirstOrDefault(x => x.ID == addressBook.ID);
                if (local != null) db.Entry(local).State = EntityState.Detached;
                db.Entry(addressBook).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var str = e.Message;
                return false;
            }
        }


        public void Dispose()
        {
            db?.Dispose();
        }


    }
}
