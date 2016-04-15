using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextManipulator.Core.ReadText
{
   public class ReadText : IReadText
    {
       public string Read()

        {
            StreamReader reader = new StreamReader(@"C:\dev\CIK.Projects\TextManipulator\TextManipulator.Core\ReadText\Textfiles\TextTextManipulator.txt", System.Text.Encoding.Default);
            return reader.ReadToEnd();
        }
    }
}
