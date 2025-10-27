using GildedRose.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Domain.Models
{
    /// <summary>
    /// Representa un ítem "Conjured" (conjurado).
    /// Estos ítems degradan su calidad el doble de rápido que los normales:
    ///  - Antes de expirar: -2 de calidad por día.
    ///  - Después de expirar: -4 de calidad por día.
    /// </summary>
    public class ItemEncapsuladoConjured : ItemEncapsuladoBase
    {
        public ItemEncapsuladoConjured(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            // 1. Degradar la calidad el doble de rápido (-2)
            DecreaseQuality(2);

            // 2. Reducir el SellIn (pasa un día)
            DecreaseSellIn();

            // 3. Si el ítem ha expirado, vuelve a degradar el doble (-2 adicionales)
            if (IsExpired)
            {
                DecreaseQuality(2);
            }
        }
    }
}