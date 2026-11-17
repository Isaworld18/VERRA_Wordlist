namespace VERRA_Wordlist.Business.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IWordManager
    {
        bool _success { get; }

        Task<string> GetInputText(string filePath);

        List<string> GetList(string text);

        List<string> GetMatchedWords(List<string> SourceList);
    }
}
