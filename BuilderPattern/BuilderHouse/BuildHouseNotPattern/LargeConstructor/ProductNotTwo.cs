using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderPattern.BuilderHouse.BuildHouseNotPattern.LargeConstructor
{
    public class ProductNotTwo : IEnumerable
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public IEnumerator GetEnumerator()
        {
            return _parts.GetEnumerator();
        }
    }
}
