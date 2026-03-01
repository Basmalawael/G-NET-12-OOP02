using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Ticket
    {
        //field 
        private string _movieName;
        private double _price;

        //prop 1
        public string MovieName 
        { 
           get { return _movieName; }

            set {
                if (!string.IsNullOrEmpty(value))
                {
                    _movieName = value;
                }
               }
        }
        //------------------------------------
        //prop 2
        public double Price 
        {
            get { return _price; }
            //----------------------
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        //-------------------------------
        //Read Only 
        public double PriceAfterTax
        {
            get
            {
                return _price * 1.14 ;
            }
        }
        //--------------------------
        //Auto Property
       public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }


        //---------------------------------
        private static int _ticketCounter = 0;
        //--------------------------------

        public int TicketID { get; private set; }

        //ctor
        public Ticket()
        {
            _ticketCounter ++;
              TicketID = _ticketCounter;
        }

        //method 
        public static int GetTotalTicketsSold()
        {
            return _ticketCounter;
        }
    }
}
