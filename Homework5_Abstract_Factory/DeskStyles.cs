using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Abstract_Factory
{
    class ClassicDesk : Desk
    {
        public string material { get; }
        public ClassicDesk(int price) : base(price, "Rectangle")
        {
            material = "Oak Wood";
        }
        public override string ToString() => $"ClassicDesk (Shape: {shape}, Price: {price}, Material: {material})";
    }

    class ModernDesk : Desk
    {
        public bool hasWirelessCharger { get; }
        public ModernDesk(int price) : base(price, "L-Shape")
        {
            hasWirelessCharger = true;
        }
        public override string ToString() => $"ModernDesk (Shape: {shape}, Price: {price}, Wireless Charging: {hasWirelessCharger})";
    }

    class ScandinavianDesk : Desk
    {
        public bool isFoldable { get; }
        public ScandinavianDesk(int price) : base(price, "Rounded")
        {
            isFoldable = true;
        }
        public override string ToString() => $"ScandinavianDesk (Shape: {shape}, Price: {price}, Foldable: {isFoldable})";
    }

    class VintageDesk : Desk
    {
        public string finishType { get; }
        public VintageDesk(int price) : base(price, "Vintage")
        {
            finishType = "Distressed Paint";
        }
        public override string ToString() => $"VintageDesk (Shape: {shape}, Price: {price}, Finish: {finishType})";
    }

}
