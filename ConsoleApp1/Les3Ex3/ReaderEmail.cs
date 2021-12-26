using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Les3Ex3
{
    internal class ReaderEmail
    {
        string _inputFileName;
        string _outputFileName;
        List<string> _eMailList;


        public ReaderEmail(string inputFileName, string outputFileName)
        {
            _inputFileName = inputFileName;
            _outputFileName = outputFileName;
            _eMailList = new List<string>();
        }

        public void GetFileEmail()
        {
            ReadFile();
            WriteFile();
        }

        private void WriteFile()
        {
            if (_eMailList.Any())
            {
                FileStream fs = new FileStream(_outputFileName, FileMode.OpenOrCreate);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var eMail in _eMailList)
                    {
                        sw.WriteLine(eMail);
                    }
                }
            }
        }

        private void ReadFile()
        {
            FileStream fs = new FileStream(_inputFileName, FileMode.Open);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    SearchMail(ref line);
                    if (!line.Equals(""))
                    {
                        _eMailList.Add(line);
                    }
                }
            }
        }

        void SearchMail(ref string s)
        {
            var parts = s.Split('&');

            if (parts.Length != 2)
            {
                s = string.Empty;
                return;
            }

            string pattern = @"\w*@\w*.\w*"; // простая регулярка для опеределения email

            if (Regex.IsMatch(parts[1], pattern, RegexOptions.IgnoreCase))
            {
                s = parts[1].Trim();
            }
            else
            {
                s = string.Empty;
            }
        }
    }
}
