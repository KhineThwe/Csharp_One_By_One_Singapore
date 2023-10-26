using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        const int initialAmount = 200000;
        ArrayList expenses = new ArrayList();

        Console.WriteLine("Enter the monthly expenses: ");
        Console.Write("House Rent: ");
        int houseRent = GetExpensesAmount();
        expenses.Add(houseRent);

        Console.Write("Phone Bill: ");
        int phoneBill = GetExpensesAmount();
        expenses.Add(phoneBill);

        Console.Write("Shopping: ");
        int shopping = GetExpensesAmount();
        expenses.Add(shopping);


        Console.Write("Electric Bill: ");
        int electricBill = GetExpensesAmount();
        expenses.Add(electricBill);


        Console.Write("Water Supply Bill: ");
        int waterBill = GetExpensesAmount();
        expenses.Add(waterBill);
         
        Console.Write("Gas Bill: ");
        int gasBill = GetExpensesAmount();
        expenses.Add(gasBill);

        int totalExpenses = CalculateTotalExpense(expenses);
        int remainingAmount = initialAmount - totalExpenses;

        Console.WriteLine("\nTotal Expenses : " + totalExpenses);
        Console.WriteLine("Remaining Amount : " + remainingAmount);

    }

    public static int GetExpensesAmount()
    {
    public int amount;
    while(true)
    {
        try{
        amount = int.Parse(Console.ReadLine());
        if(amount>=0
        ){
            break;
        }
        Console.WriteLine("Invalid input.Please enter a positive amount.");
        }
        catch(FormatException)
        {
        Console.WriteLine("Invalid input.Please enter a valid integer amount.");
        }
    }

    return amount;
}

public static int CalculateTotalExpense(ArrayList costs)
{
    int total = 0;
    foreach(int cost in costs)
    {
        total += cost;//total = total + cost
    }
    return total;
  }
}

