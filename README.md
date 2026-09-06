
# notion-csharp

This [SDK](https://github.com/sdk-fabric/notion-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/sdkfabric/notion

## Usage

```csharp
using SdkFabric.Notion.Client;

Client client = Client.Build("[access_token]")

// Returns a paginated list of Users for the workspace.
UserCollection response = client.User().Getall("Notion-Version", "start_cursor", 1);

// Retrieves a User using the ID specified.
User response = client.User().Get("Notion-Version", "user_id");

// Retrieves a database object — information that describes the structure and columns of a database — for a provided database ID.
Database response = client.Database().Get("Notion-Version", "database_id");

// Retrieves a Page object using the ID specified.
Page response = client.Page().Get("page_id");

// Creates a new page that is a child of an existing page or database.
Page response = client.Page().Create(new Page());
```
