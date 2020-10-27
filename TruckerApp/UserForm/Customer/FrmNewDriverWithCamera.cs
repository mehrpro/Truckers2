using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static TruckerApp.ANPR_API;
using System.Drawing;
using System.Drawing.Imaging;
using TruckerApp.Properties;

namespace TruckerApp.UserForm
{
    public partial class FrmNewDriverWithCamera : XtraForm
    {

        SLPRPropertyGrid anpr_settings = new SLPRPropertyGrid();

        public int FrameW, FrameH, FrameCh, FrameStep;
        int Grabbing; //indicates whether we are grabbing or not: 0 --> not grabbing, 1 regular grabbing, 2 VLC grabbing 
        Bitmap frame; //bitmap of playing frames on picture control (in video mode)
        Bitmap frame_vehicle; //bitmap of last frame containing car (may be detected or not)
        Bitmap[] img_plate = new Bitmap[2];
        UserRect sel_rect, sel_rect2;
        Rectangle roi1, roi2;
        string _resultFarsi;//پلاک فارسی
        Graphics picg;
        double _ratio = 1.0;
        byte draw_method = 0; //{ DRAW_GDI, DRAW_OPENGL, DRAW_SDL, DRAW_NONE }; //best method is DRAW_SDL but it may differ based on PC config
        int dir_in = 0, dir_out = 0;
        SLPRParams prm = new SLPRParams();
        Pen pen_rect = new System.Drawing.Pen(System.Drawing.Color.Red, 3);
        int count_empty_frame = 0;
        float MEAN = 0;

        ANPR_EVENT_CALLBACK HandleANPREventsDelegate = null;

        [System.Runtime.InteropServices.DllImport("kernel32.dll", EntryPoint = "CopyMemory", SetLastError = false)]
        public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);


