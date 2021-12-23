using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStringDemo
{
    class SuperString
    {


        // Getter method for text
        public string GetText()
        {
            return text;
        }

        // Setter method for text
        public void SetText(string text)
        {
            if (text == null) text = "";

            // this = reference to current instance of SuperString
            // this = referentie naar huidig geinstantieerd object
            this.text = text;
        }

        public void Reverse()
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                result = text[i] + result;
            }

            // Overwrite previous text with reversed text
            text = result;
        }

        public int CountCharacter(char character)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == character)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void ToUpperCase()
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    // Change to upper case
                    int offset = text[i] - 'a';         // The offset in the alfabet
                    char upper = (char)('A' + offset);  // Change to upper case
                    result += upper;
                }
                else
                {
                    // Same as "do nothing"
                    result += text[i];
                }
            }
            text = result;
        }

        // Attributes
        private string text = "";   // Empty string != null
    }
}
