using BlazorWebAssemblyApp.Models;

namespace BlazorWebAssemblyApp;

public static class PlayerClient
{
    private static readonly List<Player> players = new List<Player>()
    {
        new Player()
        {
            Id = 1,
            Name = "Roger Federer",
            Nationality = "Switzerland",
            Majors = 20,
            Birthday = new DateTime(1981, 9, 12),
            IsSelected = false,
            Statistics = new PlayerStatistics()
            {
                Height = "6ft 1",
                Weight = 180.00,
                TotalWins = 1251,
                TotalLosses = 275
            }
        },
        new Player()
        {
            Id = 2,
            Name = "Rafael Nadal",
            Nationality = "Spain",
            Majors = 22,
            Birthday = new DateTime(1986, 6, 3),
            IsSelected = false,
            Statistics = new PlayerStatistics()
            {
                Height = "6ft 1",
                Weight = 185.00,
                TotalWins = 1068,
                TotalLosses = 220
            }
        },
        new Player()
        {
            Id = 3,
            Name = "Novak Djokovic",
            Nationality = "Serbia",
            Majors = 24,
            Birthday = new DateTime(1987, 5, 22),
            IsSelected = false,
            Statistics = new PlayerStatistics()
            {
                Height = "6ft 2",
                Weight = 175.00,
                TotalWins = 1082,
                TotalLosses = 211
            }
        },
    };

    public static Player[] GetPlayers()
    {
        return players.ToArray();
    }

    public static void AddPlayer(Player player)
    {
        player.Id = players.Max(x => x.Id) + 1;
        players.Add(player);
    }

    public static Player GetPlayer(int id)
    {
        return players.Find(x => x.Id == id) ?? throw new Exception("Could not find player!");
    }

    public static void UpdatePlayer(Player updatedPlayer)
    {
        Player existingPlayer = GetPlayer(updatedPlayer.Id);
        existingPlayer.Name = updatedPlayer.Name;
        existingPlayer.Nationality = updatedPlayer.Nationality;
        existingPlayer.Majors = updatedPlayer.Majors;
        existingPlayer.Birthday = updatedPlayer.Birthday;
    }

    public static void DeletePlayer(int id)
    {
        Player player = GetPlayer(id);
        players.Remove(player);
    }
}