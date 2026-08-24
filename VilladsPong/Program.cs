/*
 Programnavn: Evil Pong
 Programbeskrivelse: En ny version af det klassiske "Pong" fra 1960'erne
 Forfatter: Villads A. S. Kragelund
*/
//lav nye farver ud fra rgb
String hackerGreen = "\x1b[38;2;0;255;0m";
String hackerRed = "\x1b[38;2;255;0;0m";
String reset = "\x1b[0m";

//udskriv en linje
Console.WriteLine($"{hackerGreen}Hello, World! My name is Mr Robbort \nWelcome to my {hackerRed}EVIL!!! {hackerGreen}pong!!!{reset}");
Console.SetCursorPosition(6,14);

//boldvariabler
int boldX;
int boldY;
int boldHastighedX;
int boldHastighedY;
char boldChar;
int boldColour;
//banevariabler
int laneX;
int laneY;
int laneHeight;
int laneWidth;
int laneColour;
int laneOpening;
char laneChar;
//batvariabler
int batX;
int batY;
int batColour;
char batChar;
//spillervariabler
string playerName;

//giv variabler værdier ud fra input

//Char
Console.WriteLine("Indtast et tegn");
batChar = Convert.ToChar(Console.ReadLine());
Console.WriteLine("batChar er nu:" + batChar);

//String
Console.WriteLine("Indtast dit navn");
playerName = Console.ReadLine();
Console.WriteLine("Du hedder: " + playerName);

//Int
Console.WriteLine("indtast et heltal");
boldHastighedX= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Boldens hastighed på x-aksen er nu: " + boldHastighedX);

Console.ReadKey(); // Venter på at der kommer en ny indtastning i keyboardbufferen
Console.ReadKey(true); // Hvis kommandoen er sat til true, så vil den ikke outputte tegnet
Console.KeyAvailable; // giver en værdi bestemt ud fra om der er en indtasting klar i programmets input, samt hvilken det er


Console.WriteLine("Er du stolt Kenneth?");
