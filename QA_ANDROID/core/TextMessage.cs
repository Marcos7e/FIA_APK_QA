using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QA_ANDROID.core
{
    public class TextMessage
    {
        TextBlock tb = null;

        public TextMessage(TextBlock tb)
        {
            this.tb = tb;
        }

        public enum MessageType
        {
            Info = 1,
            Success = 2,
            Danger = 3,
            Hey_Listen = 4
        }
        
        public void SendMessage(string message, MessageType mtype = MessageType.Info)
        {
            switch (mtype)
            {
                case MessageType.Info:
                    WriteInfoMessage(message);
                    break;

                case MessageType.Success:
                    WriteSuccessMessage(message);
                    break;

                case MessageType.Danger:
                    WriteDangerMessage(message);
                    break;

                case MessageType.Hey_Listen:
                    WriteHeyListenMessage(message);
                    break;

                default:
                    WriteInfoMessage(message);
                    break;
            }
        }

        private void WriteInfoMessage(string message)
        {
            InfoFormat();
            if (!string.IsNullOrEmpty(message))
                this.tb.Text += $"{Environment.NewLine} {message}";
        }
        private void WriteSuccessMessage(string message)
        {
            SuccessFormat();
            if (!string.IsNullOrEmpty(message))
                this.tb.Text += $"{Environment.NewLine} {message}";
        }
        private void WriteDangerMessage(string message)
        {
            DangerFormat();
            if (!string.IsNullOrEmpty(message))
                this.tb.Text += $"{Environment.NewLine} {message}";
        }
        private void WriteHeyListenMessage(string message)
        {
            HeyListenFormat();
            if (!string.IsNullOrEmpty(message))
                this.tb.Text += $"{Environment.NewLine} {message}";
        }
        private void InfoFormat()
        {
            this.tb.Foreground = Brushes.Black;
            this.tb.FontSize = 14;
        }
        private void SuccessFormat()
        {
            this.tb.Foreground = Brushes.Green;
            this.tb.FontSize = 14;
        }
        private void DangerFormat()
        {
            this.tb.Foreground = Brushes.Red;
            this.tb.FontSize = 14;
        }
        private void HeyListenFormat()
        {
            this.tb.Foreground = Brushes.Black;
            this.tb.FontSize = 18;
            this.tb.TextAlignment = TextAlignment.Center;
            
        }


    }
}
