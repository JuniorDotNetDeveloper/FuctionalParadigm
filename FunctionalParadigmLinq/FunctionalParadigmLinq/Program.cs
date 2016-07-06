using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalParadigmLinq
{
    class Program
    {
        delegate Table CreateObj(float w, float l, float h);
        static void Main(string[] args)
        {
            List<Table> tables = new List<Table>()
            {
                new Table() {Width=1500, Height=1500, Length=2000 },
                new Table() {Width = 2000, Length = 3000, Height = 1200 },
                new Table() {Width = 2500, Length = 4000, Height = 1250 },
                new Table() {Width = 1800, Length = 3500, Height = 1000 },
                new Table() {Width=1500, Height=1500, Length=2000 }
            };

            CreateObj delegateObj = new CreateObj();
        }
    }
}
