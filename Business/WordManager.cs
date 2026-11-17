namespace VERRA_Wordlist.Business
{
    using System;

    using VERRA_Wordlist.Business.Interfaces;

    public class WordManager : IWordManager
    {
        public bool _success { get; private set; }

        bool IWordManager._success => throw new NotImplementedException();

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
            return text.Split("\n").ToList();
        }

        public List<string> GetMatchedWords(List<string> SourceList)
        {
            throw new NotImplementedException();
        }
    }
}
