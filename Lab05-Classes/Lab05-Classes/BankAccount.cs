using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    private string accountNumber; // HIDE THE FIELDS
    private string ownerName;
    private double balance;

    // EXPOSE CONTROLLED GATE
    // 1. AccountNumber: Never changes after creation.
    // Use { get; } only (no set) to make it read-only.
    public string AccountNumber { get; }

    // 2. OwnerName: Allow changing the owner's name if needed.
    public string OwnerName { get; set; }

    // 3. Balance: Readable from outside, but modifiable ONLY INSIDE this class.
    // Use { get; private set; } -> public to read, private so only this class can assign a value.
    public double Balance { get; private set; }

    // Default constructor
    public BankAccount()
    {
        AccountNumber = "000000";
        OwnerName = "";
        Balance = 0;
    }

    // Parameterized Constructor
    public BankAccount(string accountNumber, string ownerName, double initialBalance)
    {
        // Assign to AccountNumber (can only be assigned once, right here)
        AccountNumber = accountNumber;
        OwnerName = ownerName;

        // Initial balance must also be positive, let's reuse the logic
        if (initialBalance > 0)
            Balance = initialBalance;
        else
            Balance = 0;
    }

    public void Deposit(double amount)
    {
        // Boundary condition: Check if amount is positive
        if (amount > 0)
        {
            Balance += amount; // Allowed because setter is private, and this code is INSIDE the class
            Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Error: Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        // Boundary condition 1: Must be positive
        // Boundary condition 2: Must not exceed current balance
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Error: Withdrawal amount must be positive.");
        }
        else // amount > Balance
        {
            Console.WriteLine("Error: Insufficient funds.");
        }
    }

}