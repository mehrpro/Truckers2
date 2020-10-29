using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using TruckerApp.ViewModels.Customers;

namespace TruckerApp.Repository
{
    public interface ICustomers
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
                catch (Exception e)
                {
                    return false;
                }

            }
        }

        public async Task<List<Driver>> GetAllDriver()
        {
            return await db.Drivers.ToListAsync();
        }
    }
}
