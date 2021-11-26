using System;
using System.Threading.Channels;

namespace MySQLCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            MasinaRepository masinaRep =new MasinaRepository();
        
            masinaRep.getAll().ForEach(masina =>Console.WriteLine(masina));
        }
    }
}
