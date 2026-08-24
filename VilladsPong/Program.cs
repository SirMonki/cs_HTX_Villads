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
int baneX;
int baneY;
int baneHeight;
int baneWidth;
int baneColour;
int baneOpening;
char baneChar;
//batvariabler
int batX;
int batY;
int batColour;
char batChar;
//spillervariabler
string playerName;

//giv variabler værdier ud fra input

//String
Console.WriteLine("Indtast dit navn");
playerName = Console.ReadLine();
Console.WriteLine("Du hedder: " + playerName);

//initialisering
baneHeight = 25;
baneWidth = 100;
baneChar = '#';

batX = 2;
batY = baneHeight/2;
batChar = '|';
int batHeight = 4; // hvor mange felter battet fylder lodret

//Game loop
while (true)
{
 // Læs tastetryk
 if (Console.KeyAvailable)
 {
  var key = Console.ReadKey(true).Key;

  if (key == ConsoleKey.UpArrow && batY > 1)
  {
   batY--;
  }
  else if (key == ConsoleKey.DownArrow && batY < baneHeight - 1 - batHeight)
  {
   batY++;
  }
  else if (key == ConsoleKey.Escape)
  {
   break;
  }
 }

 Console.SetCursorPosition(0, 0);
//Tegn banen
 for (int y = 0; y < baneHeight; y++)
 {
  for (int x = 0; x < baneWidth; x++)
  {
   if (x == batX && y >= batY && y < batY + batHeight)
   {
    Console.Write(batChar);
   }
   else if (y == 0 || y == baneHeight - 1 || x == 0 || x == baneWidth - 1)
   {
    Console.Write(baneChar);
   }
   else
   {
    Console.Write(" ");
   }
  }

  Console.WriteLine();
 }
}

//Console.WriteLine("\nEr du stolt Kenneth?");
