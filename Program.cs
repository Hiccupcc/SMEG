int WhileProgram = 0; 

while (WhileProgram == 0) //restarts the app
{
int UserInput = 0;
int TaskFinish = 0;
Console.WindowWidth = 35;
Console.WindowHeight = 20; 
int test = 0;
while (test == 0)
{ 
 try
 {
  Console.Write("Enter a value: ");
  UserInput = Convert.ToInt32(Console.ReadLine()); 
  test++;
 }
 catch (System.Exception)
 {
   Console.Clear();
   Console.WriteLine("Please Enter a valid number.");  
 }
}

 

while (TaskFinish == 0)
{ 
int Ans = 0; 
int Value = UserInput;
var (x, y, z) = GenRandomNumber();  
var (signI, signS) = GenRandomSign(); 
 for (int i = 0; i < 10; i++)
 {
   if (signS == "+")
   { 
        Random rnd = new Random();
        if(UserInput <= 10000)
				{
				  int randnum = rnd.Next(0,1000);
				  Ans = x + y + z + randnum; 
					Console.WriteLine(Ans);
				}
				if (UserInput >= 1000)
				{ 
					int randnum = rnd.Next(0,10000);
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
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.WriteLine(">> The number " + Value +" appeared");
    Console.ReadKey();
    Console.ResetColor();  
    Console.Clear(); 
    
   }
 }
}






static (int, string) GenRandomSign()
{
   string signS = "";
   Random rnd = new Random(); 
   int signI = rnd.Next(-100,3); 
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