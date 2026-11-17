namespace VERRA_Wordlist.Business
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VERRA_Wordlist.Business.Interfaces;

    public class FileManager : IFileManager
    {
        public bool _success { get; private set; }

        public async Task<string> ReadFile(string filePath)
        {
            string resultText = string.Empty;

            try
            {
                using StreamReader reader = new(filePath);

                resultText = await reader.ReadToEndAsync();

                _success = true;
            }
            catch (IOException e)
            {
                resultText = e.Message;

                _success = false;
            }

            return resultText;
        }
    }
}
