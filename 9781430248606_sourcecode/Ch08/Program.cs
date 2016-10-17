using System;

namespace Ch08
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsManager nlm = new NewsManager();
            /* Initialize the client of the news manager event. The 
             * clients will subscribe to the event in the 
             * initialization time.*/
            Reviewer subscriberOne = new Reviewer(nlm);
            Publisher subscriberTwo = new Publisher(nlm);

            /* Some news arrived to the NewsManager to publish and 
             * notify to the subscribers.*/
            nlm.PublishNews("Higgs particle",
                   "The Higgs particle is named after Peter Higgs.");
            nlm.PublishNews("Expert C# 5.0 with .NET Framework 4.5",
                            "A about the C# language.");

            /* Finished job so UnSubscribe the events */
            subscriberOne.UnSubscribe(nlm);
            subscriberTwo.UnSubscribe(nlm);

            /* Publishing new news but it not going to be notified */
            nlm.PublishNews("10th Dimensional world",
                            "Still under investigation so don't publish.");
        }
    }

    public class Reviewer
    {
        public Reviewer(NewsManager nlm)
        {
            /* Subscribe to the NewsManager for the notification.*/
            nlm.NewsEvent += ReviewOnArrivedNews;
        }

        /* When news arrived if subscribe then execute this method.*/
        private void ReviewOnArrivedNews(object sender, NewsEventArgs na)
        {
            Console.WriteLine("Reviewed:\n{0},\t{1}", na.Title, na.Detail);
        }

        /* To unsubscribe from the NewsEvent */
        public void UnSubscribe(NewsManager nlm)
        {
            nlm.NewsEvent -= ReviewOnArrivedNews;
        }
    }

    public class Publisher
    {
        public Publisher(NewsManager nlm)
        {
            /* Subscribe to the NewsManager for the notification.*/
            nlm.NewsEvent += PublishArrivedNews;
        }

        /* When news arrived if subscribe then execute this method.*/
        private void PublishArrivedNews(object sender, NewsEventArgs na)
        {
            Console.WriteLine("Published:\n{0} news.", na.Title);
        }

        public void UnSubscribe(NewsManager nlm)
        {
            nlm.NewsEvent -= PublishArrivedNews;
        }
    }

    public class NewsManager
    {
        /* An container of the subscribed method to the event.
         * Clients can subscribe for the notification via 
         * NewsEvent event.*/
        public event EventHandler<NewsEventArgs> NewsEvent;

        public void PublishNews(string name, string detail)
        {
            NewsEventArgs na = new NewsEventArgs(name, detail);

            /* If news arrived and ready to publish then call OnNewsArrival 
             * method which will execute subscribed methods.*/
            OnNewsArrival(na);
        }

        /* If anyone subscribe for the notification then this method will 
         * invoke each of the subscribed method and execute all. */
        protected virtual void OnNewsArrival(NewsEventArgs args)
        {
            EventHandler<NewsEventArgs> newsHandler = NewsEvent;
            if (newsHandler != null)
            {
                newsHandler(this, args);
            }
        }
    }

    public class NewsEventArgs : EventArgs
    {
        /*  Declared few private fields */
        private string title;
        private string detail;

        public NewsEventArgs(string TitleOfTheNews, string DetailOfTheNews)
        {
            title = TitleOfTheNews;
            detail = DetailOfTheNews;
        }

        /* ReadOnly fields */
        public string Title { get { return title; } }
        public string Detail { get { return detail; } }
    }
}
