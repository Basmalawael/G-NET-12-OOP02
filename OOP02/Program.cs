namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1:
            /* a) Identify at least two problems with this design:
             * Public Fields: The fields Owner and Balance are declared as public,
             * which allows external classes to modify them directly without any control 
             * or validation
             * 
             * Lack of Validation: The Withdraw method does not check if the amount is negative
             * or if it exceeds the current Balance, which could lead to an invalid account state
             * ( negative balance).
             * 
             * b) How to fix this class (Encapsulation Principles)
             * Change Access Modifiers: Change Owner and Balance from public to private 
             * (_owner and _balance).
             * 
             * Use Properties: Provide public Properties with get and set 
             * accessors to control how data is read or updated.
             * 
             * Add Logic to Methods: Update the Withdraw method to include an if statement
             * that ensures the withdrawal amount is valid before subtracting 
             * it from the balance.
             * 
             * c) Why exposing fields directly is a bad practice:
             * Exposing fields directly violates the principle of Data Hiding.
             * It prevents the class from enforcing rules (invariants) on its data. 
             * If the internal implementation changes later ( changing the data type), 
             * it will break all external code that depends on those public fields.
             * Using encapsulation ensures the class maintains full control over its internal state.
            */
            #endregion

            #region Q2:
            /*
            *1 Difference Between Fields and Properties in C:
            * 
            Field: A field is a variable of any type that is declared directly in a class.
            It is used to store data internally and is usually marked as private 
            to follow encapsulation.

            Property: A property is a member that provides a flexible mechanism to read, 
            write, or compute the value of a private field.
            It acts as a "wrapper" or "gatekeeper" for the field using 
            get and set accessors.

           *2 Can a property contain logic:
           * 
            Yes, a property can contain logic. 
            Inside the get or set accessors, you can add validation, logging, or calculations.
            For example, you can check if a value is positive before assigning it to a field in the set accessor.
          
           *3 Example: Read-only property with a calculated value:
           * 
            A read-only property only has a get accessor. It doesn't store a 
            value itself but calculates it on the fly.

            */
            #endregion

            #region Q3:
            /*
             * a) What is this[int index] called? Explain its purpose. 
             *It is called an Indexer
             *Purpose: It allows an instance of a class to be indexed just like an array.
             *It provides a simplified syntax to access internal collection 
             *data without exposing the collection itsel
             *
             *b) What happens if someone writes register[10] = "Ali";? 
             *How would you make it safer?
             *
             * What happens: It will throw an IndexOutOfRangeException because
             * the internal array names only has 5 elements (indices 0 to 4).
             *
             *How to make it safer: By adding validation logic inside the get and set 
             *to check if the index is within the valid range (0 to 4) before accessing the array.
             *
             *c) Can a class have more than one indexer? If yes, give an example.
             *
             *Answer: Yes, a class can have multiple indexers as long as they have different 
             *parameter types (Indexer Overloading).
             *
             *Example: A class could have one indexer that takes an int to find a student
             *by their ID, and another indexer that takes a string to find a student by their name.
             *
             */

            #endregion

            #region Q4:
            /*
             * a) What does the static keyword mean on TotalOrders? 
             * How is it different from the Item field?
             * 
             * Meaning: The static keyword means that the field TotalOrders belongs to the class
             * itself rather than a specific object (instance) of the class.
             * All objects created from the Order class share this single variable.
             * 
             * Difference from Item:
             * TotalOrders (Static): There is only one copy for the entire class.
             * It is used here to keep track of the total number of orders across all instances.
             *Item (Instance): Each object created has its own separate copy of the Item field. 
             *If you have 10 orders, you have 10 different items, but only one TotalOrders count
             *
             *b) Can a static method inside Order access the Item field directly? Why or why not?
             *
             *No, a static method cannot access the Item field directly
             *Why: Static methods belong to the class and are loaded even if no objects exist. 
             *Since the Item field is an instance field (belongs to a specific object),
             *the static method doesn't know which object's item it should access. 
             *It can only access other static members.
            
             
             
             
             */
            #endregion
            #endregion

            #region Part 02 : Practical (Extending the Movie Ticket Booking System)
           

               Cinema C = new Cinema();


            Console.WriteLine("========== Ticket Booking ==========");
            List<Ticket> tickets = new List<Ticket>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter data for Ticket {i + 1}:");


                Ticket ti1 = new Ticket();
                Console.Write("Enter Movie Name :");
                ti1.MovieName = Console.ReadLine();

                Console.Write("Enter Type (0=Standard, 1=VIP, 2=IMAX):");
                ti1.Type = (TicketType)int.Parse(Console.ReadLine());

                Console.Write("Enter Seat Row (A-Z):");
                char row = char.Parse(Console.ReadLine());

                Console.Write("Enter Seat Number:");
                int num = int.Parse(Console.ReadLine());
                ti1.Seat = new SeatLocation(row, num);

                Console.WriteLine("Enter Price ");
                ti1.Price = double.Parse(Console.ReadLine());

                C.AddTicket(ti1);
            }

            Console.WriteLine("------------ All Tickets  --------");

            foreach (var t in tickets)
            {
                Console.WriteLine(
                    $"Ticket | {t.MovieName} | {t.Type} " +
                    $"| Seat: {t.Seat.Row}-{t.Seat.Number} " +
                    $"| Price: {t.Price} EGP | After Tax: {t.PriceAfterTax:F1} EGP");
            }

         
           // البحث عن فيلم
            Console.Write("\nEnter movie name to search: ");
            string searchName = Console.ReadLine();
            Ticket found = C.GetMovieByMovieName(searchName);

            if (found != null)
                Console.WriteLine($"Found: {found.MovieName} in seat {found.Seat.Row}-{found.Seat.Number}");
            else
                Console.WriteLine("Movie not found.");

            // د) طباعة إجمالي التذاكر
            Console.WriteLine($"\nTotal Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            // توليد أرقام حجز
            Console.WriteLine("\n--- Booking References ---");
            Console.WriteLine(BookingHelper.GenerateBookingReference());
            Console.WriteLine(BookingHelper.GenerateBookingReference());
         

            
            double discountedPrice = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"\nGroup Discount (5 tickets * 80 EGP): {discountedPrice:F1} EGP");
           









            #endregion
        }
    }
}
