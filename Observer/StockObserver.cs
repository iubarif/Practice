using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StockObserver : IObserver
    {
        private double ibmPrice;
        private double applePrice;
        private double googlePrice;

        private static int observerIDTracker = 0;
        private int observerID;

        private ISubject stockGrabber;

        public StockObserver(ISubject stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            this.observerID = ++observerIDTracker;

            Console.WriteLine("New Observer " + this.observerID);
            stockGrabber.register(this);
        }

        public void update(double ibmPrice, double applePrice, double googlePrice)
        {
            this.ibmPrice = ibmPrice;
            this.applePrice = applePrice;
            this.googlePrice = googlePrice;

            Console.WriteLine("== Observer ID# " + this.observerID + " ==");
            Console.WriteLine("IBM Price = " + this.ibmPrice);
            Console.WriteLine("APPLE Price = " + this.applePrice);
            Console.WriteLine("Google Price = " + this.googlePrice);
        }
    }
}
