using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using tp7_DataMhs;

namespace tp7
{
    internal class KuliahMahasiswa_1302220009_Naswan
    {
        public class Courses
        {
            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public class CoursesData
        {
            [JsonPropertyName("courses")]
            public List<Courses> Courses { get; set; }
        }

        public void ReadJson()
        {
            try
            {
                string fileName = "tp7_2_1302220009.json";
                string jsonText = File.ReadAllText(fileName);
                var coursesData = JsonSerializer.Deserialize<CoursesData>(jsonText);

                foreach (var course in coursesData.Courses)
                {
                    Console.WriteLine($"MK   {course.Code}  {course.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }
    }
}