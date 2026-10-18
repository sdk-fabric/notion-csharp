
# notion-csharp

This [SDK](https://github.com/sdk-fabric/notion-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/sdkfabric/notion

## Usage

```csharp
using SdkFabric.Notion.Client;

Client client = Client.Build("[access_token]")

// Creates and appends new children blocks to the parent block or page specified.
Block_Collection response = client.Block().appendChildren("Notion-Version", "block_id", new Append_Block_Children_Request());

// Moves a block (including a page) to the trash.
Block response = client.Block().delete("Notion-Version", "block_id");

// Retrieves a Block object using the ID specified.
Block response = client.Block().get("Notion-Version", "block_id");

// Returns a paginated array of child block objects contained in the block (or page) using the ID specified.
Block_Collection response = client.Block().getChildren("Notion-Version", "block_id", 1, "start_cursor");

// Updates the content of a block based on its type, or moves it to/from the trash.
Block response = client.Block().update("Notion-Version", "block_id", new Update_Block_Request());

// Creates an additional data source in an existing database.
Data_Source response = client.DataSource().create("Notion-Version", new Create_Data_Source_Request());

// Retrieves a data source object, including its property schema.
Data_Source response = client.DataSource().get("Notion-Version", "data_source_id");

// Creates a database and its initial data source as a child of a page or the workspace.
Database response = client.Database().create("Notion-Version", new Create_Database_Request());

// Retrieves a database object, a container for one or more data sources, for a provided database ID.
Database response = client.Database().get("Notion-Version", "database_id");

// Updates the attributes (title, description, icon, cover, parent, inline, trash and lock status) of a database.
Database response = client.Database().update("Notion-Version", "database_id", new Update_Database_Request());

// Creates a new page as a child of an existing page or data source.
Page response = client.Page().create("Notion-Version", "filter_properties", new Create_Page_Request());

// Retrieves a Page object using the ID specified.
Page response = client.Page().get("Notion-Version", "filter_properties", "page_id");

// Retrieves the content of a page rendered as enhanced markdown.
Page_Markdown response = client.Page().getMarkdown("Notion-Version", true, "page_id");

// Retrieves a page property item.
Property_Item response = client.Page().getProperty("Notion-Version", "page_id", 1, "property_id", "start_cursor");

// Moves an existing page to a new parent page or data source.
Page response = client.Page().move("Notion-Version", "page_id", new Move_Page_Request());

// Updates page properties, icon, cover, lock state or trash status (in_trash).
Page response = client.Page().update("Notion-Version", "filter_properties", "page_id", new Update_Page_Request());

// Updates or replaces content in a page using enhanced markdown.
Page_Markdown response = client.Page().updateMarkdown("Notion-Version", "page_id", new Update_Page_Markdown_Request());

// Retrieves a User using the ID specified.
User response = client.User().get("Notion-Version", "user_id");

// Returns a paginated list of Users for the workspace.
User_Collection response = client.User().getAll("Notion-Version", 1, "start_cursor");

// Retrieves the bot User associated with the API token provided in the authorization header.
User response = client.User().getMe("Notion-Version");
```
