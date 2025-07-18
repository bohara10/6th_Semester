using System;

// Define a custom exception
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter current balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdraw amount: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            if (withdrawAmount > balance)
            {
                // Throw user-defined exception
                throw new InsufficientBalanceException("Error: Withdraw amount exceeds the current balance.");
            }
            else
            {
                double remainingBalance = balance - withdrawAmount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: {remainingBalance}");
            }
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric input.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
