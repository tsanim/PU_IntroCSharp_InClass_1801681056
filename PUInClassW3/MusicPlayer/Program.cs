using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Do you want play some music?");
           string answer = Console.ReadLine();
           
          if(answer =="Yes")
          {

                Console.WriteLine("Playing music...!");

                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\WorkFolderTsM\PU_IntroCSharp_InClass_1801681056\Music\Dim4ou_-_Official_Video-eAnF_HYKpQM.wav"))
                {
                    
                    player.PlaySync();
                }

            }
          else if (answer =="No")
          {
                Console.WriteLine("Goodbye!");
          }
          else
          {
                Console.WriteLine("Wrong input!");
          }


            
            
    

                  
        }
    }
}
