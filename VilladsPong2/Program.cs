/*
 Programnavn: Evil Pong
 Programbeskrivelse: En ny version af det klassiske "Pong" fra 1960'erne
 Forfatter: Villads A. S. Kragelund
*/

using System.Diagnostics;

//Lav nye farver ud fra RGB
String hackerGreen = "\x1b[38;2;0;255;0m";
String hackerRed = "\x1b[38;2;255;0;0m";
String reset = "\x1b[0m";

int laneHeight = Console.WindowHeight;
int laneWidth = Console.WindowWidth;
int batPosY = Console.WindowHeight/2;
int batPosX = 1;
char batChar = '|'; 
int batHeight = 4;

int ballPosY =  Console.WindowHeight/2;
int ballPosX =  Console.WindowWidth/2;
int ballDY=1;
int ballDX=1;
char ballChar = '#';

TimeSpan ballMoveDeltaTime = TimeSpan.FromMilliseconds(100);
TimeSpan ballNextMoveDeltaTime = ballMoveDeltaTime;
Stopwatch ballMoveTimer = new Stopwatch(); //Stopur til boldens bevægelse
ballMoveTimer = Stopwatch.StartNew();

Console.CursorVisible = false;

while (true)
{
 Console.Clear();
 if (ballMoveTimer.Elapsed >= ballNextMoveDeltaTime) //Hvis der er gået den definerede mængde tid
 {
  ballNextMoveDeltaTime = ballMoveTimer.Elapsed + ballMoveDeltaTime; // Beregn tid til næste boldbevægelse
  
  ballPosX += ballDX;
  ballPosY += ballDY;
  
  if (ballPosY <= 0 || ballPosY >= laneHeight - 1 || ballPosX <= batPosX+1)
  {
   ballDY *= -1;
  }
  else if (ballPosX >= laneWidth - 1)
  {
   ballDX *= -1;
  }
  else if (ballPosX <= 0)
  {
   Console.Write($"{hackerRed}Game Over");
   Thread.Sleep(3000);
   break;
  }
 }

 Console.SetCursorPosition(ballPosX, ballPosY);
 Console.Write(ballChar);
 Console.SetCursorPosition(batPosX, batPosY); //Sæt cursor til battets position
 for (int i = 0; i < batHeight; i++)
  {
   Console.SetCursorPosition(batPosX, batPosY + i);
   Console.Write(batChar);
  }

 if (Console.KeyAvailable)
 {
  ConsoleKey key = Console.ReadKey(true).Key;
  if (key == ConsoleKey.UpArrow && batPosY > 0) // Rykker battet opad, hvis batPosY er større end toppen af vinduet
  {
   batPosY--;
  }
  else if
   (key == ConsoleKey.DownArrow &&
    batPosY + batHeight < laneHeight) // Rykker battet nedad, hvis batPosY + batHeight er mindre end bunden af vinduet
  {
   batPosY++;
  }
 }
}