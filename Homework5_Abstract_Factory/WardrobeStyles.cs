using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Abstract_Factory
{
    class ClassicWardrobe : Wardrobe
    {
        public int shelfCount { get; }
        public ClassicWardrobe(int price) : base(price, "Walnut")
        {
            shelfCount = 5;
        }
        public override string ToString() => $"ClassicWardrobe (Color: {color}, Price: {price}, Shelves: {shelfCount})";
    }

    class ModernWardrobe : Wardrobe
    {
        public bool hasLEDLighting { get; }
        public ModernWardrobe(int price) : base(price, "White Gloss")
        {
            hasLEDLighting = true;
        }
        public override string ToString() => $"ModernWardrobe (Color: {color}, Price: {price}, LED: {hasLEDLighting})";
    }

    class ScandinavianWardrobe : Wardrobe
    {
        public string woodType { get; }
        public ScandinavianWardrobe(int price) : base(price, "Pine")
        {
            woodType = "Light Pine";
        }
        public override string ToString() => $"ScandinavianWardrobe (Color: {color}, Price: {price}, Wood: {woodType})";
    }

    class VintageWardrobe : Wardrobe
    {
        public bool hasMirror { get; }
        public VintageWardrobe(int price) : base(price, "Mahogany")
        {
            hasMirror = true;
        }
        public override string ToString() => $"VintageWardrobe (Color: {color}, Price: {price}, Mirror: {hasMirror})";
    }
}
