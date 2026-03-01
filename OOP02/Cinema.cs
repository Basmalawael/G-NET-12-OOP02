using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Cinema
    {
        private Ticket[] _tickets  = new Ticket[20];
        public Ticket this[int index]
        {
            get
            {
                if (index < 0 || index >= _tickets.Length)
                    return null;

                return _tickets[index];
            }
            //--------------------------------
            set
            {
                if (index >= 0 && index < _tickets.Length) 
                     _tickets[index] =  value ;
            }


        }
        // Method Search Movie 
        public Ticket GetMovieByMovieName(string movieName)
        {
            foreach (var Ticket in _tickets)
            {
                if (Ticket != null && Ticket.MovieName == movieName)
                    return Ticket; // لقيناه؟ رجعه فوراً 
            }
            return null;

        }

        //Method  AddTickt 

        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null) {

                 _tickets[i] = ticket;
                    return true;
                                         }
            }
            return false;
        }




    }
}
