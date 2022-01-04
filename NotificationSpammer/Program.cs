using System;
using Microsoft.Toolkit.Uwp.Notifications;

namespace SpamMoment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                new ToastContentBuilder().AddText("\u200F").Show();
            }
        }
    }
}