using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonjourMVC
{
    public class HelloMessage
    {
        public static Dictionary<string, string> languages = new Dictionary<string, string>
        {
            {"English", "Hello" },
            {"French", "Bonjour" },
            {"Spanish", "Hola" },
            {"German", "Hallo" },
            {"Italian", "Ciao" }
        };

        public static List<string> GetLanguages()
        {
            return languages.Keys.ToList();
        }

        public static string CreateMessage(string language, string name)
        {

            string greeting;
            if (!languages.TryGetValue(language, out greeting))
            {
                greeting = languages["English"];
            }

            return string.Format("{0}, {1}!", greeting, name);
        }
    }
}
