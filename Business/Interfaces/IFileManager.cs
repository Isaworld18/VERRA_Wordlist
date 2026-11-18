namespace VERRA_Wordlist.Business.Interfaces
{
    public  interface IFileManager
    {
        bool _success { get; }

        Task<string> ReadFile(string filePath);
    }
}
