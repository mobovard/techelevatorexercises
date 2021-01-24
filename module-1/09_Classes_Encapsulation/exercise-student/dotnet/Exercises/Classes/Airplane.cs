namespace Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }
        public int BookedFirstClassSeats { get; private set; }
        public int TotalCoachSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
          
        }

        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }

        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - AvailableFirstClassSeats;
            }
        }



        public bool ReserveSeats (bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass == true && totalNumberOfSeats <= AvailableFirstClassSeats)
            {
                BookedFirstClassSeats = BookedFirstClassSeats + totalNumberOfSeats;
                return true;
            }
            else if (forFirstClass == true)
            {
                return false;
            }
            else if (forFirstClass == false && totalNumberOfSeats <= AvailableCoachSeats)
            {
                BookedCoachSeats = BookedCoachSeats + totalNumberOfSeats;
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
