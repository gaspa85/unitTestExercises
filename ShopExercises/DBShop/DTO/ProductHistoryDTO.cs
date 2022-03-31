namespace dbshop.businessModel;

public class ProductHistoryDTO
{
    public ProductDTO Product { get; set; }

    public Dictionary<TimeRangeDTO, ProductStateDTO> MapProductState { get; set; }
}
