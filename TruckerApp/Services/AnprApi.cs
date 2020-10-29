using System;
using System.Runtime.InteropServices;

namespace TruckerApp
{
    public static class AnprApi
    {
        public delegate void ANPR_EVENT_CALLBACK(int event_type, byte stream, byte plt_idx);

        public const string DLL_NAME = "ANPR.dll";
        public const int WM_USER = 0x0400;
        public const int WM_NEW_FRAME = WM_USER + 100;
        public const int WM_SCENE_CHANGED = WM_USER + 101;
        public const int WM_PLATE_DETECTED = WM_USER + 102;
        public const int WM_PLATE_NOT_DETECTED = WM_USER + 103; //when a car is in the field of camera but its plate is not recognized
        public const int WM_END_OF_VIDEO = WM_USER + 104; //when video file finished or camera closed
        public const int WM_CONNECTED = WM_USER + 105; //Connected to camera (or video file) from Ver 8.43

        //هنگامی که اولین پلاک در صحنه دیده می شود، برای ترسیم مستطیل اطراف آن
        //رویداد تشخیص قطعی پلاک شماره 102 است
        public const int WM_INITIAL_PLATE = WM_USER + 108;
        public const int WM_CAM_NOT_FOUND = WM_USER + 109;

        //1
        //تابع زیر به ازای هر نسخه کتابخانه (مثلا به ازای هر دوربین) حتما باید یکبار فراخوانی شود. 
        //این تابع شبکه های عصبی مورد استفاده را بارگذاری می کند
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short anpr_create(byte instance, [MarshalAs(UnmanagedType.LPWStr)] string security_code, byte log_level = 1, [MarshalAs(UnmanagedType.LPWStr)] string cfg_file = null);

        //1-1
        //این تابع مدیریت تمام رویدادهای کتابخانه را بر عهده دارد
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short anpr_set_event_callback(ANPR_EVENT_CALLBACK callback_fcn);

        //2
        //این تابع مسیر فایل تصویری را دریافت کرده و نتیجه را بر می گرداند: 
        //رشته، میزان اطمینان به رشته حاصله و مستطیل پلاک
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short anpr_recognize(byte instance, [MarshalAs(UnmanagedType.LPWStr)] string fn,
            [MarshalAs(UnmanagedType.LPWStr)] string result, ref float cnf, ref RECT prc);

        //3
        //این تابع مانند تابع بالایی است با این تفاوت که اندیس مستطیل مورد علاقه را هم می گیرد.
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short anpr_recognizeROI(byte instance, byte roi_idx, [MarshalAs(UnmanagedType.LPWStr)] string fn,
            [MarshalAs(UnmanagedType.LPWStr)] string result, ref float cnf, ref RECT prc);


        //4
        //تابع زیر برای بافری است که از دوربین یا فایل گرفته اید و نوعا یک جریان فشرده مثل جی پگ است.
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short anpr_recognize_stream(byte instance, IntPtr compressed_stream, int size, [MarshalAs(UnmanagedType.LPWStr)] string result, ref float cnf, ref RECT prc);

        //5
        //تابع زیر برای زمانی است که بایتهای تصویر به صورت فشرده نشده در آرایه ای قرار دارند
        //مثلا اشاره گر ابتدای یک بیت مپ
        //مثال آن در همین برنامه دیده می شود
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short anpr_recognize_buffer(byte instance, IntPtr bytes, int W, int H, int step, [MarshalAs(UnmanagedType.LPWStr)] string result, ref float cnf, ref RECT prc);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short anpr_recognize_bufferROI(byte instance, byte roi_idx, IntPtr bytes, int W, int H, int step, [MarshalAs(UnmanagedType.LPWStr)] string result, ref float cnf, ref RECT prc);

        //6
        //خروجی تابع 2 یک رشته فارسی یونیکد است، اگر خروجی انگلیسی «اسکی» را لازم دارید از این تابع استفاده کنید 
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern void anpr_get_ascii_result([MarshalAs(UnmanagedType.LPWStr)] string result_fa, [MarshalAs(UnmanagedType.LPStr)] string result_en);//Get ascii results in English

        //7
        //خروجی تابع 2 یک رشته فارسی یونیکد است، اگر خروجی انگلیسی «یونیکد» را لازم دارید از این تابع استفاده کنید 
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern void anpr_get_en_result([MarshalAs(UnmanagedType.LPWStr)] string result_fa, [MarshalAs(UnmanagedType.LPWStr)] string result_en);//Get unicode results in English

