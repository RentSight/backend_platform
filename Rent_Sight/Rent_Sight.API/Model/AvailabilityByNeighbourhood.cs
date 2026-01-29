namespace Rent_Sight.API.Model
{
    public class AvailabilityByNeighbourhood
    {
        public string neighbourhood { get; set; }
        public string room_type_simulated { get; set; }

        public int listings_count { get; set; }

        public double avg_availability_365 { get; set; }

        public double p50_availability_365 { get; set; }
    }
}
