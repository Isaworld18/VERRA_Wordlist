namespace VERRA_Wordlist.Business
{
    using VERRA_Wordlist.Business.Interfaces;

    public class FileManager : IFileManager
    {
        public bool Success { get; private set; }

        public async Task<string> ReadFile(string filePath)
        {
            string resultText = string.Empty;

            try
            {
                using StreamReader reader = new(filePath);

                resultText = await reader.ReadToEndAsync();

                Success = true;
            }
            catch (IOException e)
            {
                resultText = e.Message;

                Success = false;
            }

            return resultText;
        }
    }
}
