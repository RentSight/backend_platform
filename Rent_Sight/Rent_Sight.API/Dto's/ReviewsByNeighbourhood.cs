namespace Rent_Sight.API.Model
{
    public class ReviewsByNeighbourhood
    {
        public string Neighbourhood { get; set; }

        public int ListCount { get; set; }
        public decimal AvgNumberOfReviews { get; set; }
        public decimal AvgReviewsPerMonth { get; set; }

    }
}
