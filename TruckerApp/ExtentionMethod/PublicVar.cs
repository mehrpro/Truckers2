using System;

namespace TruckerApp
{
    public static class PublicVar
    {
        public static bool play { get; set; } 
        public static string ErrorMessageForNotSave { get;  } = "خطا در ثبت اطلاعات لطفا با مدیر سیستم تماس بگیرید";
        public static string SuccessfulSave { get;  } = "اطلاعات جدید با موفقیت ذخیره شد";
        public static string NotComplateForm { get; } = "مقادیر فرم درست وارد نشده است";
        public static byte UserID { get; set; }
        public static string FailedLogin { get; set; } = @"نام کاربری یا رمز عبور اشتباه است مجدد تلاش کنید";  
        public static string OpreatorName { get; set; }
        public static int SeriesID { get; set; }
        public static int SeriesName { get; set; }
        public static string userMode { get; set; }
        public static readonly string CameraString = @"rtsp://admin:admin@192.168.1.20/media/media.amp";
        public static int ProcessInterval { get; } = 500;
        public static DateTime DateSerial { get; set; }

        public static string Loading = "کاربر گرامی سیستم بارگذاری شد ";
        public static string unLoading = "خطا در بارگذاری سیستم لطفا با مدیرسیستم تماس بگیرید";
        public static int TempCash { get; set; }

        public static string ConterString { get; set; }
        public static int MasterConter { get; set; }
        public static int Conter { get; set; }

    }
}
