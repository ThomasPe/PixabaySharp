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

// simple image search example
var result = await client.SearchImagesAsync("dog");

// simple video search example
var result = await client.SearchVideosAsync("dog");

// more complex API queries for images
var result = await client.QueryImagesAsync(new ImageQueryBuilder()
{
    Query = "Dog",
    Page = 2,
    PerPage = 5
});

// more complex API queries for videos
var result = await client.QueryVideosAsync(new VideoQueryBuilder()
{
    Query = "Dog",
    Page = 2,
    PerPage = 5
});
```
