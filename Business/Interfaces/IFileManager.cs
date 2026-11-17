namespace VERRA_Wordlist.Business.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public  interface IFileManager
    {
        bool _success { get; }

        Task<string> ReadFile(string filePath);
    }
}
