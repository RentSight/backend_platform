namespace Rent_Sight.API.Model
{
    public class CostBenefit
    {

        public string Neighbourhood { get; set; }

        public string RoomType { get; set; }

        public  int ListCount { get; set; }

        public decimal AvgPrice { get; set; }

        public decimal p50Price { get; set; }

        public decimal p90Price { get; set; }
        public double p50Availabilty365 { get; set; }

        public double CostBenefitScore { get; set; }

    }
}
