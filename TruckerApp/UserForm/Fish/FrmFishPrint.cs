using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using TruckerApp.ExtentionMethod;
using TruckerApp.Repository;
using TruckerApp.UserForm.cash;
using TruckerApp.ViewModels;
using static TruckerApp.AnprApi;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmFishPrint : XtraForm
    {

       // private bool jobCancel = false;
        //private readonly TruckersEntities _db = new TruckersEntities();
        private int _driver, _series;
        private int _commission;
        private short _commissionId;//حق کمیسیون
        private string _name, _number, _smartcart, _tagnumber, _type, _seriesNumber;
        //private byte TypeId;
        private byte _group;
        //private string _price;
        private string _memeber;
        private string _code;
        SLPRPropertyGrid anpr_settings = new SLPRPropertyGrid();
        //public string license_plate;
        //public string recieve;
        //public FileStream fileStream;
        //Frame width, height, number of channels and step size of the frame (usually = width x number of channels)
        public int FrameW, FrameH, FrameCh, FrameStep;
        private int _missedCount = 0;
        //private int _repeatCount = 0;
        int frame_counter = 0, process_counter = 0, plate_counter = 0;
        int Grabbing; //indicates whether we are grabbing or not: 0 --> not grabbing, 1 regular grabbing, 2 VLC grabbing 
        Bitmap frame; //bitmap of playing frames on picture control (in video mode)
        Bitmap frame_vehicle; //bitmap of last frame containing car (may be detected or not)
        Bitmap[] img_plate = new Bitmap[2];
        UserRect sel_rect, sel_rect2;
        Rectangle roi1, roi2;
        string _resultFarsi;//پلاک فارسی
        Graphics picg;
        // double _ratio = 1.0;
        byte draw_method = 0; //{ DRAW_GDI, DRAW_OPENGL, DRAW_SDL, DRAW_NONE }; //best method is DRAW_SDL but it may differ based on PC config
                              // int dir_in = 0, dir_out = 0;
        SLPRParams prm = new SLPRParams();
        // PictureBox[] picPlate = new PictureBox[5];
        Pen pen_rect = new Pen(Color.Red, 3);
        // Open App.Config of executable
        // Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        // System.Diagnostics.Stopwatch _sw = new System.Diagnostics.Stopwatch();
        int _countEmptyFrame = 0;
        float MEAN = 0;

        private ANPR_EVENT_CALLBACK _handleAnprEventsDelegate = null;

        [System.Runtime.InteropServices.DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);

        // string[] dir_strings = new string[3] { "", "IN", "OUT" };
        private string _resultEn;

        private readonly IQueuing _queuing;
        private readonly IAdministrator _administrator;
        private Driver _resultFindingDriver;

        public FrmFishPrint(IQueuing queuing, IAdministrator administrator)
        {
            InitializeComponent();
            _queuing = queuing;
            _administrator = administrator;

            CamSetup();
            PublicVar.play = false;
            btnSelectPlate.Enabled = false;
            chkMandeh.EditValue = false;
            chkMandeh.EditValue = false;
        }
        private void CamSetup()
        {
            try
            {
                string security_code = "www.shahaab-co.ir 02332300204";
                anpr_create(0, security_code, 1);
                //it is not required to call anpr_set_params with default params, but if you want to change them, you must call it
                SetDefParams();
                _handleAnprEventsDelegate = new ANPR_EVENT_CALLBACK(HandleAnprEvents);
                anpr_set_event_callback(_handleAnprEventsDelegate);
            }
            catch (Exception e)
            {
                var str = e.Message;
                //MessageBox.Show("Error Load Form");
                this.Close();
            }

        }

        private void ReadSettings()
        {
            var x = 10;
            var y = picture.Size.Height * 2 / 10;
            roi2 = roi1 = new Rectangle(x, y, picture.Size.Width / 2 - 20, 6 * picture.Size.Height / 10);
            roi2.X = picture.Size.Width / 2 + 10;
        }
        private void UpdateFrame()
        {
            if (draw_method != 3)
            {
                //در حالتهای 0 تا 2، فریمها توسط کتابخانه ترسیم می شود
                //لذا اینجا فقط شمارنده فریم را به روز رسانی می کنیم
                frame_counter++;
                return;
            }
            if ((FrameW > 0) && (Grabbing > 0))
            {
                //vlpr_pause_or_resume(1); //Prevent changing frame in C++ while showing it here in C#
                var pFrame = vlpr_get_frame(0);
                if (pFrame == IntPtr.Zero)
                {
                    _countEmptyFrame++;
                    //vlpr_pause_or_resume(0);
                    if (_countEmptyFrame > 10)
                    {
                        StopEveryThing();
                    }
                    return;
                }
                frame_counter++;
                _countEmptyFrame = 0;
                if (frame == null)
                {
                    frame = new Bitmap(FrameW, FrameH, FrameStep, PixelFormat.Format24bppRgb, pFrame);
                    picture.Image = frame;
                }
                //vlpr_pause_or_resume(0);//Resume changing frame;
                picture.Invalidate();
            }
        }

        private void HandleAnprEvents(int eventType, byte stream, byte pltIdx)
        {
            //چون این تابع از تردی غیر از ترد رابط کاربری فراخوانی می شود 
            //باید قطعه کد زیر را استفاده کنیم
            if (InvokeRequired)
            {
                //if (jobCancel)
                   // System.Threading.Thread.CurrentThread.Abort();
                Invoke(_handleAnprEventsDelegate, eventType, stream, pltIdx);
                return;
            }
            if (eventType == WM_CONNECTED)
            {
                vlpr_get_frame_info(0, ref FrameW, ref FrameH, ref FrameCh, ref FrameStep);
                if (FrameW < 1)
                {
                    Grabbing = 0;
                    MessageBox.Show(@"ارتباط با دوربین به درستی برقرار نشده، دوباره تلاش کنید");
                    return;
                }
                lblWH.Text = $@"{FrameW}x{FrameH}";
                frame = null;// new Bitmap(FrameW, FrameH, PixelFormat.Format24bppRgb);
                if (!anpr_settings.repeat)
                    frame_counter = 0;
            }
            else if (eventType == WM_CAM_NOT_FOUND)
            {
                Grabbing = 0;
                MessageBox.Show(@"ارتباط با فایل یا دوربین برقرار نشد. آدرس را بررسی کرده و اگر نام کاربری و رمز می خواهد آنها را بازبینی کنید.",
                    "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else if (eventType == WM_NEW_FRAME)//New Frame Captured
            {
                UpdateFrame();
            }
            else if (eventType == WM_PLATE_DETECTED)//plate detected
            {
                UpdateResults(pltIdx); //plt_idx = index of the plate
            }
            else if (eventType == WM_INITIAL_PLATE)//possible plate detected
            {
                //if (plt_count > 1)
                // vlpr_pause_or_resume(0, 1);
                var plate = new SPlateResult();
                for (byte i = 0; i < pltIdx; i++) //plt_idx = number of plates
                {
                    anpr_get_plate(0, i, ref plate);
                    DrawRect(plate.rc);
                }
            }

            else if (eventType == WM_END_OF_VIDEO)
            {
                //int grab = Grabbing;
                if (Grabbing > 0)
                    StopEveryThing();
                if (anpr_settings.repeat) btnRefreshPlayer_Click(null, null);
            }
            else if (eventType == WM_PLATE_NOT_DETECTED)
            {
                _missedCount++;
                var pFrame = vlpr_get_frame(stream);
                if (pFrame == IntPtr.Zero)
                    return;
                if (FrameW > 0 && FrameH > 0 && FrameStep > 0)
                    frame_vehicle = new Bitmap(FrameW, FrameH, FrameStep, PixelFormat.Format24bppRgb, pFrame);
            }
        }
        private void DrawRect(RECT rc)
        {
            //if (direct_play == 1)
            //  return;
            var g = picg ?? picture.CreateGraphics();
            float w = FrameW;
            float h = FrameH;
            if (picture.Image != null)
            {
                w = (float)picture.Image.Width;
                h = (float)picture.Image.Height;
            }
            var xRatio = (float)picture.Size.Width / w;
            var yRatio = (float)picture.Size.Height / h;
            var Ratio = yRatio;
            if (xRatio < yRatio)
                Ratio = xRatio;

            var xOff = (int)(picture.Size.Width - Ratio * w) / 2;
            var yOff = (int)(picture.Size.Height - Ratio * h) / 2;

            Rectangle rc2 = new Rectangle((int)(rc.left * Ratio) + xOff, (int)(rc.top * Ratio) + yOff, (int)((rc.right - rc.left) * Ratio), (int)((rc.bottom - rc.top) * Ratio));
            //Rectangle rc2 = new Rectangle(100, 100, 200, 100);

            g.DrawRectangle(pen_rect, rc2);
            //pen_rect.Dispose();
            //g.Dispose();            
        }
        private void DrawPlate(byte roi, RECT rc, IntPtr pBuf = default(IntPtr))
        {
            if (rc.right - rc.left < 10)
                return;
            img_plate[roi] = new Bitmap(rc.right - rc.left, rc.bottom - rc.top, PixelFormat.Format24bppRgb);

            if (img_plate[roi] == null)
                return;
            BitmapData dataDst = img_plate[roi].LockBits(new Rectangle(0, 0, img_plate[roi].Width, img_plate[roi].Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            IntPtr dst = dataDst.Scan0;
            IntPtr src = pBuf;
            int step = 3 * img_plate[roi].Width;
            BitmapData dataSrc = null;
            Bitmap full_frame = null;
            if (src == IntPtr.Zero)
            {
                if (frame != null)//in the case of video grabbing (and draw_method == NONE)
                    full_frame = frame;
                else if (picture.Image != null)//
                    full_frame = new Bitmap(picture.Image);//in the case of Image operations            

                if (full_frame != null)
                {
                    dataSrc = full_frame.LockBits(new Rectangle(rc.left, rc.top, rc.right - rc.left + 1, rc.bottom - rc.top + 1), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    src = dataSrc.Scan0;
                    step = dataSrc.Stride;
                }
                else
                {
                    step = FrameStep;
                    src = vlpr_get_frame(0) + rc.top * step + rc.left * FrameCh;
                }
            }
            for (int y = 0; y < img_plate[roi].Height; y++)
            {
                CopyMemory(dst, src, (uint)img_plate[roi].Width * 3);
                src += step;
                dst += dataDst.Stride;
            }
            if (dataSrc != null)
                full_frame.UnlockBits(dataSrc);
            img_plate[roi].UnlockBits(dataDst);
            picPlateLast.Image = img_plate[roi];
        }


        private void UpdateResults(byte plt_idx)
        {
            var plate = new SPlateResult();
            anpr_get_plate(0, plt_idx, ref plate);
            if ((plate.str.Length < 3) || (plt_idx > 4))
            {
                MessageBox.Show(@"Invalid Plate: " + plate.str);
                return;
            }
            if (!anpr_settings.report_non_standard_plates && (Grabbing != 0))
            {
                if (plate.n_letter > 1)//پلاک استاندارد حداکثر یک حرف دارد و بقیه رقم هستند
                    return;

                if (anpr_settings.num_valid_chars[1] > 0)
                {
                    if ((plate.n_char != anpr_settings.num_valid_chars[0]) && (plate.n_char != anpr_settings.num_valid_chars[1]))
                        return;
                }
                else if (plate.n_char != anpr_settings.num_valid_chars[0])
                    return;
            }
            plate_counter++;
            _resultFarsi = "";
            txtTagNumber.Text = _resultFarsi = plate.str;
            MEAN += plate.cnf;
            _resultEn = new string(' ', 20);
            anpr_get_en_result(plate.str, _resultEn);
            txtTag.Text = _resultEn;
            _resultFindingDriver = _queuing.FindByPlate(_resultEn);// _resultEn.FindByPlate();
            if (_resultFindingDriver != null)
            {
                GetPropertyByDriver(_resultFindingDriver);
            }
            UpdateFarsiResult(_resultFarsi);
            for (var i = 19; i > 0; i--)
                if (_resultEn[i] == 0)
                {
                    _resultEn = _resultEn.Substring(0, i);
                    break;
                }
            DrawPlate(plate.roi, plate.rc, plate.img_plate);
            DrawRect(plate.rc);
            frame_vehicle = new Bitmap(FrameW, FrameH, FrameStep, PixelFormat.Format24bppRgb, plate.img_car);
            var g = Graphics.FromImage(frame_vehicle);
            var rc2 = new Rectangle(plate.rc.left, plate.rc.top, plate.rc.right - plate.rc.left, plate.rc.bottom - plate.rc.top);
            g.DrawRectangle(pen_rect, rc2);
        }
        //9368435699
        private void UpdateFarsiResult(string LPResult)
        {
            Res1.Text = LPResult.Length > 1 ? LPResult.Substring(0, 2) : "";
            Res2.Text = LPResult.Length > 2 ? LPResult.Substring(2, Math.Min(1, LPResult.Length - 2)) : "";
            Res3.Text = LPResult.Length > 3 ? LPResult.Substring(3, Math.Min(3, LPResult.Length - 3)) : "";
            Res4.Text = LPResult.Length > 6 ? LPResult.Substring(6, LPResult.Length - 6) : "";
        }

        private void FrmFishPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            //StopEveryThing();

            // this.Hide();
            //this.Parent = null;
            //e.Cancel = true;
        }

        private void ChangeTypeId(byte TypeId)
        {
            switch (TypeId)
            {
                case 1:
                    _type = "فله";
                    break;
                case 2:
                    _type = "پاکت";
                    break;
                case 3:
                    _type = "گندم";
                    break;
                case 4:
                    _type = "کلینکر";
                    break;
                case 5:
                    _type = "آهک فله";
                    break;
                case 6:
                    _type = "آهک پاکت";
                    break;
                case 7:
                    _type = "سایر";
                    break;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

            //StartPlayerVLC(false);
            ////StopEveryThing();
            //Thread.Sleep(1500);
            Close();
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {

            if (!PublicVar.play)
            {
                StartPlayerVLC(true);
                PublicVar.play = true;
                btnPlayVideo.Visible = false;
                btnPuse.Visible = true;
                btnSelectPlate.Enabled = true;
                btnClose.Enabled = false;
            }
            else
            {
                StartPlayerVLC(false);
                PublicVar.play = false;
                btnPlayVideo.Visible = true;
                btnPuse.Visible = false;
                btnSelectPlate.Enabled = false;
                btnClose.Enabled = true;
            }
        }

        private async void cbxCargoType_EditValueChanged(object sender, EventArgs e)
        {
            var selectType = (ViewModelCargoType)cbxCargoType.GetSelectedDataRow();
            if (selectType == null || txtTag.Text.Trim() == "")
            {
                txtComossin.EditValue = 0;
                txtDateRegister.EditValue = DateTime.Now.PersianConvertor();
                txtHosmand.EditValue = null;
                txtName.EditValue = null;
                txtNumber.EditValue = null;
                txtPhoneNumber.EditValue = null;
                txtTag.EditValue = txtTagNumber.EditValue = null;
                chkMandeh.EditValue = false;

                return;
            }

            ChangeTypeId(selectType.TypeID);
            txtNumber.EditValue = await _queuing.GetLastNumberByTypeId(selectType.TypeID);
            var com = await _queuing.GetCommisinoByTypeIdAndByGroupId(selectType.TypeID, _group);
            txtComossin.EditValue = _commission = com.CommissionPrice;
            _commissionId = com.CommissionID;

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //    var str = "49-Ain-25451";
            //    var re = _queuing.FindByPlate(str);

            //    GetPropertyByDriver(re);
            timer_process.Enabled = false;

            StopEveryThing();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer_process.Enabled = false;
            btnSelectPlate.Enabled = true;
            btnStop.Enabled = false;
        }

        private async void groupControl1_DoubleClick(object sender, EventArgs e)
        {
            _resultFindingDriver = await _administrator.RandomDriver();
           GetPropertyByDriver(_resultFindingDriver);
            
        }



        private void StartPlayerVLC(bool start)
        {
            picg?.Dispose();
            picg = picture.CreateGraphics();
            FrameH = 0;
            FrameW = 0;
            //Application.DoEvents();            
            if (start)
            {

                SetParams();
                var interval = (byte)(1000 / anpr_settings.frame_rate);
                //rtsp://admin:admin@192.168.55.160:554/h264
                string str = PublicVar.CameraString;
                var takeShots = anpr_settings.take_shots_from_camera ? (byte)1 : (byte)0;
                draw_method = 0;// (byte)cmbDrawMethod.SelectedIndex;

                Grabbing = 2;

                if (vlpr_start_grabbingVLC(0, str, interval, picture.Handle, takeShots, draw_method) < 0)
                {
                    Grabbing = 0;
                    return;
                }
                //Wait for WM_CONNECTED message
            }
            else //Its currently grabbing, stop it
            {
                StopEveryThing();
            }
        }
        private void setupPage()
        {
            txtserial.Text = PublicVar.SeriesName.ToString();
            _series = PublicVar.SeriesID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            StopEveryThing();
            //Environment.Exit(0);
            //Close();
        }
        private void btnRefreshPlayer_Click(object sender, EventArgs e)
        {
            timer_process.Interval = PublicVar.ProcessInterval;// Convert.ToInt32(edtProcessInterval.Text);
            timer_process.Enabled = true;
            btnSelectPlate.Enabled = false;
            btnStop.Enabled = true;
        }
        private void timer_process_Tick(object sender, EventArgs e)
        {
            if (Grabbing == 0)
                return;

            string result = new string(' ', 20);
            // string result_en = new string(' ', 20);

            float cnf = 0;
            RECT rc = new RECT();
            process_counter++;
            vlpr_recognize_cur_frame(0, result, ref rc, ref cnf);
            if (cnf < 0.2 || result[0] == 0)
            {
                return;
            }
            UpdateResults(0);
            IntPtr pFrame = vlpr_get_frame(0);
            if (pFrame == IntPtr.Zero)
            {
                return;
            }
            if (FrameW > 0 && FrameH > 0 && FrameStep > 0)
            {
                frame_vehicle = new Bitmap(FrameW, FrameH, FrameStep, PixelFormat.Format24bppRgb, pFrame);
            }

        }
        private void StopEveryThing()
        {
            if (!PublicVar.play)
            {
                return;
            }
            vlpr_stop_process(0);
            //یک ثانیه وقفه به منظور اتمام گزارش پلاکهای احتمالی
            for (int i = 0; i < 10; i++)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
            vlpr_stop_grabbing(0);
            vlpr_stop_grabbingVLC(0);
            timer_process.Enabled = false;
            Grabbing = 0;
            frame_vehicle = frame = null; //DONT DELETE THIS LINE. They must be set to null so that reallocate with the correct memory in vlpr_get_frame. 
            lblWH.Text = "0x0";
            picture.Image = null;
        }
        private void SetParams()
        {
            picPlateLast.Image = null;
            Res1.Text = Res2.Text = Res3.Text = Res4.Text = @"--";


            prm.plate_buf_size = anpr_settings.plate_buf_size;
            prm.num_valid_chars = anpr_settings.num_valid_chars;
            prm.detect_motor = anpr_settings.detect_motor ? (byte)1 : (byte)0;
            prm.detect_multi_plate = anpr_settings.detect_multi_plate ? (byte)1 : (byte)0;

            prm.diff_thresh = anpr_settings.diff_thresh;
            prm.n_frm_skip_on_success = anpr_settings.n_frm_skip_on_success;
            prm.resize_thresh = anpr_settings.resize_thresh;
            prm.save_plate_option = 0;
            prm.skip_same_plate_time = 20; //اگر پلاکی بعد از 60 ثانیه دوباره جلوی دوربین قرار گیرد، گزارش خواهد شد

            prm.min_char_w = anpr_settings.min_char_w;
            prm.max_char_w = anpr_settings.max_char_w;
            prm.min_char_h = anpr_settings.min_char_h;
            prm.max_char_h = anpr_settings.max_char_w;
            prm.skew_coef = anpr_settings.skew_coef;

            prm.vlc_net_cache_time = anpr_settings.vlc_net_cache_time;
            prm.plate_type = anpr_settings.plate_type;
            prm.reserved_2 = anpr_settings.reserved_2 ? (byte)1 : (byte)0;

            prm.ignore_inverted_plates = anpr_settings.ignore_inverted_plates ? (byte)1 : (byte)0;
            prm.medianKernel = anpr_settings.medianKernel;

            prm.play_audio_from_camera = anpr_settings.play_audio_from_camera ? (byte)1 : (byte)0;

            prm.min_thresh_hist = anpr_settings.min_thresh_hist;
            prm.max_thresh_hist = anpr_settings.max_thresh_hist;

            prm.blur_kernel = anpr_settings.blur_kernel;
            prm.img_bin_th = anpr_settings.img_bin_th;
            prm.plt_bin_th = anpr_settings.plt_bin_th;

            anpr_set_params(0, ref prm);

            anpr_set_debug_mode(0, anpr_settings.debug_level);
            //SetROI();
        }
        private void PrintFish()
        {
            var report = XtraReport.FromFile("Report_Fish.repx", true);
            var tool = new ReportPrintTool(report);
            report.Parameters["date"].Value = DateTime.Now.PersianConvertorFull();
            report.Parameters["name"].Value = _name;
            report.Parameters["seriesNumber"].Value = _seriesNumber;
            report.Parameters["smartcart"].Value = _smartcart;
            report.Parameters["TagNumbers"].Value = _tagnumber;
            report.Parameters["member"].Value = _memeber;
            report.Parameters["price"].Value = _commission;
            report.Parameters["Type"].Value = _type;
            report.Parameters["code"].Value = _code;
            report.Parameters["number"].Value = _number;
            tool.PrintDialog();
        }
        private void ClearForm()
        {
            txtDateRegister.Text = DateTime.Now.PersianConvertor();
            cbxCargoType.EditValue = 0;
            txtHosmand.ResetText();
            txtName.ResetText();
            txtTag.ResetText();
            txtTagNumber.ResetText();
            txtPhoneNumber.ResetText();
            txtComossin.ResetText();
            _driver = _commission = 0;
            _code = _name = _seriesNumber = _smartcart = _tagnumber = _memeber = _type = null;
        }


        private void GetPropertyByDriver(Driver driver)
        {
            //var driver = (Driver)cbxSmart.GetSelectedDataRow();
            if (driver == null) return;
            _code = Convert.ToInt32(driver.driver_code) > 0 ? driver.driver_code.ToString() : " ";
            txtName.Text = _name = $"{driver.FirstName}  {driver.LastName}";
            txtTag.Text = driver.Tag;
            txtTagNumber.Text = _tagnumber = _resultFarsi;
            txtPhoneNumber.Text = driver.PhoneNumber;
            _driver = driver.DriverID;
            _smartcart = txtHosmand.Text = driver.SmartCart.ToString();
            _group = driver.GroupID;
            _memeber = driver.LoadType.Type;
            timer_process.Enabled = false;
            btnSelectPlate.Enabled = true;
            btnStop.Enabled = false;
        }

        private void Clear()
        {
            cbxCargoType.EditValue = 0;
            txtComossin.EditValue = 0;
            txtDateRegister.EditValue = DateTime.Now.PersianConvertor();

        }
        private async void FrmFishPrint_Load(object sender, EventArgs e)
        {
            cbxCargoType.Properties.DataSource = await _queuing.GetAllCargoType();
            ReadSettings();
            sel_rect = new UserRect(roi1);
            sel_rect.SetPictureBox(null);
            sel_rect2 = new UserRect(roi2);
            sel_rect2.SetPictureBox(null);
            setupPage();
            txtDateRegister.Text = DateTime.Now.PersianConvertor();
            // SelectType();
            // StartPlayerVLC(true);
            // StopEveryThing();
        }


        private async void btnPrint_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                XtraMessageBox.Show(PublicVar.NotComplateForm, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_driver < 1)
                {
                    XtraMessageBox.Show("هیچ راننده ای انتخاب نشده است", Text, MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {

                    var driverCheck = await _queuing.FindByQueue(_resultFindingDriver.DriverID); //عدم ثبت مجدد نوبت
                    if (driverCheck == null)
                    {
                        // مجاز به ثبت نوبت است
                        var newQueue = new ViewModelQueue()
                        {
                            DriverIdFk = _driver,
                            ComosiunIdFk = _commissionId,
                            TypeFk = Convert.ToByte(cbxCargoType.EditValue),
                            DateTimeRegister = DateTime.Now,
                            SeriesIdFk = PublicVar.SeriesID,
                            Number = Convert.ToInt16(txtNumber.EditValue),
                            GroupCommission = _group,
                            StatusFk = 20,
                            Mandeh = chkMandeh.Checked,

                        };
                        PublicVar.TempCash = Convert.ToInt32(txtComossin.Text);
                        var frm = new FrmCash();
                        var dialogResult = frm.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                        {
                            var result = _queuing.RegisterNewQueue(newQueue, frm.ModelCash);
                            if (result)
                            {
                                _seriesNumber = $"س {PublicVar.SeriesName}  شماره {Convert.ToInt16(txtNumber.EditValue)}";
                                _number = await _queuing.GetScheduleByTypeId(newQueue.TypeFk);
                                PrintFish();
                                await _queuing.GetLastNumberByTypeId(Convert.ToByte(cbxCargoType.EditValue));
                                cbxCargoType.EditValue = null;
                            }
                            else
                            {
                                XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave, Text, MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                cbxCargoType.EditValue = null;

                            }
                        }
                    }
                    else
                    {
                        var str =
                            $"برای شماره هوشمند {driverCheck.Driver.SmartCart} نوبت محموله {driverCheck.LoadType.Type} در تاریخ {driverCheck.DateTimeRegister.PersianConvertor()} ثبت شده است";
                        XtraMessageBox.Show(str, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }




    }
}
