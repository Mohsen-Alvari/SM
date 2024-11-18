
namespace BCC.Shared;

public class BCCException: Exception
{
    public ApiResultStatusCode StatusCode { get; }

    public BCCException(string message, ApiResultStatusCode statusCode = ApiResultStatusCode.LogicError)
        : base(message)
    {
        StatusCode = statusCode;
    }
}

