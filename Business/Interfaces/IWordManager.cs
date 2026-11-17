namespace VERRA_Wordlist.Business.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IWordManager
    {
        Task<string> GetWordList(string filePath);
    }
}
