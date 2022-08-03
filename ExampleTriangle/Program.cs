Console.Clear();

int ax = 75, ay = 1,
    bx = 1, by = 35,
    cx = 150, cy = 35;

Console.SetCursorPosition(ax,ay);
Console.WriteLine("+");

Console.SetCursorPosition(bx,by);
Console.WriteLine("+");

Console.SetCursorPosition(cx,cy);
Console.WriteLine("+");

int x = ax, y = bx;
int count = 0;

while (count < 50000) 
{
 int ranD = new Random().Next(0,3);

 if(ranD == 0){
    x = (x+ax) / 2;
    y = (y+ay) / 2;    
 }
 if(ranD == 1){
    x = (x+bx) / 2;
    y = (y+by) / 2;
 } 
 if(ranD == 2){
    x = (x+cx) / 2;
    y = (y+cy) / 2;
 }

 Console.SetCursorPosition(x,y);
 Console.WriteLine("+");
 count++;


}