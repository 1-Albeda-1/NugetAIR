using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetAir
{
    public class ReysWF<T> where T : class
    {
        private List<T> reyses = new List<T>();

        public ReysWF() { }

        public List<T> GetList()
        {
            return reyses;
        }
        public void Add(T arg)
        {
            reyses.Add(arg);
        }
        public void Remove(T arg)
        {
            reyses.Remove(arg);
        }
        public void Change(T id,T arg)
        {
            var index = reyses.IndexOf(id);
            reyses[index] = arg;
        }
    }
}
