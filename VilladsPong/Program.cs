//lav nye farver ud fra rgb
String hackerGreen = "\x1b[38;2;0;255;0m";
String hackerRed = "\x1b[38;2;255;0;0m";
String reset = "\x1b[0m";
//udskriv en linje
Console.WriteLine($"{hackerGreen}Hello, World! My name is Mr Robbort \nWelcome to my {hackerRed}EVIL!!! {hackerGreen}pong!!!{reset}");