using System;
 
namespace Decoder
{
    class Program
    {
        public static String CaesarCipher(String cipherText, Int32 key)
        {
            String alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            String cipherTextLow = cipherText.ToLower();
            Char[] sourceText = new Char[cipherTextLow.Length];
            Int32 j = 0;

            for (Int32 i = 0; i < cipherTextLow.Length; i++)
            {
                if (!Char.IsLetter(cipherTextLow[i]))
                    sourceText[i] = cipherTextLow[i];
                else
                {
                    sourceText[i] = '|';
                    while (sourceText[i] == '|')
                    {
                        if (cipherTextLow[i] == alphabet[j])
                        {
                            try
                            {
                                sourceText[i] = alphabet[j - key];
                            }
                            catch
                            {
                                sourceText[i] = alphabet[(j - key) + 33];
                            }
                        }
                        j++;
                    }
                    j = 0;
                }
            }

            return new String(sourceText);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CaesarCipher("Фхнжйч!", 5));

            Console.ReadKey();
        }
    }
}