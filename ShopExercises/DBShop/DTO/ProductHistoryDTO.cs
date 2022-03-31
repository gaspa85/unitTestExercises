namespace dbshop.businessModel;

public class ProductHistoryDTO
{
    public ProductDTO Product { get; set; }

    public List<ProductStateDTO> ListProductState { get; set; }

}
