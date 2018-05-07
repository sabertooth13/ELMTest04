using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ComputeTotalValueBase
    {
        public abstract decimal ComputeTotalValue(CartLine cartLine);
    }
}
