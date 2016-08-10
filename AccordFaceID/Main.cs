using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord;

using Accord.Video;
using Accord.Video.DirectShow;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading;

namespace AccordFaceID
{
    public partial class Main : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Thread _cameraThread;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Enumerate video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            // Add each found camera to the combobox
            foreach (FilterInfo item in videoDevices)
            {
                DBOX_Camera.Items.Add(item.Name);
            }

            // Set the initial choice to the first camera
            DBOX_Camera.SelectedIndex = 0;
        }

        private void BTTN_Start_Click(object sender, EventArgs e)
        {
            // Create video source
            videoSource = new VideoCaptureDevice(videoDevices[DBOX_Camera.SelectedIndex].MonikerString);

            // Disable camera selection box
            DBOX_Camera.Enabled = false;

            // Start the video capture on a new thread
            //_cameraThread = new Thread(new ThreadStart(webcam));
            //_cameraThread.Start();
            webcam();
        }

        private void BTTN_Stop_Click(object sender, EventArgs e)
        {
            // Enable the camera selection box
            DBOX_Camera.Enabled = true;
            // Stop the video source
            videoSource.Stop();
            //_cameraThread.Abort();
            
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
    }
}
