namespace VERRA_Wordlist.Business.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public  interface IFileManager
    {
        Task<string> ReadFile(string filePath);
    }
}
