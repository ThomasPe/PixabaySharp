# PixabaySharp
This is an unofficial C# / .NET API Wrapper

# Getting Started


**Get API Credentials**

- Create a free [Pixabay Account](https://pixabay.com/en/accounts/register/)
- Find your API key here: https://pixabay.com/api/docs/#api_key

**Install PixabaySharp from NuGet**

- `Install-Package PixabaySharp`

**Use the PixabaySharp client**

```csharp
var client = new PixabaySharpClient("apikey");

// simple search example
var result = await client.Search("dog");

// more complex API queries
var result = await client.QueryImages(new ImageQueryBuilder()
{
    Query = "Dog",
    Page = 2,
    PerPage = 5
});
```
