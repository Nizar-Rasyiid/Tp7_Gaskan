using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using tp7;

namespace tp7_DataMhs
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302220009_Naswan dataMahasiswa = new DataMahasiswa1302220009_Naswan();
            dataMahasiswa.ReadJSON();

            KuliahMahasiswa_1302220009_Naswan kuliah = new KuliahMahasiswa_1302220009_Naswan();
            kuliah.ReadJson();
        }
    }
}