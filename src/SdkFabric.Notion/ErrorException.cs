/**
 * ErrorException automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using Sdkgen.Client.Exception;

namespace SdkFabric.Notion;

public class ErrorException : KnownStatusCodeException
{
    public Error Payload;

    public ErrorException(Error payload)
    {
        this.Payload = payload;
    }
}
