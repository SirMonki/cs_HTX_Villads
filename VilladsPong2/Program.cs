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

Console.WriteLine("Press enter key to start the game...");

// Inistialisering
var inputKey = Console.ReadKey(true).Key;

while (inputKey != ConsoleKey.Enter) //While loop der tjekker efter om tasten er enter
{
 inputKey = Console.ReadKey(true).Key; // Lyt efter input
 if (inputKey == ConsoleKey.Enter) // Hvis input er enter, så output "Spillet er startet"
 {
  Console.WriteLine($"{hackerGreen}Spillet er startet");
 }
 else
 {
  Console.WriteLine($"{hackerRed}Ugyldig indtastning"); // Hvis ikke, så output ugyldig indtastning og gå tilbage til start
 }
}
