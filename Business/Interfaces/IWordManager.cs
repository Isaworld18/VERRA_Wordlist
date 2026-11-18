namespace VERRA_Wordlist.Business.Interfaces
{
    using System.Collections.Generic;

    public interface IWordManager
    {
        bool Success { get; }

        Task<string> GetInputText(string filePath);

        List<string> GetList(string text);

        List<string> GetMatchedWords(List<string> SourceList);
    }
}
