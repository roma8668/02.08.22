Console.Clear();
int xa = 40; int ya = 2;
int xb = 1; int yb = 30;
int xc = 80; int yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
int x = xa;
int y = xb;
int count = 0;
while(count < 10000)
{
    int t = new Random().Next(0, 3);
    if (t == 0)
{
    x = (x + xa) / 2;
    y = (y + ya) / 2;
}
    if (t == 1)
{
    x = (x + xb) / 2;
    y = (y + yb) / 2;
}
    if (t == 2)
{
    x = (x + xc) / 2;
    y = (y + yc) / 2;
}
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count = count + 1;
}