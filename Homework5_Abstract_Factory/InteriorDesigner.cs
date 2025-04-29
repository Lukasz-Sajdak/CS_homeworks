using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Abstract_Factory
{
    abstract class InteriorDesigner
    {
        public abstract Desk ProduceDesk(int priceLimit);
        public abstract Wardrobe ProduceWardrobe(int priceLimit);
    }
}
