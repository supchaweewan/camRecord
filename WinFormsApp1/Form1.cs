using System.ComponentModel.Design;
using System.Xml.Schema;
using System;
using System.Drawing;
using System.Linq;
using System.Text;

using Emgu.CV;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private VideoCapture? _capture = null;
        private Mat? _frame;
        public Form1()
        {
            InitializeComponent();
            toolStripStatusCamera.Text = "Camera disconnected";
            camRec.Text = "Recording not active";
            buttonConnect.Enabled = false;
        }
        private void ProcessFrame(object? sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                bool canCapture = _capture.Retrieve(_frame, 0);
                if (canCapture)
                {
                    imageBoxLife.Image = _frame;

                }
            }
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            
            try
            {
                toolStripStatusCamera.Text = "Waiting";
                if (buttonConnect.Text == "Connect")
                {
                    _capture = new VideoCapture();
                    _capture.ImageGrabbed += ProcessFrame;

                    _frame = new Mat();
                    toolStripStatusCamera.Text = "Connected!";
                    buttonConnect.Text = "Disconnect";
                    buttonConnect.Enabled = true;

                }
                else if (buttonConnect.Text == "Disconnect")
                {
                    if (_capture == null)
                    {
                        _capture.Pause();
                        _capture.Dispose();

                    }
                    if (_frame == null)
                    {
                        _frame.Dispose();
                    }
                    toolStripStatusCamera.Text = "Disconnected";
                    buttonConnect.Text = "Connect";
                    buttonConnect.Enabled = false;
                }
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        private bool recording = false;
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_capture != null)
                { 
                if (!recording)
                    {
                    _capture.Start();
                    recording = true;
                    buttonConnect.Enabled = true;
                    buttonStart.Text = "Pause";
                    camRec.Text = "Recording";
                    }
                else
                    {
                    _capture.Pause();
                    recording = false;
                    buttonConnect.Enabled = true;
                    buttonStart.Text = "Record";
                    camRec.Text = "Not recording";
                    }
            
                }
                
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
