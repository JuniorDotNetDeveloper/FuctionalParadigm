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
        delegate int CompareTables(Table obj1, Table obj2);

        static void Main(string[] args)
        {
            List<Table> tables = new List<Table>()
            {
                new Table() {Width = 1500, Height = 1500, Length = 2000 },
                new Table() {Width = 2000, Length = 3000, Height = 1200 },
                new Table() {Width = 2500, Length = 4000, Height = 1250 },
                new Table() {Width = 1800, Length = 3500, Height = 1000 },
                new Table() {Width = 1500, Height = 1500, Length = 2000 }
            };

            CreateObj newTableObject = NewTableInstance;

            var table1 = tables.First();
            var table2 = tables.Skip(1).Take(1).First();
            //var table2 = tables.Skip(1).Take(1).Select(t => new { Height = t.Height, Width = t.Width, Length = t.Length });

            var MaxLength = tables.OrderByDescending(t => t.Length).First();
            var MinLength = tables.OrderBy(t => t.Length).Take(1).Select(t2 => new { Min = "it is a minimum lenght: " + t2.Length });
            var areaCollection = tables.Select(t => new { Area = (t.Length * t.Width)/1000 });

            #region defer execution
            int i = 2000;
            var whereOperator = tables.Where(t => t.Width > i);
            i = 1500;
            foreach (var item in whereOperator) Console.WriteLine(item);
            #endregion

            tables.Add(newTableObject(2220, 2220, 2220));

            CompareTables table1IsGreaterThanTable2 =  (Table t1, Table t2) => { return t1.Length.CompareTo(t2.Length); };
            Console.WriteLine(table1IsGreaterThanTable2(table1, table2));

            foreach (var item in MinLength)
                Console.WriteLine(item.Min);

            foreach (var area in areaCollection)
                Console.WriteLine("Area: " + area.Area);

            Console.ReadLine();
        }

        static Table NewTableInstance(float w, float l, float h)
        {
            return new Table(w, l, h);
        }

    }
}
