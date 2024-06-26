/**
 * DatabaseTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Notion;

public class DatabaseTag : TagAbstract {
    public DatabaseTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<Database> Get(string databaseId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("database_id", databaseId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/v1/databases/:database_id", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<Database>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }


}
