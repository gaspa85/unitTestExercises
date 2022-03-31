namespace util;

public class OperationResult<T>
{
    public T? Result { get; set; }
    public ReturnCode ReturnCode { get; set; }
    public string MessageError { get; set; } = "";
    public Exception? Exception { get; set; }

    public OperationResult<C> clone<C>(C c)
    {
        return new OperationResult<C>()
        {
            Result = c,
            ReturnCode = this.ReturnCode,
            MessageError = this.MessageError,
            Exception = this.Exception
        };
    }
}

public enum ReturnCode
{
    Success,
    Error,
    DBError
}
