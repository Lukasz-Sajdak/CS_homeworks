using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Abstract_Factory
{
    class ClassicInteriorDesigner : InteriorDesigner
    {
        public override Desk ProduceDesk(int priceLimit)
        {
            return priceLimit >= 400 ? new ClassicDesk(400) : null;
        }

        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            return priceLimit >= 500 ? new ClassicWardrobe(500) : null;
        }
    }

    class ModernInteriorDesigner : InteriorDesigner
    {
        public override Desk ProduceDesk(int priceLimit)
        {
            return priceLimit >= 600 ? new ModernDesk(600) : null;
        }

        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            return priceLimit >= 700 ? new ModernWardrobe(700) : null;
        }
    }

    class ScandinavianInteriorDesigner : InteriorDesigner
    {
        public override Desk ProduceDesk(int priceLimit)
        {
            return priceLimit >= 350 ? new ScandinavianDesk(350) : null;
        }

        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            return priceLimit >= 450 ? new ScandinavianWardrobe(450) : null;
        }
    }

    class VintageInteriorDesigner : InteriorDesigner
    {
        public override Desk ProduceDesk(int priceLimit)
        {
            return priceLimit >= 350 ? new VintageDesk(350) : null;
        }

        public override Wardrobe ProduceWardrobe(int priceLimit)
        {
            return priceLimit >= 450 ? new VintageWardrobe(450) : null;
        }
    }
}
