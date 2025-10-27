using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Core
{
    /// <summary>
    /// Representa el ítem legendario "Sulfuras, Hand of Ragnaros".
    /// Este ítem:
    ///  - No cambia su Quality (siempre 80).
    ///  - No cambia su SellIn.
    ///  - Es completamente inmutable.
    /// </summary>
    public class ItemEncapsuladoSulfuras : ItemEncapsuladoBase
    {
        public ItemEncapsuladoSulfuras(Item item) : base(item)
        {
            // Forzar que la calidad de Sulfuras sea 80,
            // incluso si el Item original venía con otro valor.
            _item.Quality = 80;
        }

        public override void UpdateQuality()
        {
            // No hacemos absolutamente nada.
            // La calidad y el SellIn permanecen inmutables.
        }
    }
}