using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyotaAbstractFactory
{
    abstract class ToyotaFactory
    {
        public abstract Toyota CreateModel();
    }
}
