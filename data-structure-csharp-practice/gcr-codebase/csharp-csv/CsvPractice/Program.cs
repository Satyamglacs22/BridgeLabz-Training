using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace CsvPractice
{
    class Program
    {
        static void Main()
        {
            ReadCSV();
            WriteCSV();
            CountRows();
            FilterMarks();
            SearchEmployee();
            UpdateSalary();
            SortBySalary();
            ValidateCSV();
            CsvToObjects();
            MergeCsv();
            ReadLargeCsv();
            DetectDuplicates();
            JsonToCsvAndBack();
            EncryptDecryptCsv();

            Console.WriteLine("\n✅ All CSV operations executed successfully.");
        }

        // 1️⃣ Read CSV
        static void ReadCSV()
        {
            Console.WriteLine("\n1️⃣ Read CSV");
            foreach (var line in File.ReadAllLines("students.csv").Skip(1))
            {
                var d = line.Split(',');
                Console.WriteLine($"ID:{d[0]} Name:{d[1]} Age:{d[2]} Marks:{d[3]}");
            }
        }

        // 2️⃣ Write CSV
        static void WriteCSV()
        {
            Console.WriteLine("\n2️⃣ Write CSV");
            string[] data =
            {
                "ID,Name,Department,Salary",
                "1,Amit,IT,50000",
                "2,Riya,HR,45000",
                "3,Rahul,IT,60000",
                "4,Neha,Finance,55000",
                "5,Ankit,IT,70000"
            };
            File.WriteAllLines("employees.csv", data);
        }

        // 3️⃣ Count Rows
        static void CountRows()
        {
            Console.WriteLine("\n3️⃣ Count Rows");
            int count = File.ReadAllLines("students.csv").Length - 1;
            Console.WriteLine($"Total Records: {count}");
        }

        // 4️⃣ Filter Marks > 80
        static void FilterMarks()
        {
            Console.WriteLine("\n4️⃣ Filter Marks > 80");
            foreach (var line in File.ReadAllLines("students.csv").Skip(1))
            {
                var d = line.Split(',');
                if (int.Parse(d[3]) > 80)
                    Console.WriteLine(line);
            }
        }

        // 5️⃣ Search Employee
        static void SearchEmployee()
        {
            Console.WriteLine("\n5️⃣ Search Employee");
            string name = "Amit";
            foreach (var line in File.ReadAllLines("employees.csv").Skip(1))
            {
                var d = line.Split(',');
                if (d[1] == name)
                    Console.WriteLine($"Dept:{d[2]} Salary:{d[3]}");
            }
        }

        // 6️⃣ Update Salary
        static void UpdateSalary()
        {
            Console.WriteLine("\n6️⃣ Update Salary (IT +10%)");
            var lines = File.ReadAllLines("employees.csv").ToList();
            List<string> updated = new() { lines[0] };

            foreach (var line in lines.Skip(1))
            {
                var d = line.Split(',');
                if (d[2] == "IT")
                    d[3] = ((int)(int.Parse(d[3]) * 1.1)).ToString();

                updated.Add(string.Join(",", d));
            }
            File.WriteAllLines("employees_updated.csv", updated);
        }

        // 7️⃣ Sort by Salary
        static void SortBySalary()
        {
            Console.WriteLine("\n7️⃣ Top 5 Salaries");
            var result = File.ReadAllLines("employees.csv")
                .Skip(1)
                .Select(l => l.Split(','))
                .OrderByDescending(d => int.Parse(d[3]))
                .Take(5);

            foreach (var r in result)
                Console.WriteLine(string.Join(",", r));
        }

        // 8️⃣ Validate CSV
        static void ValidateCSV()
        {
            Console.WriteLine("\n8️⃣ Validate Email & Phone");
            Regex email = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            Regex phone = new(@"^\d{10}$");

            foreach (var line in File.ReadAllLines("users.csv").Skip(1))
            {
                var d = line.Split(',');
                if (!email.IsMatch(d[2]) || !phone.IsMatch(d[3]))
                    Console.WriteLine($"Invalid Row: {line}");
            }
        }

        // 9️⃣ CSV to Objects
        static void CsvToObjects()
        {
            Console.WriteLine("\n9️⃣ CSV to Objects");
            List<Student> students = new();

            foreach (var line in File.ReadAllLines("students.csv").Skip(1))
            {
                var d = line.Split(',');
                students.Add(new Student
                {
                    Id = int.Parse(d[0]),
                    Name = d[1],
                    Age = int.Parse(d[2]),
                    Marks = int.Parse(d[3])
                });
            }

            students.ForEach(s => Console.WriteLine($"{s.Name} {s.Marks}"));
        }

        // 🔟 Merge CSV
        static void MergeCsv()
        {
            Console.WriteLine("\n🔟 Merge CSV");
            var s1 = File.ReadAllLines("students1.csv").Skip(1)
                .Select(l => l.Split(',')).ToDictionary(d => d[0]);

            var s2 = File.ReadAllLines("students2.csv").Skip(1)
                .Select(l => l.Split(',')).ToDictionary(d => d[0]);

            List<string> merged = new() { "ID,Name,Age,Marks,Grade" };

            foreach (var id in s1.Keys)
                if (s2.ContainsKey(id))
                    merged.Add($"{id},{s1[id][1]},{s1[id][2]},{s2[id][1]},{s2[id][2]}");

            File.WriteAllLines("merged.csv", merged);
        }

        // 1️⃣1️⃣ Read Large CSV
        static void ReadLargeCsv()
        {
            Console.WriteLine("\n1️⃣1️⃣ Read Large CSV");
            using StreamReader sr = new("large.csv");
            int count = 0;

            while (!sr.EndOfStream)
            {
                for (int i = 0; i < 100 && !sr.EndOfStream; i++)
                {
                    sr.ReadLine();
                    count++;
                }
                Console.WriteLine($"Processed: {count}");
            }
        }

        // 1️⃣2️⃣ Detect Duplicates
        static void DetectDuplicates()
        {
            Console.WriteLine("\n1️⃣2️⃣ Detect Duplicates");
            HashSet<string> ids = new();

            foreach (var line in File.ReadAllLines("data.csv").Skip(1))
            {
                string id = line.Split(',')[0];
                if (!ids.Add(id))
                    Console.WriteLine($"Duplicate: {line}");
            }
        }

        // 1️⃣4️⃣ JSON ↔ CSV
        static void JsonToCsvAndBack()
        {
            Console.WriteLine("\n1️⃣4️⃣ JSON ↔ CSV");

            var students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("students.json"));
            List<string> csv = new() { "Id,Name,Age,Marks" };

            foreach (var s in students)
                csv.Add($"{s.Id},{s.Name},{s.Age},{s.Marks}");

            File.WriteAllLines("students_from_json.csv", csv);

            var json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("students_back.json", json);
        }

        // 1️⃣5️⃣ Encrypt / Decrypt
        static void EncryptDecryptCsv()
        {
            Console.WriteLine("\n1️⃣5️⃣ Encrypt / Decrypt");
            string salary = "50000";
            string enc = Encrypt(salary);
            string dec = Decrypt(enc);

            Console.WriteLine($"Encrypted: {enc}");
            Console.WriteLine($"Decrypted: {dec}");
        }

        static string Encrypt(string data) =>
            Convert.ToBase64String(Encoding.UTF8.GetBytes(data));

        static string Decrypt(string data) =>
            Encoding.UTF8.GetString(Convert.FromBase64String(data));
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }
}
