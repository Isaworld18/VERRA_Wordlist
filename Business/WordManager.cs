namespace VERRA_Wordlist.Business
{
    using System;

    using VERRA_Wordlist.Business.Interfaces;

    public class WordManager : IWordManager
    {
        public bool _success { get; private set; }

        private readonly IFileManager _fileManager;

        public WordManager(IFileManager fileManager)
        { 
            _fileManager = fileManager;
        }

        public async Task<string> GetInputText(string filePath)
        {
            string result = string.Empty;

            try
            {
                result = await _fileManager.ReadFile(filePath);

                _success = _fileManager._success;
            }
            catch (Exception ex)
            {
                result = ex.Message;

                _success = false;
            }

            return result;
        }

        public List<string> GetList(string text)
        {
            return [.. text.Split("\n")];
        }

        public List<string> GetMatchedWords(List<string> SourceList)
        {
            List<string> result = new List<string>();

            try
            {
                foreach (string word in SourceList)
                {
                    foreach (string wordPart2 in SourceList)
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
            catch (Exception ex)
            {
                result = new List<string>();
            }

            return result;
        }
    }
}
