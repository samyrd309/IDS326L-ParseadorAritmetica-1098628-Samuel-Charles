using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDS326L_ParseadorAritmetica
{
    /*se pone el tipo de dato que se va a devolver aquí abajo ↓*/
    internal class Aritmetica : aritmeticaBaseVisitor<int>
    {
        public override int VisitAritmetica([NotNull] aritmeticaParser.AritmeticaContext context)
        {
            Console.WriteLine($"Visitando Aritmetica: {context.GetText()}");
            Console.WriteLine("-------------------------");
            return base.VisitAritmetica(context);
        }

        public override int VisitExpresion([NotNull] aritmeticaParser.ExpresionContext context)
        {
            Console.WriteLine($"Visitando Expresion: {context.GetText()}");
            Console.WriteLine("-------------------------");
            return base.VisitExpresion(context);
        }

        public override int VisitTermino([NotNull] aritmeticaParser.TerminoContext context)
        {
            Console.WriteLine($"Visitando Termino: {context.GetText()}");
            Console.WriteLine("-------------------------");
            return base.VisitTermino(context);
        }
        public override int VisitFactor([NotNull] aritmeticaParser.FactorContext context)
        {
            Console.WriteLine($"Visitando Factor: {context.GetText()}");
            Console.WriteLine("-------------------------");
            return base.VisitFactor(context);
        }
    }
}
