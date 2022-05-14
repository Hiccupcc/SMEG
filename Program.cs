int TaskFinish = 0;
Console.WindowWidth = 35; 
Console.WriteLine("Please don't click the console");
Console.WriteLine("To continue, press any button");
Console.ReadKey(); 
Console.Clear(); 
Console.Write("Enter a value: ");
int UserInput = Convert.ToInt32(Console.ReadLine());
while (TaskFinish == 0)
{ 
int Ans = 0; 
int Value = UserInput;
var (x, y, z) = GenRandomNumber();  
var (signI, signS) = GenRandomSign(); 
 for (int i = 0; i < 2; i++)
 {
   if (signS == "+")
   { 
        Random rnd = new Random();
        if(UserInput <= 10)
				{
				  int randnum = rnd.Next(0,10);
				  Ans = x + y + z + randnum; 
					Console.WriteLine(Ans);
				}
				if (UserInput >= 10)
				{ 
					int randnum = rnd.Next(0,1000);
				  Ans = x + y + z + randnum; 
					Console.WriteLine(Ans);
				}
   }
   else if (signS == "-")
    {
			  Random rnd = new Random(); 
        if (UserInput >= 10)
				{
				 int randnum = rnd.Next(0,1000);
				  Ans = x + y + z + randnum; 
					Console.WriteLine(Ans);
				}
				else if (UserInput <= 10)
				{
					int randnum = rnd.Next(0,1000);
				  Ans = x + y + z + randnum; 
					Console.WriteLine(Ans);
				}
    }
  }
  if (Ans == Value)
  {
    TaskFinish++;
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("The number " + Value +" appeared");
    Console.ReadKey(); 
    break;
    
  }
}
static (int, string) GenRandomSign()
{
   string signS = "";
   Random rnd = new Random(); 
   int signI = rnd.Next(1,3); 
   if (signI == 1)
   {
     signS = "+";
   }
   else if (signI == 2)
    {
     signS = "-";
    }

  return (signI, signS);
}
static (int, int, int) GenRandomNumber()
{
   int x; int y; int z; 
   Random rnd = new Random(); 
   x = rnd.Next(1, 3); 
   y  = rnd.Next(1, 3); 
   z = rnd.Next(1, 3); 
  return (x, y, z);
}