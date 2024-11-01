using System;

namespace CheckValidIP
{
    public class CheckIP
    {
        public static bool CalculateNumbers(string ipv4Input)
        {
            string[] inputItems = ipv4Input.Split('.');

            if (ValidateLength(inputItems) && ValidateZeroes(inputItems) && ValidateRange(inputItems))
            {
                return true;
            }
            return false;
        }

        private static bool ValidateLength(string[] inputItem)
        {

            if (inputItem.Length == 4)
                return true;
            return false;

        }
        private static bool ValidateZeroes(string[] inputItem)
        {
            for (int i = 0; i < inputItem.Length; i++)
            {
                string currentItem = inputItem[i];
                if (currentItem != "")
                {
                    if (currentItem.Trim().StartsWith('0'))
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private static bool ValidateRange(string[] inputItem)
        {

            for (int i = 0; i < inputItem.Length; i++)
            {
                int getFirstCharacter = 0;

                if (int.TryParse(inputItem[i], out getFirstCharacter))
                {
                    if (getFirstCharacter < 0 || getFirstCharacter > 255)
                        return false;
                }
                else

                    return false;
            }

            return true;
        }
    }
}