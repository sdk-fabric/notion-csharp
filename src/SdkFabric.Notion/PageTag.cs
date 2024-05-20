/**
 * PageTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace SdkFabric.Notion;

public class PageTag : TagAbstract {
    public PageTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    public async Task<Page> Get(string pageId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("page_id", pageId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/v1/pages/:page_id", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<Page>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }


}