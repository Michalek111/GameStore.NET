using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient(HttpClient httpClient)
{
    public async Task<GameSummary[]> GetGamesAsync()
        => await httpClient.GetFromJsonAsync<GameSummary[]>("games") ?? [];

    public async Task AddGameAsync(GameDetails game)
        => await httpClient.PostAsJsonAsync("games",game);

    public async Task<GameDetails> GetGameAsync(int ID)
        => await httpClient.GetFromJsonAsync<GameDetails>($"games/{ID}")
        ?? throw new Exception("Could not find game");

    public async Task UpdateGameAsync(GameDetails updatedGame)
        => await httpClient.PutAsJsonAsync($"games/{updatedGame.ID}", updatedGame);    


    public async Task DeleteGameAsync(int ID)
        => await httpClient.DeleteAsync($"games/{ID}");

}
