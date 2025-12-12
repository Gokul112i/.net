using System;

namespace NotificationSystem
{
    public class Notification
    {
        public virtual void Send(string message)
        {
            Console.WriteLine($"Sending notification: {message}");
        }
    }


    public class EmailNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"Email sent to registered address: {message}");
        }
    }

    public class SmsNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"SMS sent to mobile number: {message}");
        }
    }

    public class PushNotification : Notification
    {
        public override void Send(string message)
        {
            Console.WriteLine($"Push notification delivered to device: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification notification;

            // Email notification
            notification = new EmailNotification();
            notification.Send("Your invoice is ready.");

            // SMS notification
            notification = new SmsNotification();
            notification.Send("Your OTP is 98765.");

            // Push notification
            notification = new PushNotification();
            notification.Send("You have a new friend request.");
        }
    }
}
