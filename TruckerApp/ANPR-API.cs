using System;
using System.Runtime.InteropServices;

namespace TruckerApp
{
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    };

    enum ESAVE_PLATE_OPTION { SAVE_NOTHING, SAVE_PLATE_ONLY, SAVE_PLATE_AND_CAR };

    public struct SLPRParams
    {
        public short resize_thresh;     // if width of input image is larger than this, it will be resized
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] num_valid_chars;   // Number of valid characters usuallay {8, 0}. if e.g. 5 character plates are also available, use {8, 5}
        //public byte num_valid_chars1;   //if Two types of plates are important
        //public byte num_valid_chars2;   //if Two types of plates are important
        public byte medianKernel;       // (0: no kernel) (3, 5, 7 ... median kernel of this size)
        public byte save_plate_option;  //save_plate_option: 0 don't save anything, 1: save plate only, 2: save whole car image and plate							
                                        //اگر عدد صفر انتخاب شود، فقط رشته پلاک و مستطیل آن گزارش شده و تصویر بریده شده پلاک ارسال نمی شود
                                        //عدد 2 سبب استفاده بیشتر از حافظه و کاهش حدود 5درصدی سرعت پلاک خوانی می شود
        public short vlc_net_cache_time;
        //Limits of character dimensions
        public byte min_char_w;  //minimum with of characters
        public byte min_char_h;  //minimum height of characters
        public byte max_char_w;  //maximum with of characters
        public byte max_char_h;  //maximum height of characters

        public float skew_coef;         //more value means more skew: successive characters are not in the same Y position

        public byte ignore_inverted_plates;//may not be used
        public byte detect_motor; //if 1 motor detection is enabled, if 0 No.

        //ب) پارامترهای ویدیو
        public byte n_frm_skip_on_success;  //Number of frames to be skipped after successful plate detection
        public byte diff_thresh;            //Difference threshold between current frame and background to suppose entrance of new car 
        public byte plate_buf_size;         // Buffer length of recent successive plates (max = 50). 
        public byte detect_multi_plate;
        public byte skip_same_plate_time;// don't report same plate until "some time" elpased

        public byte play_audio_from_camera; //in vlc mode we can play audio (from version 7.45)

        public byte plate_type; //0: Only Iran standard, 1: + Arvand, 2: + Arg 
        public byte reserved_2; //

        //internal byte horizontal_thresh;
        // از این دو پارامتر برای تعیین ناحیه پردازش استفاده میشود
        public byte min_thresh_hist;
        public byte max_thresh_hist;

        //تنظیمات پیشرفته که به ندرت نیاز است تغییر داده شود
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] blur_kernel;//{ 13, 13 }; //Size of blur kernel used for binarization. Default is 13x13. To handle shadow, try 13x1 or 13x3	
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] img_bin_th;//[2] = { 0.9f, 0.95f }; //Adaptive Binarization Threshold (between 0.5 and 1) default is [0.95, 0.9]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] plt_bin_th;//[4] = { 0.8f, 0.85f, 0.92f, 1.0f }; //Adaptive Binarization Threshold (between 0.5 and 1) default is [0.95, 0.9]
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode/*, Pack = 1*/)]
    public struct SPlateResult
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string str;
        public float cnf;
        public RECT rc;
        public IntPtr img_plate;
        public IntPtr img_car;
        public byte direction;//DIR_UNKNOWN = 0, DIR_COMMING = 1, DIR_DEPARTING = 2
        public byte n_char;//تعداد کل نویسه ها (ارقام و حروف)
        public byte n_letter;//تعداد حروف یافت شده در پلاک
        public byte count;//چند بار یک پلاک در فریمهای مختلف تکرار شده است
        public byte roi;//در کدام ناحیه مورد علاقه، این پلاک یافت شده است
    };
}