        private string _resultEn;
        //private Driver selectDriver;
        TruckersEntities db = new TruckersEntities();
        public FrmNewDriverWithCamera()
        {
            InitializeComponent();
            string security_code = "www.shahaab-co.ir 02332300204";
            anpr_create(0, security_code, 1);
            //it is not required to call anpr_set_params with default params, but if you want to change them, you must call it
            SetDefParams();
            HandleANPREventsDelegate = new ANPR_EVENT_CALLBACK(HandleAnprEvents);
            anpr_set_event_callback(HandleANPREventsDelegate);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StopEveryThing();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (txtTag.Text.CheckPlateAny(db))
                {
                    XtraMessageBox.Show("این پلاک قبلا ثبت شده است");
                }
                else if (Convert.ToInt32(txtSmartCart.Text).CheckSmartID(db))
                {
                    XtraMessageBox.Show("این شماره هوشمند قبلا ثبت شده است");
                }
                else
                {
                    var smartcart = Convert.ToInt32(txtSmartCart.Text);
                    try
                    {
                        var newDriver = new Driver();
                        newDriver.FirstName = txtFirstName.Text.Trim();
                        newDriver.LastName = txtLastNAme.Text.Trim();
                        newDriver.PhoneNumber = txtPhoneNumber.Text.Trim();
                        newDriver.userID_FK = PublicVar.UserID;
                        newDriver.Tag = txtTag.Text;
                        newDriver.TagNumber = txtTagNumber.Text;
                        newDriver.SmartCart = smartcart;
                        newDriver.driver_code = Convert.ToInt32(txtDriverCode.Text);
                        newDriver.GroupID = Convert.ToByte(radComosiun.EditValue);
                        db.Drivers.Add(newDriver);
                        db.SaveChanges();
                        XtraMessageBox.Show(PublicVar.SuccessfulSave,
                            Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();

                    }
                    catch
                    {
                        var qry = db.Drivers.SingleOrDefault(x => x.SmartCart == smartcart);
                        if (qry != null)
                        {
                            
                            string varString =
                                $"شماره هوشمند {qry.SmartCart} به نام {qry.FirstName} {qry.LastName} قبلا ثبت شده است";
                            XtraMessageBox.Show(varString,
                                "خطایی کاربری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        XtraMessageBox.Show(PublicVar.ErrorMessageForNotSave,
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                XtraMessageBox.Show(PublicVar.NotComplateForm, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear()
        {
            txtSmartCart.Text = txtFirstName.Text =
                txtLastNAme.Text = txtPhoneNumber.Text = txtTag.Text = txtTagNumber.Text = "";

        }

        private void txtSmartCart_EditValueChanged(object sender, EventArgs e)
        {
            //selectDriver = (Driver)txtSmartCart.GetSelectedDataRow();
            //if (selectDriver == null) return;
            //txtPhoneNumber.Text = selectDriver.PhoneNumber;
            //txtDriverCode.Text = selectDriver.driver_code == null ? "0" : selectDriver.driver_code.Value.ToString();
            //txtFirstName.Text = selectDriver.FirstName;
            //txtLastNAme.Text = selectDriver.LastName;
            //txtTag.Text = selectDriver.Tag;
            //txtTagNumber.Text = selectDriver.TagNumber;
            //radComosiun.EditValue = selectDriver.GroupID;
        }
        private void timer_process_Tick(object sender, EventArgs e)
        {
            if (Grabbing == 0)
                return;

            string result = new string(' ', 20);
            // string result_en = new string(' ', 20);

            float cnf = 0;
            RECT rc = new RECT();
            //process_counter++;
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
            vlpr_stop_process(0);
            //یک ثانیه وقفه به منظور اتمام گزارش پلاکهای احتمالی
            for (int i = 0; i < 100; i++)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            vlpr_stop_grabbing(0);
            vlpr_stop_grabbingVLC(0);
            timer_process.Enabled = false;
            Grabbing = 0;
            frame_vehicle = frame = null; //DONT DELETE THIS LINE. They must be set to null so that reallocate with the correct memory in vlpr_get_frame. 
            lblWH.Text = @"0x0";
            picture.Image = null;
        }
        private void SetParams()
        {
            picPlateLast.Image = null;
            Res1.Text = Res2.Text = Res3.Text = Res4.Text = lbl_result.Text = @"--";


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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer_process.Interval = Convert.ToInt32(edtProcessInterval.Text);
            timer_process.Enabled = true;
            btnPlay.Enabled = false;
            btnStop.Enabled = true;
        }

        private void ReadSettings()
        {
            //edtURL.Text = Settings.Default["LastVideoPath"].ToString();
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
                //frame_counter++;
                return;
            }
            if ((FrameW > 0) && (Grabbing > 0))
            {
                //vlpr_pause_or_resume(1); //Prevent changing frame in C++ while showing it here in C#
                var pFrame = vlpr_get_frame(0);
                if (pFrame == IntPtr.Zero)
                {
                    count_empty_frame++;
                    //vlpr_pause_or_resume(0);
                    if (count_empty_frame > 10)
                    {
                        StopEveryThing();
                    }
                    return;
                }
                //frame_counter++;
                count_empty_frame = 0;
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
                Invoke(HandleANPREventsDelegate, eventType, stream, pltIdx);
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
                             //if (!anpr_settings.repeat)
                             // frame_counter = 0;
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
                if (anpr_settings.repeat) btnPlay_Click(null, null);
            }
            else if (eventType == WM_PLATE_NOT_DETECTED)
            {
                //missed_count++;
                var pFrame = vlpr_get_frame(stream);
                if (pFrame == IntPtr.Zero)
                    return;
                if (FrameW > 0 && FrameH > 0 && FrameStep > 0)
                    frame_vehicle = new Bitmap(FrameW, FrameH, FrameStep, PixelFormat.Format24bppRgb, pFrame);
            }
        }

        private void FrmNewDriverWithCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopEveryThing();
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
            var ratio = yRatio;
            if (xRatio < yRatio)
                ratio = xRatio;

            var xOff = (int)(picture.Size.Width - ratio * w) / 2;
            var yOff = (int)(picture.Size.Height - ratio * h) / 2;

            Rectangle rc2 = new Rectangle((int)(rc.left * ratio) + xOff, (int)(rc.top * ratio) + yOff, (int)((rc.right - rc.left) * ratio), (int)((rc.bottom - rc.top) * ratio));
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
            Bitmap fullFrame = null;
            if (src == IntPtr.Zero)
            {
                if (frame != null)//in the case of video grabbing (and draw_method == NONE)
                    fullFrame = frame;
                else if (picture.Image != null)//
                    fullFrame = new Bitmap(picture.Image);//in the case of Image operations            

                if (fullFrame != null)
                {
                    dataSrc = fullFrame.LockBits(new Rectangle(rc.left, rc.top, rc.right - rc.left + 1, rc.bottom - rc.top + 1), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
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
                fullFrame.UnlockBits(dataSrc);
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
            //plate_counter++;
            _resultFarsi = "";
            txtTagNumber.Text = _resultFarsi = plate.str;
            MEAN += plate.cnf;
            _resultEn = new string(' ', 20);
            anpr_get_en_result(plate.str, _resultEn);
            txtTag.Text = lbl_result.Text = _resultEn;
            //var resultFind = _resultEn.FindByPlate(_db);
            if (_resultEn != null && plate.cnf > 0.8)
            {
                timer_process.Enabled = false;
                btnPlay.Enabled = true;
                btnStop.Enabled = false;

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

        private void UpdateFarsiResult(string lpResult)
        {
            Res1.Text = lpResult.Length > 1 ? lpResult.Substring(0, 2) : "";
            Res2.Text = lpResult.Length > 2 ? lpResult.Substring(2, Math.Min(1, lpResult.Length - 2)) : "";
            Res3.Text = lpResult.Length > 3 ? lpResult.Substring(3, Math.Min(3, lpResult.Length - 3)) : "";
            Res4.Text = lpResult.Length > 6 ? lpResult.Substring(6, lpResult.Length - 6) : "";
        }
        private void StartPlayerVlc(bool start)
        {
            picg?.Dispose();
            picg = picture.CreateGraphics();
            FrameH = 0;
            FrameW = 0;
            //Application.DoEvents();            
            if (start)
            {
                //SaveSettings();
                SetParams();
                var interval = (byte)(1000 / anpr_settings.frame_rate);
                //rtsp://admin:admin@192.168.55.160:554/h264
                string str = edtURL.Text;
                var takeShots = anpr_settings.take_shots_from_camera ? (byte)1 : (byte)0;
                draw_method = (byte)cmbDrawMethod.SelectedIndex;

                Grabbing = 2;

                if (vlpr_start_grabbingVLC(0, str, interval, picture.Handle, takeShots, draw_method) < 0)
                {
                    Grabbing = 0;
                }
                //Wait for WM_CONNECTED message
            }
            else //Its currently grabbing, stop it
            {
                StopEveryThing();
            }
        }

        private void FrmNewDriverWithCamera_Load(object sender, EventArgs e)
        {
            // driversBindingSource.DataSource = db.Drivers.ToList();
            ReadSettings();
            //cmbDrawMethod.SelectedIndex = 0;
            sel_rect = new UserRect(roi1);
            sel_rect.SetPictureBox(null);
            sel_rect2 = new UserRect(roi2);
            sel_rect2.SetPictureBox(null);
            StartPlayerVlc(true);
        }
    }
}
