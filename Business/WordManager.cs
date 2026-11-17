namespace VERRA_Wordlist.Business
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VERRA_Wordlist.Business.Interfaces;

    public class WordManager : IWordManager
    {
        public bool Success { get; private set; }

        private readonly IFileManager _FileManager;

        public WordManager(IFileManager fileManager)
        { 
            _FileManager = fileManager;
        }

        public async Task<string> GetWordList(string filePath)
        {
            string result = string.Empty;

            try
            {

                Success = true;
            }
            catch (Exception ex)
            {
                result = ex.Message;

                Success = false;
            }

            return result;
        }
    }
}
