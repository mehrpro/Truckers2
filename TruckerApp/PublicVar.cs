using System;

namespace TruckerApp
{
    public static class PublicVar
    {
        public static string ErrorMessageForNotSave { get; set; } = "خطا در ثبت اطلاعات لطفا با مدیر سیستم تماس بگیرید";
        public static string SuccessfulSave { get; set; } = "اطلاعات جدید با موفقیت ذخیره شد";
        public static string NotComplateForm { get; } = "مقادیر فرم درست وارد نشده است";
        public static byte UserID { get; set; }
        public static bool Accsept { get; set; }
        public static string OpName { get; set; }
        public static int SeriesID { get; set; }
        public static int SeriesName { get; set; }
        public static string userMode { get; set; }

        public static string cameraString = @"rtsp://admin:admin@192.168.1.20/media/media.amp";
        public static DateTime DateSerial { get; set; }
    }
}
