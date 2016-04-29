using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prov {
    class Program {
        static void Main(string[] args) {
            Character test = new Character();

            test.CastSpell("dkskads");
            test.CastSpell("sakdksakdsak");
            test.CastSpell("sakdksakdsak");
            test.CastSpell("sakdksakdsak");
            Console.WriteLine(test.CastSpell("SpellHistory"));
            Console.ReadKey();
        }
    }
}
