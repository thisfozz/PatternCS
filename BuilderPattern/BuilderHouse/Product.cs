using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHouseExampleNamespace
{
    public class Product
    {
        private List<object> _parts = new List<object>(); // представляет список частей продукта. 

        public void Add(string part)
        {
            _parts.Add(part); // добавляет переданную часть part в список _parts
        }

        public string ListParts()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _parts.Count; i++)
            {
                sb.Append(_parts[i]);
                sb.Append(", ");
            }

            return sb.ToString().TrimEnd(',', ' ') + "\n";
        }
    }
}
