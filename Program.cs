namespace HQSP_Assignment_1
{
    //Task 1 - Total money spent by Carlo
    internal class Program
    {
        //Initializing the variables
        int CalgaryPrice = 1350;
        int VancouverPrice = 1500;
        int MontrealPrice = 575;

        static void Main(string[] args)
        {
            
        }

        static int GetNumberOfTrips(string destination)
        {
            Console.Write("Enter number of trips for" + destination + " : ");
            return int.Parse(Console.ReadLine());
        }

        static int CalculateTotalMoneySpent(int calgaryTrips, int vancouverTrips, int montrealTrips)
        {
            int ctms = (calgaryTrips * CalgaryPrice) + (vancouverTrips * VancouverPrice) + (montrealTrips * MontrealPrice)
            return ctms;
        }

        static double CalculateAverageMoneySpent(double totalSpent , int totalTrips)
        {
            return totalTrips > 0 ? 
                   totalSpent / totalTrips : 0;
        }

        static void DisplayResult(double totalMoneySpent, double averageSpent)
        {
            Console.WriteLine("Total money spent: $" + totalMoneySpent);
            Console.WriteLine("Average price calaculation per trip: $" + averageSpent);
        }
    }
}
