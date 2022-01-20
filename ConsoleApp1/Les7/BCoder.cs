using System.Linq;
using System.Text;

namespace Les7
{
    public class BCoder : ICoder
    {
        char[] _upperAlphabet = {'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я'};
        char[] _lowerAlphabet = {'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я'};
        StringBuilder _sr;

        public string Decode(string baseString)
        {
            return Coding(baseString);
        }

        public string Encode(string baseString)
        {
            return Coding(baseString);
        }

        private string Coding(string baseString)
        {
            _sr = new StringBuilder();
            foreach (char item in baseString)
            {
                if (_upperAlphabet.Any(str => str == item))
                {
                    GetChar(item, _upperAlphabet);
                }
                else if (_lowerAlphabet.Any(str => str == item))
                {
                    GetChar(item, _lowerAlphabet);
                }
                else
                {
                    _sr.Append(item);
                }

            }
            return _sr.ToString();
        }

        private void GetChar(char item, char[] workAlphabet)
        {
            for (int i = 0; i < workAlphabet.Length; i++)
            {
                if (item != workAlphabet[i])
                {
                    continue;
                }
                _sr.Append(workAlphabet[workAlphabet.Length - 1 - i]);
                break;
            }
        }
    }
}
