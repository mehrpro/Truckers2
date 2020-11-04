using System;


namespace TruckerApp.ExtentionMethod
{
    public static class ExtendMethods
    {
        public static string PersianConvertor(this DateTime dateTime)
        {
            var ps = new System.Globalization.PersianCalendar();
            var ps_year = ps.GetYear(dateTime);
            var ps_month = ps.GetMonth(dateTime);
            var ps_day = ps.GetDayOfMonth(dateTime);
            return $"{ps_year}/{ps_month}/{ps_day}";
        }
        public static string PersianConvertorFull(this DateTime dateTime)
        {
            var ps = new System.Globalization.PersianCalendar();
            var ps_year = ps.GetYear(dateTime);
            var ps_month = ps.GetMonth(dateTime);
            var ps_day = ps.GetDayOfMonth(dateTime);
            return $"{ps_year}/{ps_month}/{ps_day} {dateTime.Hour}:{dateTime.Minute}";
        }

        public static string PlateConvertToFarsi(this string plate)
        {

            if (plate == "No_Set") return "__";
            // 45-Ain-91151
            var p = plate.ToCharArray();
            return $@"{p[0]}{p[1]}ع{p[7]}{p[8]}{p[9]}-{p[10]}{p[11]}";
        }
    }
}
