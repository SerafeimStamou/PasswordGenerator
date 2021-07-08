using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;

namespace PasswordGeneratorUI
{
    public class PasswordMaker
    {
        public static List<char> GeneratePassword(int passwordLength,string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }

            Random random = new();
            ResourceManager source = new("PasswordGeneratorUI.source", Assembly.GetExecutingAssembly());
            string value = source.GetString(key);
            List<char> characters = new();
            int index = 0;

            for (int i = 0; i < passwordLength; i++)
            {
                index = random.Next(0, value.Length);
                characters.Add(value[index]);
            }

            return characters;
        }
    }
}
