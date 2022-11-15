// See https://aka.ms/new-console-template for more information
using Antlr4.Runtime;
using IDS326L_ParseadorAritmetica;

Console.WriteLine("Hello, World!");

string input = "5*6+9*3-1"; // paso 1
Console.WriteLine("|-------------------------|");
Console.WriteLine($"|----Input: {input}-----|");
Console.WriteLine("|-------------------------|");
ICharStream stream = CharStreams.fromString(input); // paso 2
aritmeticaLexer lexer = new aritmeticaLexer(stream); // paso 3
CommonTokenStream tokens = new CommonTokenStream(lexer); // paso 4
aritmeticaParser parser = new aritmeticaParser(tokens); // paso 5 (Al parser se le llama el evento inicial. Para cada regla que yo cree se crea un metodod)
var tree = parser.aritmetica(); // paso 6 (esto devuelve un arbol tipo aritmeticaParseraritmeticaContext) OJO: aquí ocurrio el parseo aunque no tire nada.
// paso 7 Se crea una nueva calse que va a ser el visitor.
Aritmetica aritmeticaVisitor = new Aritmetica();
int res = aritmeticaVisitor.Visit(tree);