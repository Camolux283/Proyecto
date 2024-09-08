using System;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CamarasYRespaldosDomain
{
    public class CamarasYRespaldosClas
    {
        private VideoCaptureDevice videoSource;
        public event Action<Bitmap> NewFrameReceived;

        public void StartCamera(string cameraURL)
        {
            StopCamera();

            videoSource = new VideoCaptureDevice(cameraURL);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
        }

        public void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            NewFrameReceived?.Invoke(bitmap);
        }
    }
}