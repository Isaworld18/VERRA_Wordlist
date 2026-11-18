namespace VERRA_Wordlist.Business
{
    using System;

    using VERRA_Wordlist.Business.Interfaces;

    public class WordManager(IFileManager fileManager) : IWordManager
    {
        public bool Success { get; private set; }

        private readonly IFileManager _fileManager = fileManager;

        public async Task<string> GetInputText(string filePath)
        {
            string result;
            try
            {
                result = await _fileManager.ReadFile(filePath);

                Success = _fileManager.Success;
            }
            catch (Exception ex)
            {
                result = ex.Message;

                Success = false;
            }

            return result;
        }

        public List<string> GetList(string text)
        {
            return [.. text.Split("\n")];
        }

        public List<string> GetMatchedWords(List<string> SourceList)
        {
            List<string> result = [];

            try
            {
                foreach (string word in SourceList)
                {
                    List<string> sourceListPart2 = [.. SourceList.Where(s => s.Length + word.Length <= 6)];

                    foreach (string wordPart2 in sourceListPart2)
                    {
                        string newWord = $"{word}{wordPart2}";

                        if (newWord.Length <= 6 && SourceList.Contains(newWord) && !result.Contains(newWord))
                        {
                            result.Add(wordPart2);

                            Console.WriteLine(newWord);
                        }
                    }
                }

                Console.WriteLine($"{result.Count} matched Words");
            }
            catch (Exception)
            {
                result = [];
            }

            return result;
        }
    }
}
