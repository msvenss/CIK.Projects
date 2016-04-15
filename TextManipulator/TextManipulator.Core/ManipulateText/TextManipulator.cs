using System;
using System.Collections.Generic;
using System.Linq;

namespace TextManipulator.Core.ManipulateText
{
   public static class TextManipulator
    {
       public static string Manipulate(this string text, List<IManipulateTextRule> rules)
       {
           return rules.Aggregate(text, (current, rule) => rule.Manipulate(current));
       }
    }
}
