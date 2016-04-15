using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextManipulator.Core.WriteText
{
    public class TextToStringWriter: IWriteText
    {
        public string Write(string text)
        {
            return text;
        }
    }
}
