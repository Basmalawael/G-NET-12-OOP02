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


















            #endregion
        }
    }
}
