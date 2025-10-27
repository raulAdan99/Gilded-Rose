using GildedRose.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Domain.Models
{
    /// <summary>
    /// Clase base que encapsula un Item del sistema legado.
    /// Define la estructura común y las reglas globales (0 ≤ Quality ≤ 50).
    /// Todas las subclases implementan su propio comportamiento en UpdateQuality().
    /// </summary>
    public abstract class ItemEncapsuladoBase
    {
        protected readonly Item _item;
        private Item item;

        protected ItemEncapsuladoBase(Item item)
        {
            _item = item;
        }


        public string Name => _item.Name;
        public int SellIn => _item.SellIn;
        public int Quality => _item.Quality;

        /// <summary>
        /// Método que cada tipo de ítem debe implementar con sus reglas de actualización.
        /// </summary>
        public abstract void UpdateQuality();

        /// <summary>
        /// Aumenta la calidad en la cantidad indicada, sin superar 50.
        /// </summary>
        protected void IncreaseQuality(int amount = 1)
        {
            _item.Quality = Math.Min(_item.Quality + amount, 50);
        }

        /// <summary>
        /// Reduce la calidad en la cantidad indicada, sin bajar de 0.
        /// </summary>
        protected void DecreaseQuality(int amount = 1)
        {
            _item.Quality = Math.Max(_item.Quality - amount, 0);
        }

        /// <summary>
        /// Reduce el SellIn en 1 (paso de un día).
        /// </summary>
        protected void DecreaseSellIn()
        {
            _item.SellIn -= 1;
        }

        /// <summary>
        /// Establece la calidad en 0 (usado por Backstage al expirar).
        /// </summary>
        protected void SetQualityToZero()
        {
            _item.Quality = 0;
        }

        /// <summary>
        /// Devuelve true si el ítem ya ha expirado (SellIn < 0).
        /// </summary>
        protected bool IsExpired => _item.SellIn < 0;
    }
}