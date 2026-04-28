using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using SampleCRUD.Models;

namespace SampleCRUD
{
    public class NewsletterSystem
    {

        private List<Subscriber> subscribers = new List<Subscriber>();

        public void Subscribers( Subscriber subscriber)
        {
           subscribers.Add(subscriber);
        }

        public void Unsubscribers(String email)
        {
            subscribers.RemoveAll(s=>s.EmailAddress==email);

        }

        public void SendNewsLetter(Message message)
        {
            foreach (var sub in subscribers)

            {
                if (message.MinimumAge == null || sub.Age >= message.MinimumAge)
                {
                    SendEmail(sub.EmailAddress, message.Content);
                }

            }
        }
        private void SendEmail(string email, string content)
        {
            Console.WriteLine($"Email Send to {email}");
        }
    }
}
