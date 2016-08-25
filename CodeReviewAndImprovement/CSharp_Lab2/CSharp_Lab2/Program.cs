using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab2
{class Program { static void Main(string[] args)
        {
Console.WriteLine("Welcome! What is your name? (enter your name):");string ewr = Console.ReadLine();Console.WriteLine("Would you like to play a game? (enter “yes” or “no”):");             string fsfd = Console.ReadLine();

if (fsfd.Contains(
    
    
    
    "es"
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    )) {

Console.WriteLine("Excellent!  You are walking across a field and you encounter a fire-breathing dragon! "+" What would you do? (enter “face the beast” or “run away”):");
string fdlm = Console.ReadLine();
if (fdlm == "face the beast")
{
                    Console.WriteLine("You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):");
                    string pfgl = Console.ReadLine();
                    int ijnll_____dkmgd;
                    if (int.TryParse(pfgl, out ijnll_____dkmgd) && ijnll_____dkmgd >= 1 && ijnll_____dkmgd <= 3)
                    {
Console.WriteLine($"No one has ever faced a {ijnll_____dkmgd}-headed dragon before!  Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):");
string onmmk = Console.ReadLine();
switch (onmmk)
{
case "slingshot":
                                Console.WriteLine("Armed with your "+onmmk+", you approach the dragon.  You can feel its fiery breath as you get closer.   It stares at you with its ___ eyes.  (enter “red” or “blue”):");
break;   case "sword":
                                Console.WriteLine(string.Format ("Armed with your {0}, you approach the dragon.  You can feel its fiery breath as you get closer.   It stares at you with its ___ eyes.  (enter “red” or “blue”):", onmmk));
                                break; 
                            case "bow and arrow":
                                Console.WriteLine($"Armed with your {onmmk}, you approach the dragon.  You can feel its fiery breath as you get closer.   It stares at you with its ___ eyes.  (enter “red” or “blue”):");
string frgbfd055502 = Console.ReadLine();switch (frgbfd055502)
{case "red":
Console.WriteLine($"Oh thank goodness!  {frgbfd055502}-eyed dragons are friendly.  You pet it and become friends.  You name the dragon ___. (enter a name):");
string u = Console.ReadLine();
Console.WriteLine($"{ewr} and {u} live happily ever after. :");
break; case "blue":
Console.WriteLine($"The story has ended for you {ewr}. The eyes go beyond the imagination of this fantasy.");
break; default:
Console.WriteLine($"The story has ended for you {ewr}. The eyes go beyond the imagination of this fantasy.");
break;
}

                                break;  default: Console.WriteLine($"The story has ended for you {ewr}. The eyes go beyond the imagination of this fantasy.");
                                break;
                        }

                    } else { Console.WriteLine($"The story has ended for you {ewr}. The heads go beyond the imagination of this fantasy.");
                    }

                }
                else {
                    Console.WriteLine($"The story has ended for you {ewr}. You ran away from the dragon.");
                }  }
            else {
															Console.WriteLine($"The story has ended for you {ewr}, before it could begin. Until next time.");
     }

            Console.Read();
        }
    }
}
