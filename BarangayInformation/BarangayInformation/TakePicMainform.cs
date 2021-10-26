using AForge.Video.DirectShow;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BarangayInformation.Class;
using AForge.Video;

namespace BarangayInformation
{
    public partial class TakePicMainform : Form
    {
        ResidentAddEditForm _frm;


        //CAMERA VARIABLES================
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] snapshotCapabilities;
        private ArrayList listCamera = new ArrayList();
        public string pathFolder = Application.StartupPath + @"\ImageCapture\";

        private Stopwatch stopWatch = null;
        private static bool needSnapshot = false;
        //CAMERA VARIABLES=======================


        public TakePicMainform(ResidentAddEditForm _frm)
        {
            InitializeComponent();
            getListCameraUSB();
            this._frm = _frm;
        }



        private static string _usbcamera;
        public string usbcamera
        {
            get { return _usbcamera; }
            set { _usbcamera = value; }
        }

        #region Open Scan Camera
        private void OpenCamera()
        {
            try
            {
                usbcamera = comboBox1.SelectedIndex.ToString();
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count != 0)
                {
                    // add all devices to combo
                    foreach (FilterInfo device in videoDevices)
                    {
                        listCamera.Add(device.Name);

                    }
                }
                else
                {
                    MessageBox.Show("Camera devices found");
                }

                videoDevice = new VideoCaptureDevice(videoDevices[Convert.ToInt32(usbcamera)].MonikerString);
                snapshotCapabilities = videoDevice.SnapshotCapabilities;
                videoDevice.VideoResolution = videoDevice.VideoCapabilities[2];

                //int a = videoDevice.VideoCapabilities.Length;
                //for (int i = 0; i < videoDevice.VideoCapabilities.Length; i++)
                //{

                //    string resolution = "Resolution Number " + Convert.ToString(i);
                //    string resolution_size = videoDevice.VideoCapabilities[i].FrameSize.ToString();

                //    Console.WriteLine("resolution , resolution_size>> " + resolution + "" + resolution_size);
                //}


                if (snapshotCapabilities.Length == 0)
                {
                    //MessageBox.Show("Camera Capture Not supported");
                }

                OpenVideoSource(videoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
        #endregion
        private void getListCameraUSB()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);

                }
            }
            else
            {
                comboBox1.Items.Add("No DirectShow devices found");
            }

            comboBox1.SelectedIndex = 0;

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            needSnapshot = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OpenVideoSource(IVideoSource source)
        {
            try
            {
                // set busy cursor
                this.Cursor = Cursors.WaitCursor;

                // stop current video source
                CloseCurrentVideoSource();

                // start new video source
                videoSourcePlayer1.VideoSource = source;

                videoSourcePlayer1.Start();

                // reset stop watch
                stopWatch = null;


                this.Cursor = Cursors.Default;
            }
            catch { }
        }

        public void CloseCurrentVideoSource()
        {
            try
            {

                if (videoSourcePlayer1.VideoSource != null)
                {
                    videoSourcePlayer1.SignalToStop();

                    // wait ~ 3 seconds
                    for (int i = 0; i < 30; i++)
                    {
                        if (!videoSourcePlayer1.IsRunning)
                            break;
                        System.Threading.Thread.Sleep(100);
                    }

                    if (videoSourcePlayer1.IsRunning)
                    {
                        videoSourcePlayer1.Stop();
                    }

                    videoSourcePlayer1.VideoSource = null;
                }
            }
            catch { }
        }

        //Delegate Untuk Capture, insert database, update ke grid 
        public delegate void CaptureSnapshotManifast(Bitmap image);
        public void UpdateCaptureSnapshotManifast(Bitmap image)
        {
            try
            {


                needSnapshot = false;
                pictureBox2.Image = image;
                pictureBox2.Update();


                //string namaImage = "sampleImage";
                //string nameCapture = namaImage + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";

                //if (Directory.Exists(pathFolder))
                //{
                //    pictureBox2.Image.Save(pathFolder + nameCapture, ImageFormat.Bmp);
                //}
                //else
                //{
                //    Directory.CreateDirectory(pathFolder);
                //    pictureBox2.Image.Save(pathFolder + nameCapture, ImageFormat.Bmp);
                //}

                // pictureBox1.ImageLocation = open.FileName.ToString();



                _frm.pictureBox1.Image = null;
                Image sourceImg = image;

                Image cloneImg = new Bitmap(sourceImg);

                // _frm.pictureBox1.ImageLocation = pathFolder + nameCapture;
                _frm.pictureBox1.Image = cloneImg;
                _frm.pictureBox1.Update();

            }

            catch (Exception er) { Box.ErrBox(er.Message); }

        }

        private Image CropImage(Image img, Rectangle rect)
        {
            return ((Bitmap)img).Clone(rect, img.PixelFormat);
        }


        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                DateTime now = DateTime.Now;
                Graphics g = Graphics.FromImage(image);

                // paint current time
                SolidBrush brush = new SolidBrush(Color.Red);
                g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
                brush.Dispose();
                if (needSnapshot)
                {
                    this.Invoke(new CaptureSnapshotManifast(UpdateCaptureSnapshotManifast), image);
                }
                g.Dispose();
            }
            catch
            { }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            OpenCamera();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CloseCurrentVideoSource();
        }
    }
}



/*
Video Resolution

Thats great Andrew.Thanks for your response.It works for me and I'm very happy for that. I gonna share my code for those you have the same problem;


_videoSource = new VideoCaptureDevice(CurrentDevice.MonikerString);

_videoSource.VideoResolution = _videoSource.VideoCapabilities[0]; //It selects the default size
int a = _videoSource.VideoCapabilities.Length;
for (int i = 0; i<_videoSource.VideoCapabilities.Length; i++)
{

string resolution = "Resolution Number " + Convert.ToString(i);
string resolution_size = _videoSource.VideoCapabilities[i].FrameSize.ToString();

Console.WriteLine("resolution , resolution_size>> " + resolution + "" + resolution_size);
}

/* The output of the function above:
resolution , resolution_size>> Resolution Number 0{Width=640, Height=480}
resolution , resolution_size>> Resolution Number 1{Width=320, Height=180}
resolution , resolution_size>> Resolution Number 2{Width=320, Height=240}
resolution , resolution_size>> Resolution Number 3{Width=424, Height=240}
resolution , resolution_size>> Resolution Number 4{Width=640, Height=360}
resolution , resolution_size>> Resolution Number 5{Width=848, Height=480}
resolution , resolution_size>> Resolution Number 6{Width=960, Height=540}
resolution , resolution_size>> Resolution Number 7{Width=1280, Height=720}
resolution , resolution_size>> Resolution Number 8{Width=1920, Height=1080}


_videoSource.NewFrame += video_NewFrame;
_videoSource.Start();


*/