using System.Linq;
using System.Text;

namespace Les7
{
    public class ACoder : ICoder
    {
        char[] _alphabet = {'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я',
                            'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я' };
        StringBuilder _sr;
        public int Step { get; set; }

        public ACoder() : this(1)
        {
        }

        public ACoder(int step)
        {
            Step = step;
        }

        public string Decode(string baseString)
        {
            return Converter(baseString, -Step);
        }

        public string Encode(string baseString)
        {
            return Converter(baseString, Step);
        }

        private string Converter(string baseString, int step)
        {
            _sr = new StringBuilder();
            foreach (char item in baseString)
            {
                if (_alphabet.Any(str => str == item))
                {
                    for (int i = 0; i < _alphabet.Length; i++)
                    {
                        if (item != _alphabet[i])
                        {
                            continue;
                        }
                        _sr.Append(_alphabet[GetIndex(i, step % 33)]);
                        break;
                    }
                }
                else 
                {
                    _sr.Append(item);
                }
  
            }
            return _sr.ToString();
        }

        private int GetIndex(int index, int correct)
        {
            if ((index + correct) / 33 > index / 33)
            {
                index -= 33;
            }
            else if (index + correct < 0 || (index + correct) / 33 < index / 33)
            {
                index += 33;
            }

            return index + correct;
        }
    }
}
