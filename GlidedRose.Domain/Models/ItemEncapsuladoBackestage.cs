using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Core
{
    /// <summary>
    /// Representa el ítem "Backstage passes to a TAFKAL80ETC concert".
    /// Aumenta su calidad a medida que se acerca la fecha del concierto:
    ///  - +1 si faltan más de 10 días.
    ///  - +2 si faltan 10 días o menos.
    ///  - +3 si faltan 5 días o menos.
    ///  Una vez pasado el concierto (SellIn < 0), su calidad cae a 0.
    /// </summary>
    public class ItemEncapsuladoBackstage : ItemEncapsuladoBase
    {
        public ItemEncapsuladoBackstage(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            // 1. Siempre aumenta la calidad al menos en +1
            IncreaseQuality();

            // 2. Si faltan 10 días o menos, aumenta +1 adicional
            if (_item.SellIn <= 10)
            {
                IncreaseQuality();
            }

            // 3. Si faltan 5 días o menos, aumenta +1 adicional
            if (_item.SellIn <= 5)
            {
                IncreaseQuality();
            }

            // 4. Disminuir el SellIn en 1 (pasa un día)
            DecreaseSellIn();

            // 5. Si el concierto ya pasó, la calidad cae a 0
            if (IsExpired)
            {
                SetQualityToZero();
            }
        }
    }
}