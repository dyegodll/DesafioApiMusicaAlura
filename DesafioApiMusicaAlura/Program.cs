using DesafioApiMusicaAlura.Model;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    string json = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicaList = JsonSerializer.Deserialize<List<Musica>>(json)!;

    foreach (var musica in musicaList)
    {
        musica.TomDaMusica(musica.Key);
    }
}