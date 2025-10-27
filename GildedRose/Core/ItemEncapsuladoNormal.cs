using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Core
{
    /// <summary>
    /// Representa un ítem normal dentro del sistema.
    /// Los ítems normales degradan su calidad en 1 por día,
    /// y el doble de rápido una vez pasada la fecha de venta (SellIn < 0).
    /// </summary>
    public class ItemEncapsuladoNormal : ItemEncapsuladoBase
    {
        public ItemEncapsuladoNormal(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            // 1. Disminuir la calidad en 1 unidad (si aún tiene calidad > 0)
            DecreaseQuality();

            // 2. Reducir el SellIn en 1 (pasa un día)
            DecreaseSellIn();

            // 3. Si el ítem ya ha expirado, vuelve a disminuir la calidad
            if (IsExpired)
            {
                DecreaseQuality();
            }
        }
    }
}