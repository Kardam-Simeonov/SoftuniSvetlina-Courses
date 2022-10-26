using System;
using System.Linq;
using System.Text;
using System.Globalization;
using Diablo.Data;
using Diablo.Data.Models;

namespace Diablo
{
    public class StartUp
    {
        static void Main()
        {
            DiabloContext context = new DiabloContext();

        }

        public static string CharactersInformation(DiabloContext context, int luck)
        {
            var charactersWithExtraLuck = context.Characters.Where(c => c.Statistic.Luck > luck).OrderBy(c => c.UsersGames.Count).Select(c => new
            {
                Name = c.Name,
                GamesPlayed = c.UsersGames.Count,
                GamesNames = c.UsersGames.Select(g => g.Game.Name).ToArray()
            }).ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var character in charactersWithExtraLuck)
            {
                sb.AppendLine($"Name: {character.Name}");
                sb.AppendLine($"Games: {character.GamesPlayed}");
                sb.AppendLine($"Game name: {string.Join("\nGame name: ", character.GamesNames)}");
            }

            return sb.ToString();
        }

        public static string GameTypesInformation(DiabloContext context, int idGameType)
        {
            var gameType = context.GameTypes.Where(gt => gt.Id == idGameType).Select(gt => new
            {
                Name = gt.Name,
                GamesNames = gt.Games.Select(g => g.Name).ToArray()
            }).OrderBy(c => c.Name).ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var game in gameType)
            {
                sb.AppendLine($"Game type: {game.Name}");
                sb.AppendLine($"Game name: {string.Join("\nGame name: ", game.GamesNames)}");
            }

            return sb.ToString();
        }

        public static string UserGamesInformation(DiabloContext context, int userId)
        {
            var userGames = context.Users
                 .Where(u => u.Id == userId)
                 .FirstOrDefault()
                 .UsersGames
                 .ToArray()
                 .Select(gt => new
                 {
                     Name = gt.Game.Name,
                     CharacterName = gt.Character.Name,
                     ItemsUsed = gt.Character.Statistic.Items.Select(i => i.Name).ToArray()
                 }).OrderBy(ug => ug.ItemsUsed).ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (var game in userGames)
            {
                sb.AppendLine($"Game:{game.Name}");
                sb.AppendLine($" Character Name: {game.CharacterName}");
                sb.AppendLine($" Items:");
                sb.AppendLine($" -{string.Join("\n -", game.ItemsUsed)}");
            }

            return sb.ToString();
        }
    }
}
