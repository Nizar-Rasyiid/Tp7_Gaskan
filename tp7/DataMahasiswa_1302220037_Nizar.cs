using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tp7_DataMhs
{
    public class DataMahasiswa1302220037_Nizar
    {
        public class Mahasiswa
        {
            [JsonPropertyName("nama")]
            public Nama Nama { get; set; }

            [JsonPropertyName("nim")]
            public string Nim { get; set; }

            [JsonPropertyName("fakultas")]
            public string Fakultas { get; set; }
        }

        public class Nama
        {
            [JsonPropertyName("depan")]
            public string Depan { get; set; }

            [JsonPropertyName("belakang")]
            public string Belakang { get; set; }
        }

        public void ReadJSON()
        {
            try
            {
                string fileName = "TP7_1_1302220037.json";

                // Membaca teks JSON dari file

                string jsonText = File.ReadAllText(fileName);

                // Melakukan deserialisasi JSON menjadi objek Mahasiswa
                var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonText);

                // Mendapatkan nilai atribut
                string namaDepan = mahasiswa.Nama.Depan;
                string namaBelakang = mahasiswa.Nama.Belakang;
                string nim = mahasiswa.Nim;
                string fakultas = mahasiswa.Fakultas;

                // Mencetak hasil deserialisasi dengan format yang diminta
                Console.WriteLine($"Nama {namaDepan} {namaBelakang} dengan nim {nim} dari fakultas {fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }
    }
}
