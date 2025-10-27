using GildedRoseKata.Core;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    /// <summary>
    /// Orquestador principal del sistema.
    /// Recorre los ítems del inventario y delega su actualización
    /// a la clase encapsulada correspondiente.
    /// </summary>

        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var encapsulado = ItemEncapsuladoFactory.Create(item);
                encapsulado.UpdateQuality();
            }
        }
   }
