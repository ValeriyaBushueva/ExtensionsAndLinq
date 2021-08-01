namespace ExtensionsAndLinq
{
    public static class StringExtensions
    {
        public static int GetSymbolCount(this string textToFindSymbolsAmount, char symbolToFind)
        {
            int resultAmountCounter = 0;
            
            for (var i = 0; i < textToFindSymbolsAmount.Length; i++)
            {
                if (textToFindSymbolsAmount[i] == symbolToFind)
                {
                    resultAmountCounter++;
                }
            }

            return resultAmountCounter;
        }
    }
}