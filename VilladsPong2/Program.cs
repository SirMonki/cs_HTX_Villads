/*
 Programnavn: Evil Pong
 Programbeskrivelse: En ny version af det klassiske "Pong" fra 1960'erne
 Forfatter: Villads A. S. Kragelund
*/

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

Console.CursorVisible = false;
while (true)
{
 Console.Clear();
 ballPosX += ballDX;
 ballPosY += ballDY;
 if (ballPosY <= 0 || ballPosY >= laneHeight-1)
 {
  ballDY *= -1;
 }
 else if (ballPosX >= laneWidth - 1)
 {
  ballDX *= -1;
 }
 else if (ballPosX <= 0)
 {
  break;
 }
 
 Console.SetCursorPosition(ballPosX, ballPosY);
 Console.Write(ballChar);
 Console.SetCursorPosition(batPosX, batPosY); //Sæt cursor til battets position
 for (int i = 0; i < batHeight; i++)
  {
   Console.SetCursorPosition(batPosX, batPosY + i);
   Console.Write(batChar);
  }
 ConsoleKey key = Console.ReadKey(true).Key;
 if(key == ConsoleKey.UpArrow && batPosY > 0) // Rykker battet opad, hvis batPosY er større end toppen af vinduet
 {
  batPosY--;
 }
 else if(key == ConsoleKey.DownArrow && batPosY + batHeight < laneHeight) // Rykker battet nedad, hvis batPosY + batHeight er mindre end bunden af vinduet
 {
  batPosY++;
 }
 
}