namespace Rent_Sight.API.DTOS
{
    public class AvailabilitySummaryResponseDTO
    {
        public MetaDTO Meta { get; set; } = new();
        public CoverageDTO Coverage { get; set; } = new();
        public AvailabilityStatsDTO Availability { get; set; } = new();
        public HighlightsDTO Highlights { get; set; } = new();
    }

    public class MetaDTO
    {
        public DateTimeOffset GeneratedAt { get; set; }
        public FiltersDTO Filters { get; set; } = new();
    }

    public class FiltersDTO
    {
        public string? RoomType { get; set; }
        public int MinListings { get; set; }
    }

    public class CoverageDTO
    {
        public int Rows { get; set; }
        public int Neighbourhoods { get; set; }
        public int RoomTypes { get; set; }
        public int TotalListingsCountSum { get; set; }
    }

    public class AvailabilityStatsDTO
    {
        public double AvgAvailability365 { get; set; }
        public double P50Availability365 { get; set; }
    }

    public class HighlightsDTO
    {
        public HighlightItemDTO? TopByP50 { get; set; }
        public HighlightItemDTO? BottomByP50 { get; set; }
    }

    public class HighlightItemDTO
    {
        public string Neighbourhood { get; set; } = "";
        public string RoomType { get; set; } = "";
        public int ListingsCount { get; set; }
        public double P50Availability365 { get; set; }
        public double AvgAvailability365 { get; set; }
    }
}
