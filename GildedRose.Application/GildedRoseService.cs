using GildedRose.Domain.Entities;
using GildedRoseKata.Domain.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Application
{
    public class GildedRoseService
    {
        /// <summary>
        /// Orquestador principal del sistema.
        /// Recorre los ítems del inventario y delega su actualización
        /// a la clase encapsulada correspondiente.
        /// </summary>

        private readonly IList<Item> _items;

        public GildedRoseService(IList<Item> items)
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
}