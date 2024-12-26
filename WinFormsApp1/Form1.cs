using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private VideoWriter _videoWriter;
        private CascadeClassifier _faceDetector;
        private bool recording = false;
        /// <summary>
        /// CascadeClassifier _cascadeClassifier = new CascadeClassifier(@"C:\Users\User\Downloads\haarcascade_frontalface_default.xml");
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            toolStripStatusCamera.Text = "Camera disconnected";
            camRec.Text = "Recording not active";
            buttonConnect.Text = "Connect";


            try
            {
                string haarcascadePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "haarcascade_frontalface_default.xml");
                if (!File.Exists(haarcascadePath))
                {
                    throw new FileNotFoundException("model file not found", haarcascadePath);
                }
                _faceDetector = new CascadeClassifier(haarcascadePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessFrame(object? sender, EventArgs arg)
        {
            try
            {
                if (_capture != null && _capture.Ptr != IntPtr.Zero)
                {
                    var frame = new Mat();
                    _capture.Retrieve(frame);
                    var image = frame.ToImage<Bgr, byte>();

                    var grayImage = image.Convert<Gray, byte>();
                    if (_faceDetector != null)
                    {
                        var faces = _faceDetector.DetectMultiScale(grayImage, 1.1, 10, Size.Empty);

                        foreach (var face in faces)
                        {
                            image.Draw(face, new Bgr(Color.AliceBlue), 2);
                        }
                        if (faces.Length > 0)
                        {
                            var faceRect = faces[0];
                            var faceImage = grayImage.Copy(faceRect);
                            imageBoxFace.Image = faceImage.ToBitmap();
                        }
                    }
                    imageBoxLife.Image = image.ToBitmap();

                    if (recording && _videoWriter != null)
                    {
                        _videoWriter.Write(frame);
                    }
                }
            }
            catch (Exception ex)
            {
                toolStripStatusCamera.Text = "Disconnected";
                MessageBox.Show($"Error processing");
            }
        }

            

        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>

            {
                if (_capture == null)
                {
                    try
                    {
                        _capture = new VideoCapture(0);
                        _capture.ImageGrabbed += ProcessFrame;
                        _capture.Start();

                        toolStripStatusCamera.Text = "Connected";
                        buttonConnect.Text = "Disconnect";
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusCamera.Text = "Not Connected";
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    _capture.Dispose();
                    _capture = null;
                    toolStripStatusCamera.Text = "Not Connected";
                    buttonConnect.Text = "Connect";
                }
            });
        }



        private async void buttonStart_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (_capture == null)
                {
                    MessageBox.Show("Connect the camera first man");
                    return;
                }
                recording = !recording;

                if (recording)
                {
                    string filePath = $"recorded_{DateTime.Now:yyyyMMdd_HHmmss}.avi";
                    int frameWidth = _capture.Width;
                    int frameHeight = _capture.Height;
                    _videoWriter = new VideoWriter(filePath, VideoWriter.Fourcc('M', 'J', 'P', 'G'), 30, new Size(frameWidth, frameHeight), true);
                    MessageBox.Show($"Recording Started");
                }
                else
                {
                    _videoWriter?.Dispose();
                    _videoWriter = null;
                    MessageBox.Show($"Stopped");
                }

            });
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_capture != null)
            {
                _capture.Dispose();
            }

            if (_videoWriter != null)
            {
                _videoWriter.Dispose();
            }
        }

    }
}

