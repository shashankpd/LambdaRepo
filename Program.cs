/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialization_and_deserialization
{
    public class Demo
    {
        static void Main(string[] args)
        {
           
            List<string> integer1 = new List<string> {"shashank", "harsha", "abc", "dileep","shruthi","shashank" };

            int c = integer1.Where(b => b.Equals("shashank")).ToList();
           

            
              Console.WriteLine(c);

            
           
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
class HelloWorld
{
    public static void Main()
    {
        List<string> integer1 = new List<string> {"shashank","dileep","harsha","murali"};

        int result = integer1.Count(b=>b.StartsWith("s"));

        Console.WriteLine(result);

       /* foreach (var val in result)
        {
           
        }*/
    }
}