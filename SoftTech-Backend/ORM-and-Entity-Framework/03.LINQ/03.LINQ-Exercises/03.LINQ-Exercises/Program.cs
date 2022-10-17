using MusicHub.Data;
using MusicHub.Data.Models;
using System.Text;

namespace MusicHub
{
    public class StartUp
    {
        public void Main(string[] args)
        {

        }

        public string ExportAlbumsInfo(MusicHubContext context, int producerId)
        {
            var albumsByProducer = context.Albums.Where(a => a.ProducerId == producerId).ToList();

            var stringBuilder = new StringBuilder();

            foreach (var album in albumsByProducer)
            {
                stringBuilder.AppendLine($"-AlbumName: {album.Name}");
                stringBuilder.AppendLine($"-ReleaseDate: {album.ReleaseDate.ToString("MM/dd/yyyy")}");
                stringBuilder.AppendLine($"-ProducerName: {album.Producer?.Name ?? "Unknown"}");
                stringBuilder.AppendLine($"-Songs:");

                foreach (var song in album.Songs?.OrderBy(s => s.Id))
                {
                    stringBuilder.AppendLine($"---#{song.Id}");
                    stringBuilder.AppendLine($"---SongName: {song.Name}");
                    stringBuilder.AppendLine($"---Price: {song.Price:F2}");
                    stringBuilder.AppendLine($"---Writer: {song.Writer?.Name ?? "Unknown"}");
                }

                stringBuilder.AppendLine($"-AlbumPrice: {album.Price:F2}");
            }

            return stringBuilder.ToString();
        }
        
        public string ExportSongsAboveDuration(MusicHubContext context, int duration)
        {
            var songsAboveDuration = context.Songs.Where(s => s.Duration > new TimeSpan(duration)).ToList().OrderBy(s => s.Id);

            var stringBuilder = new StringBuilder();

            foreach (var song in songsAboveDuration)
            {
                stringBuilder.AppendLine($"-Song #{song.Id}");
                stringBuilder.AppendLine($"---SongName: {song.Name}");
                stringBuilder.AppendLine($"---Writer: {song.Writer.Name}");
                stringBuilder.AppendLine($"---Performer: {song.SongPerformers.Select(sp => sp.Performer.FirstName + " " + sp.Performer.LastName).FirstOrDefault()}");
                stringBuilder.AppendLine($"---AlbumProducer: {song.Album.Producer.Name}");
                stringBuilder.AppendLine($"---Duration: {song.Duration}");
            }

            return stringBuilder.ToString();
        }
    }
}