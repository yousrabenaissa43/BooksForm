using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLsite
{
    public class SpellBook : Book
    {
        public MagicType magicType {  get; private set; }

      
        public SpellBook(int serial, string title, MagicType typeOfMagic) : base(serial, title)
        { 
            magicType = typeOfMagic;
        }
        public SpellBook() : base()
        {
        }
        public override string GetExtandedInfos()
        {
           return  base.getInfos() + $"contains {magicType} spells" ; 
        }
        public override void CalculatedExtandedValue()
        {
            base.CalculatedValue();
            if(magicType == MagicType.Enchantment)
            {
                Value = Value * 5;
            }
            if (magicType == MagicType.Transmutation)
            {
                Value = Value * 15;
            }
            if (magicType == MagicType.Cruse)
            {
                Value = Value * 2;
            }
        }
    }
}
