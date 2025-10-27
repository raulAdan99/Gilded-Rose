using GildedRose.Domain.Entities;
using GildedRoseKata.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Domain.Factory
{
    /// <summary>
    /// Factoría responsable de crear la instancia correcta de ItemEncapsulado
    /// según el nombre del ítem original.
    /// Esta clase es el puente entre los Items del sistema legado y
    /// las clases modernas que encapsulan su comportamiento.
    /// </summary>
    public static class ItemEncapsuladoFactory
    {
        /// <summary>
        /// Crea el objeto ItemEncapsulado correspondiente según el nombre del ítem.
        /// </summary>
        /// <param name="item">El ítem original proveniente del sistema legado.</param>
        /// <returns>Una instancia del tipo de ItemEncapsulado adecuado.</returns>
        public static ItemEncapsuladoBase Create(Item item)
        {
            // 1. Validación defensiva mínima
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            // 2. Lógica de selección según el nombre del ítem
            if (item.Name == "Aged Brie")
                return new ItemEncapsuladoAgedBrie(item);

            if (item.Name.StartsWith("Backstage passes"))
                return new ItemEncapsuladoBackstage(item);

            if (item.Name.StartsWith("Sulfuras"))
                return new ItemEncapsuladoSulfuras(item);

            if (item.Name.StartsWith("Conjured"))
                return new ItemEncapsuladoConjured(item);

            // 3. Por defecto, devolver un ítem normal
            return new ItemEncapsuladoNormal(item);
        }
    }
}