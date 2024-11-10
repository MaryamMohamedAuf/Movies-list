using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using radzen.Models;
using radzen.Pages;

namespace radzen.Services;
public class MovieService
{
    private readonly HttpClient _httpClient;

    public MovieService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Movie>> GetMoviesAsync()
    {
        var movies = await _httpClient.GetFromJsonAsync<List<Movie>>("data/movies.json");
        Console.WriteLine($"Movies loaded: {movies?.Count ?? 0}");

        return movies ?? new List<Movie>();

    }
}
