namespace HQSP_Assignment_1
{
    //Task 1 - Total money spent by Carlo
    internal class Program
    {
        //Initializing the variables
        static int CalgaryPrice = 1350;
        static int VancouverPrice = 1500;
        static int MontrealPrice = 575;

        static void Main(string[] args)
        {
            int calgaryTrips = GetNumberOfTrips("Calgary");
            int vancouverTrips = GetNumberOfTrips("Vancouver");
            int montrealTrips = GetNumberOfTrips("Montreal");

            int totalSpent = CalculateTotalMoneySpent(calgaryTrips, vancouverTrips, montrealTrips);
            int averageSpent = CalculateAverageMoneySpent(totalSpent, calgaryTrips + vancouverTrips + montrealTrips);

            DisplayResult(totalSpent, averageSpent);
        }

        static int GetNumberOfTrips(string destination)
        {
            Console.Write("Enter number of trips for " + destination + " : ");
            return int.Parse(Console.ReadLine());
        }

        static int CalculateTotalMoneySpent(int calgaryTrips, int vancouverTrips, int montrealTrips)
        {
            int ctms = (calgaryTrips * CalgaryPrice) + (vancouverTrips * VancouverPrice) + (montrealTrips * MontrealPrice);
            return ctms;
        }

        static int CalculateAverageMoneySpent(int totalSpent , int totalTrips)
        {
            return totalTrips > 0 ? 
                   totalSpent / totalTrips : 0;
        }

        static void DisplayResult(double totalMoneySpent, double averageSpent)
        {
            Console.WriteLine("Total money spent: $" + totalMoneySpent);
            Console.WriteLine("Average price calculation per trip: $" + averageSpent);
        }
    }
}
