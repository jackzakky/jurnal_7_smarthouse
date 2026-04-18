using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Modul7_Smarthouse
{
    internal class Filmfavorit_103022400094
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

    
       public static void ReadJSON()
        {
            string jsonPath = "jurnal7_1_103022400094.json";

            if (File.Exists(jsonPath))
            {
                string jsonData = File.ReadAllText(jsonPath);

                Filmfavorit_103022400094 data =
                    JsonSerializer.Deserialize<Filmfavorit_103022400094>(jsonData);

                if (data != null)
                {
                    Console.WriteLine($"judul: {data.title}");
                    Console.WriteLine($"director: {data.director}");
                    Console.WriteLine($"year: {data.year}");
                    Console.WriteLine($"genre: {data.genre}");
                    Console.WriteLine($"rating: {data.rating}");
                    Console.WriteLine($"durationMinutes: {data.durationMinutes}");
                    Console.WriteLine($"isWatched: {data.isWatched}");

                }
            }
            else
            {
                Console.WriteLine("File JSON tidak ada.");
            }
        }
    }
}