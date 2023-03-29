using System.Net.Http.Json;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    List<Monkey> _monkeyList = new ();
    HttpClient _httpClient;

    public MonkeyService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Monkey>> GetMonkeys()
    {
        if (_monkeyList.Count() > 0)
        {
            return _monkeyList;
        }

        var url = "https://montemagno.com/monkeys.json";

        var response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            _monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }

        return _monkeyList;
    }
        
}
