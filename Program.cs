namespace HQSP_Assignment_1_Task_1
{
    //Task 1 - Total money spent by Carlo on each trip
    internal class Program
    {
        //Initializing variables with respective prices for each destination
        static int CalgaryPrice = 1350;
        static int VancouverPrice = 1500;
        static int MontrealPrice = 575;

        //Main method where program execution starts
        static void Main(string[] args)
        {
            //Fetching the number of trips for each destination
            int calgaryTrips = GetNumberOfTrips("Calgary");
            int vancouverTrips = GetNumberOfTrips("Vancouver");
            int montrealTrips = GetNumberOfTrips("Montreal");

            //Calculation of total amount of money spent 
            int totalSpent = CalculateTotalMoneySpent(calgaryTrips, vancouverTrips, montrealTrips);

            //Calculation of average money spent per trip
            int averageSpent = CalculateAverageMoneySpent(totalSpent, calgaryTrips + vancouverTrips + montrealTrips);

            //Displaying the total money spent and average spent per trip
            DisplayResult(totalSpent, averageSpent);
        }

        //Method to fetch number of trips for each destination
        static int GetNumberOfTrips(string destination)
        {
            //Prompt user to enter number of trips for each destination
            Console.Write("Enter number of trips for " + destination + " : ");
            
            //Returns the number of trips specified by user
            return int.Parse(Console.ReadLine());
        }

        //Method to calculate total money spent per trip
        static int CalculateTotalMoneySpent(int calgaryTrips, int vancouverTrips, int montrealTrips)
        {
            //Calculating total money spent where number of trips is multiplied by it's respective price
            int ctms = (calgaryTrips * CalgaryPrice) + (vancouverTrips * VancouverPrice) + (montrealTrips * MontrealPrice);

            //Returns the calculated total money spent
            return ctms;
        }

        //Method to calculate average money spent per trip
        static int CalculateAverageMoneySpent(int totalSpent , int totalTrips)
        {
            //Returns the average money spent per trip
            //if total trips > 0 then calculate totalspent divides totaltrips or else return 0
            return totalTrips > 0 ? 
                   totalSpent / totalTrips : 0;
        }

        //Method to display final result
        static void DisplayResult(double totalMoneySpent, double averageSpent)
        {
            //Prints total money spent
            Console.WriteLine("Total money spent: $" + totalMoneySpent);

            //Prints average money spent per trip
            Console.WriteLine("Average price calculation per trip: $" + averageSpent);
        }
    }
}
