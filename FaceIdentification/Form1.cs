using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using System.Threading;
using OpenCvSharp.CPlusPlus;
using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing.Imaging;

namespace FaceIdentification
{
    public partial class Form1 : Form
    {

        
        // AFORGE
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // enumerate video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in videoDevices)
            {
                DBOX_Camera.Items.Add(item.Name);
            }
            DBOX_Camera.SelectedIndex = 0;

            

        }

        private void BTTN_Start_Click(object sender, EventArgs e)
        {
            // Create video source
            videoSource = new VideoCaptureDevice(videoDevices[DBOX_Camera.SelectedIndex].MonikerString);

            // Disable camera selection box
            DBOX_Camera.Enabled = false;

            // Start the video capture on a new thread
            var _cameraThread = new Thread(new ThreadStart(webcam));
            _cameraThread.Start();

        }

        
        private void webcam()
        {
            
            // Set NewFrame event handler
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            // Start the video source
            videoSource.Start();
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Get new frame
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            // Process the frame
            pictureBox1.Image = bitmap;
        }

        private void BTTN_Stop_Click(object sender, EventArgs e)
        {
            // Enable the camera selection box
            DBOX_Camera.Enabled = true;
            // Stop the video source
            videoSource.Stop();
        }

        private void BTTN_SnapPic_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Now.ToString("hh_mm_ss");

            pictureBox1.Image.Save(dt + ".jpg", ImageFormat.Jpeg);
        }

    }
}
