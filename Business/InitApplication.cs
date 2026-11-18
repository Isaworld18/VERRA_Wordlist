namespace VERRA_Wordlist.Business
{
    using VERRA_Wordlist.Business.Interfaces;

    public class InitApplication(IWordManager wordManager)
    {
        private readonly string _filePath = "../Source/wordlist.txt";

        private readonly IWordManager _wordManager = wordManager;

        public async Task Run()
        {
            string inputResult = await _wordManager.GetInputText(_filePath);

            if (_wordManager.Success)
            {
                _wordManager.GetMatchedWords(_wordManager.GetList(inputResult));
            }
            else
            {
                Console.WriteLine($"No se pudo completar la operacion, {inputResult}");
            }
        }
    }
}
