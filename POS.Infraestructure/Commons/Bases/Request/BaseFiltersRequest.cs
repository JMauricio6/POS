namespace POS.Infraestructure.Commons.Bases.Request
{
    public class BaseFiltersRequest : BasePaginationRequest
    {
        public int? NumFilter { get; set; } = null;
        public string? TextFilter { get; set; }
        public int? StateFilters { get; set;}
        public string? StartData { get; set; } = null;
        public string? EndDate { get; set;}=null;
        public bool? Download { get; set; } = false;
    }
}
