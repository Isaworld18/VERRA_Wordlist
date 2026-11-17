namespace VERRA_Wordlist.Business
{
    using VERRA_Wordlist.Business.Interfaces;

    public class InitApplication
    {
        private readonly IWordManager _wordManager;

        public InitApplication(IWordManager wordManager)
        {
            _wordManager = wordManager;
        }

        public void Run()
        { 
        
        }
    }
}
