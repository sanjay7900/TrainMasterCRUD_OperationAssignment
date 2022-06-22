using TrainsClassLibraryFile;
using TrainsClassLibraryFile.Models;

namespace TrainMasterOperationsForTrains
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CRUDForTrainMaster  cRUDForTrainMaster = new CRUDForTrainMaster();
            List<DaysOnWhichEveryTrainRun> daysOnWhichEveryTrainRun = new List<DaysOnWhichEveryTrainRun>(); 
            daysOnWhichEveryTrainRun.Add(new DaysOnWhichEveryTrainRun { TrainRunDays="All Week Days" });
            Train train = new Train
            {
                TrainNo = 806756,
                TrainName = "Maharaja Express",
                FromStation = "Agra",
                ToStation = "Kasmir",
                JourneyStartTime = new TimeSpan(2, 30, 00),
                JourneyEndTime = new TimeSpan(6, 00, 00),
                DaysOnWhichEveryTrainRuns = daysOnWhichEveryTrainRun
            };

            List<DaysOnWhichEveryTrainRun> daysOnWhichEveryTrainRun2 = new List<DaysOnWhichEveryTrainRun>();
            daysOnWhichEveryTrainRun2.Add(new DaysOnWhichEveryTrainRun { TrainRunDays = "Sunday" });
            daysOnWhichEveryTrainRun2.Add(new DaysOnWhichEveryTrainRun { TrainRunDays = "Fraiday" });
            Train traintwo = new Train
            {
                TrainNo = 809087,
                TrainName = "APJ Abdul Kalam Express",
                FromStation = "Mumbai",
                ToStation = "Pune",
                JourneyStartTime = new TimeSpan(2, 30, 00),
                JourneyEndTime = new TimeSpan(6, 00, 00),
                DaysOnWhichEveryTrainRuns = daysOnWhichEveryTrainRun2
            };
             cRUDForTrainMaster.AddTrains(traintwo);
            //// cRUDForTrainMaster.SearchTrainFrom_to_station("delhi", "Mathura");
            // cRUDForTrainMaster.DeleteTrain(102090);
            // cRUDForTrainMaster.SearchTrainFrom_to_station("delhi", "Mathura");
            // cRUDForTrainMaster.TrainSearchByTarinNumber(102090);
            cRUDForTrainMaster.UpdateTrain(102030, train);
            cRUDForTrainMaster.TrainSearchByTarinNumberWithDay(809087);



            Console.ReadLine();
        }
    }
}