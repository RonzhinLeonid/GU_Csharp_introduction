using System;

namespace Les7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ACoder aCoder = new ACoder();
            var a = aCoder.Encode("Съешь ещё этих мягких французских булок да выпей же чаю.");
            Console.WriteLine(a);
            //Тыёщэ ёъж юуйц надлйц хсбочфитлйц вфмпл еб гьрёк зё шбя.
            Console.WriteLine(aCoder.Decode(a));
            //Съешь ещё этих мягких французских булок да выпей же чаю.

            BCoder bCoder = new BCoder();
            var b = bCoder.Encode("Съешь ещё этих мягких французских булок да выпей же чаю.");
            Console.WriteLine(b);
            //Неъжг ъёщ вмцй таьфцй коясилчнфцй юлурф ыя эдпъх шъ зяб.
            Console.WriteLine(bCoder.Decode(b));
            //Съешь ещё этих мягких французских булок да выпей же чаю.

            Console.ReadKey();
        }
    }
}
