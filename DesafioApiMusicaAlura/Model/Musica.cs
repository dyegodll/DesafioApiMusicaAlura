using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioApiMusicaAlura.Model;

internal class Musica
{
    [JsonPropertyName("artist")]
    public string Artist { get; set; }
    [JsonPropertyName("song")]
    public string Song { get; set; }
    [JsonPropertyName("year")]
    public string Year { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    [JsonPropertyName("genre")]
    public string Genre { get; set; }

    string[] tonalidade = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};

    public void TomDaMusica(int Key)
    {
        Console.WriteLine($"Artista: {Artist} - Música: {Song} - Ano: {Year} - Gênero: {Genre} - Tonalidade: {tonalidade[Key]}\n");
    }

}
