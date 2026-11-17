namespace VERRA_Wordlist.Business
{
    using VERRA_Wordlist.Business.Interfaces;

    public class InitApplication
    {
        private readonly string _filePath = "../Source/wordlist.txt";

        private readonly IWordManager _wordManager;

        public InitApplication(IWordManager wordManager)
        {
            _wordManager = wordManager;
        }

        public async Task Run()
        {
            string fileText = await _wordManager.GetInputText(_filePath);

            _wordManager.GetMatchedWords(_wordManager.GetList(fileText));
        }
    }
}
