Console.Clear();

bool jogarNovamente = true;

while (jogarNovamente)
{

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("--- Time dos Sonhos da NBA ---\n");
Console.ResetColor();
Console.WriteLine("Escolha 5 dos 20 jogadores:\n");

string[] jogadores = new string[]

{
"Michael Jordan (Armador)",
"LeBron James (Ala)",
"Kareem Abdul Jabbar (Pivô)",
"Magic Johnson (Armador)",
"Wilt Chamberlain (Pivô)",
"Bill Russell (Pivô)",
"Larry Bird (Ala)",
"Tim Duncan (Ala-pivô)",
"Oscar Robertson (Armador)",
"Kobe Bryant (Armador)",
"Shaquille O'Neal (Pivô)",
"Kevin Durant (Ala)",
"Hakeem Olajuwon (Pivô)",
"Julius Erving (Ala)",
"Moses Malone (Pivô)",
"Stephen Curry (Armador)",
"Dirk Nowitzki (Ala-pivô)",
"Giannis Antetokounmpo (Ala-pivô)",
"Jerry West (Armador)",
"Elgin Baylor (Ala)"
};

string[] timeDosSonhos = new string[5];
int jogadoresSelecionados = 0;

for (int i = 0; i < jogadores.Length; i++)
{
    Console.WriteLine($"{i + 1,3} - {jogadores[i]}");
}

Console.WriteLine();

while (jogadoresSelecionados < 5)
{
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write($"{jogadoresSelecionados} jogador(es) selecionados. Adicionar o Top #");
Console.ResetColor();

int idcSelecionado;

if (int.TryParse(Console.ReadLine(), out idcSelecionado) && idcSelecionado >= 1 && idcSelecionado <= 20)
{
string jogadorSelecionado = jogadores[idcSelecionado - 1];

if (Array.IndexOf(timeDosSonhos, jogadorSelecionado) == -1)
{
    timeDosSonhos[jogadoresSelecionados] = jogadorSelecionado;
    jogadoresSelecionados++;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Este atleta ja está no seu time.");
    Console.ResetColor();
}

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Digite somente os números correspondentes aos jogadores.");
    Console.ResetColor();
}
}

Console.WriteLine();
Console.WriteLine("Seu time dos sonhos é:");
Console.WriteLine();

for (int i = 0; i < timeDosSonhos.Length; i++)
{
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"{i + 1,3} - {timeDosSonhos[i]}");
Console.ResetColor();
}

Console.WriteLine();
Console.Write("Pressione qualquer tecla para ");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("jogar novamente");
Console.ResetColor();
Console.Write(" ou ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("'S' ");
Console.ResetColor();
Console.Write(" para sair: ");

ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.Clear();

if (keyInfo.Key == ConsoleKey.S)
{
jogarNovamente = false;
}   

}

   