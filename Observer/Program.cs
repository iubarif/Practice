using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();
            StockObserver observer01 = new StockObserver(stockGrabber);

            stockGrabber.setIBMPrice(190.50);
            stockGrabber.setApplePrice(670.25);
            stockGrabber.setGooglePrice(700.75);
            
            Console.ReadLine();
        }
    }
}
