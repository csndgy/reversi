using reversi;

Tabla ujTabla = new Tabla("allas.txt");

ujTabla.Megjelenit();
Console.WriteLine();
Console.WriteLine("6.feladat");
Console.WriteLine();
Console.WriteLine("Kék korongok száma: " + ujTabla.MezokSzama('K'));
Console.WriteLine("Fehér korongok száma: " + ujTabla.MezokSzama('F'));
Console.WriteLine("Üres korongok szám: " + ujTabla.MezokSzama('#'));
Console.WriteLine();

string parameterek = "F;4;1;0;1";
Console.WriteLine($"[jatekos; sor; oszlop; iranySor; iranyOszlop] = {parameterek}");

var elemek = parameterek.Split(',');
var j = char.Parse(elemek[0]);
var s = byte.Parse(elemek[1]);
var o = byte.Parse(elemek[2]);
var iSor = byte.Parse(elemek[3]);
var iOszl = byte.Parse(elemek[4]);

if (ujTabla.VanForditas(j,s,o,iSor,iOszl))
{
    Console.WriteLine("Van fordítás!");
}
else
{
    Console.WriteLine("nincs fordítás!");
}