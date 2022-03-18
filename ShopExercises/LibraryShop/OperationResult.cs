namespace LibraryShop;

public class OperationResult<T>
{
    public T? Result { get; set; }
    public ReturnCode ReturnCode { get; set; }
    public string MessageError { get; set; } = "";
    public Exception? Exception { get; set; }

}

public enum ReturnCode
{
    Success,
    Error,
    DBError
}
