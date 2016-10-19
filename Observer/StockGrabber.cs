using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StockGrabber : ISubject
    {
        private List<IObserver> observers;

        private double ibmPrice;
        private double applePrice;
        private double googlePrice;

        public StockGrabber()
        {
            observers = new List<IObserver>();
        }
        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(ibmPrice, applePrice, googlePrice);
            }
        }

        public void register(IObserver o)
        {
            observers.Add(o);
        }

        public void unRegister(IObserver o)
        {
            int indexOfObserver = observers.IndexOf(o);
            observers.Remove(o);

            Console.WriteLine("Observer at index '" + indexOfObserver + "' DELETED");
        }

        public void setIBMPrice(double newPrice)
        {
            this.ibmPrice = newPrice;
            notifyObserver();
        }

        public void setApplePrice(double newPrice)
        {
            this.applePrice = newPrice;
            notifyObserver();
        }

        public void setGooglePrice(double newPrice)
        {
            this.googlePrice = newPrice;
            notifyObserver();
        }
    }
}
