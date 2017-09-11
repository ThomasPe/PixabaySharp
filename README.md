# PixabaySharp
This is an unofficial C# / .NET API Wrapper written for .NET Standard 1.2.

## Compatible with
- .NET Core 
- .NET Framework 4.5+
- Mono 4.6
- Xamarin
- Universal Windows Platform (UWP)
- Windows 8+
- Windows Phone 8.1

# Getting Started

**Getting API Credentials**

- Create a free [Pixabay Account](https://pixabay.com/en/accounts/register/)
- Find your API key here: https://pixabay.com/api/docs/#api_key

**Installing PixabaySharp from NuGet**

- `Install-Package PixabaySharp`

**Using the PixabaySharp client**

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
