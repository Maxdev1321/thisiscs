using System;
using System.IO;

namespace BinaryFile
{
    class MainApp
    {
        static void Main(string[]args)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("aa.dat", FileMode.Create));

            bw.Write(int.MaxValue);
            bw.Write("Good Morning!");
            bw.Write(uint.MaxValue);
            bw.Write("안녕하세요!");
            bw.Write(double.MaxValue);

            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream("aa.dat", FileMode.Open));

            Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadUInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadDouble()}");

            br.Close();
        }
    }
}
