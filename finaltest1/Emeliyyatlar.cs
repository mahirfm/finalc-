using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltest1
{
    public class EmeliyyatlarGeneric<T> : IEnumerable<T> where T : class, IEquatable<T>
    {
        T[] datalar = new T[0];


        public void Add(T item)
        {
            int len = datalar.Length;

            Array.Resize(ref datalar, len + 1);

            datalar[len] = item;

        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(datalar, item);

            if (index != -1)
            {
                for (int i = index; i < datalar.Length - 1; i++)
                {
                    datalar[i] = datalar[i + 1];

                }

                Array.Resize(ref datalar, datalar.Length - 1);








            }


        }






        public IEnumerator<T> GetEnumerator()
        {
            foreach
                (var item in datalar)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
