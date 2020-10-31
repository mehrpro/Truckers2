﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp
{
    /// <summary>
    /// اصلاح پلاکهای ذخیره شده در بانک اطلاعاتی
    /// </summary>
    public static class PlateEditor
    {
        public static bool SaveChanage(TruckersEntities db)
        {
            try
            {
                var qry = db.Drivers.ToList();
                foreach (var plate in qry)
                {
                    var temp = plate.TagNumber.ToCharArray();
                    if (temp[3] == 'ع' && plate.Tag.Length < 5)
                    {
                        temp[3] = 'A';
                        plate.Tag = $"{temp[4]}{temp[5]}-Ain-{temp[0]}{temp[1]}{temp[2]}{plate.Tag}";
                    }
                    // var newtag = plate.Tag.Trim().ToCharArray();

                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }



    }
}