        //8
        //یافتن نویسه ها از بافر حافظه ای که تنها شامل تصویر پلاک است
        //به عبارتی محل پلاک باید قبلا یافت شده باشد
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern void anpr_find_chars(byte instance, IntPtr bytes, int W, int H, int step, RECT roi, [MarshalAs(UnmanagedType.LPWStr)] string result, ref float pcnf);

        //9
        //این تابع برای تنظیم پارامترهای کتابخانه است.
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern void anpr_set_params(byte instance, ref SLPRParams slpr_params);

        //این تابع برای تست برخی پارامترهای کتابخانه است و حتی الامکان نباید استفاده شود.
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern void anpr_set_debug_mode(byte instance, byte debug_level);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern void anpr_add_ROI(byte instance, RECT roi);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern void anpr_clear_ROIs(byte instance);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short anpr_get_plate(byte instance, byte plate_idx, ref SPlateResult result);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern void anpr_about(ref byte instance, ref byte used);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_start_grabbing(byte instance, [MarshalAs(UnmanagedType.LPStr)] string URL, byte interval_ms, IntPtr hwndDraw, byte take_shots, byte draw_method);
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_stop_grabbing(byte instance);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_start_grabbingVLC(byte instance, [MarshalAs(UnmanagedType.LPStr)] string URL, byte interval_ms, IntPtr hwndDraw, byte take_shots, byte draw_method);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_stop_grabbingVLC(byte instance);


        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_pause_or_resume(byte instance, byte pause);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_get_frame_info(byte instance, ref int W, ref int H, ref int channels, ref int step);

        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern IntPtr vlpr_get_frame(byte instance);

        //Start Processing of Camera Frames
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_start_process(byte instance);

        //Stop Processing of Camera Frames
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_stop_process(byte instance);

        //str must be allocated before
        //output is buffer of plate image
        //پلاک پس از عبور خودرو گزارش می شود. لذا به منظور ثبت تصویر پلاک
        //بافر آن نگهداری می شود
        [Obsolete("vlpr_get_last_resultsW is deprecated, please use anpr_get_plate instead.")]
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern IntPtr vlpr_get_last_resultsW(byte stream, [MarshalAs(UnmanagedType.LPWStr)] string str, ref RECT pr, ref float cnf, ref IntPtr img_car_buffer, ref byte direction);

        [Obsolete("vlpr_get_last_results is deprecated, please use anpr_get_plate instead.")]
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern IntPtr vlpr_get_last_results(byte stream, byte[] str, ref RECT pr, ref float cnf, ref IntPtr img_car_buffer, ref byte direction);

        //Recognize Last Frame Grabbed from camera or video file
        [System.Runtime.InteropServices.DllImport(DLL_NAME)]
        public static extern short vlpr_recognize_cur_frame(byte instance, [MarshalAs(UnmanagedType.LPWStr)] string str, ref RECT pr, ref float cnf);

        public static void SetDefParams(byte instance = 0)
        {
            SLPRParams prm = new SLPRParams();
            prm.min_char_w = 5; //minimum with of characters
            prm.min_char_h = 7; //minimum height of characters
            prm.max_char_w = 100; //maximum with of characters
            prm.max_char_h = 100; //maximum height of characters
            prm.skew_coef = 1.0f; //more value means more skew: successive characters are not in the same Y position
            prm.resize_thresh = 1100;//if width of input image is larger than this, it will be resized
            prm.medianKernel = 0;//Kernel size: 0, 3, 5, 7, etc...
            prm.ignore_inverted_plates = 0;
            prm.detect_motor = 0; //if 1 motor detection is enabled, if 0 No.
            prm.detect_multi_plate = 0;
            prm.num_valid_chars = new byte[2] { 8, 0};
            //prm.num_valid_chars1 = 8; //5 for free 
            //prm.num_valid_chars2 = 0; //5 for free //mhh - changed 5 to 0

            prm.save_plate_option = (byte)ESAVE_PLATE_OPTION.SAVE_PLATE_AND_CAR;
            prm.n_frm_skip_on_success = 10;
            prm.plate_buf_size = 12;
            prm.reserved_2 = 0; // car recognition is disabled
            prm.vlc_net_cache_time = 1000;
            prm.plate_type = 0;
            prm.diff_thresh = 15; //difference threshold between current frame and background to suppose entrance of new car 
            prm.play_audio_from_camera = 0;
            prm.min_thresh_hist = 60;
            prm.max_thresh_hist = 170;

            prm.blur_kernel = new byte[2] { 13, 13 };
            prm.img_bin_th = new float[2] { 0.9f, 0.95f };
            prm.plt_bin_th = new float[4] { 0.8f, 0.85f, 0.92f, 1.0f };
            anpr_set_params(instance, ref prm);
        }
        
    }
}