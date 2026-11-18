namespace VERRA_Wordlist.Business.Interfaces
{
    public  interface IFileManager
    {
        bool Success { get; }

        Task<string> ReadFile(string filePath);
    }
}
