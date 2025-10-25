using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Core
{
    public class ItemEncapsuladoAgedBrie : ItemEncapsuladoBase
    {
        public ItemEncapsuladoAgedBrie(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            // 1. Aumentar la calidad en 1 punto
            IncreaseQuality();

            // 2. Reducir el SellIn en 1 (pasa un día)
            DecreaseQuality();

            //3. Si el ítem ha expirado , (SellIn < 0 ) aumentar la calidad otra vez

            if (IsExpired)
            {
                IncreaseQuality();
            }
        }
    }
}
