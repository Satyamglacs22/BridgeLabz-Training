using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    class IPLMatch
    {
        public int match_id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public Dictionary<string, int> score { get; set; }
        public string winner { get; set; }
        public string player_of_match { get; set; }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("IPL Censorship Analyzer Started...\n");

            var censoredJson = ReadAndCensorJson("ipl.json");
            WriteJson("ipl_censored.json", censoredJson);

            ProcessCsv("ipl.csv", "ipl_censored.csv");

            Console.WriteLine("\nCensorship Completed Successfully!");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        catch (JsonException ex)
        {
            Console.WriteLine("Invalid JSON format: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\nProgram execution finished.");
        }
    }

    static string MaskTeamName(string team)
    {
        if (string.IsNullOrEmpty(team))
            return team;

        string[] parts = team.Split(' ');
        return parts.Length >= 2
            ? parts[0] + " ***" + (parts.Length > 2 ? " " + parts[2] : "")
            : team;
    }

    static List<IPLMatch> ReadAndCensorJson(string path)
    {
        var matches = JsonConvert.DeserializeObject<List<IPLMatch>>(
            File.ReadAllText(path));

        foreach (var m in matches)
        {
            m.team1 = MaskTeamName(m.team1);
            m.team2 = MaskTeamName(m.team2);
            m.winner = MaskTeamName(m.winner);
            m.player_of_match = "REDACTED";

            if (m.score != null)
            {
                var newScore = new Dictionary<string, int>();
                foreach (var s in m.score)
                    newScore[MaskTeamName(s.Key)] = s.Value;

                m.score = newScore;
            }
        }
        return matches;
    }

    static void WriteJson(string path, List<IPLMatch> data)
    {
        File.WriteAllText(path,
            JsonConvert.SerializeObject(data, Formatting.Indented));
    }

    static void ProcessCsv(string input, string output)
    {
        var lines = File.ReadAllLines(input);
        var result = new List<string> { lines[0] };

        for (int i = 1; i < lines.Length; i++)
        {
            var cols = lines[i].Split(',');

            cols[1] = MaskTeamName(cols[1]);
            cols[2] = MaskTeamName(cols[2]);
            cols[5] = MaskTeamName(cols[5]);
            cols[6] = "REDACTED";

            result.Add(string.Join(",", cols));
        }
        File.WriteAllLines(output, result);
    }
}
