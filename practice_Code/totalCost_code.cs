using MyProjectDemo;

using System;

class Result
{



    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
      double tip= meal_cost*tip_percent/100.0;
      double tax=tax_percent*meal_cost/100.0;
     // double total_cast=meal_cost+tip+tax;
          int totalCost = (int)Math.Round(meal_cost + tip + tax);
      Console.WriteLine($"the total cost is {totalCost}.");

    }

}

