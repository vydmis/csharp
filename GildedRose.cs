using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            // Refactored UpdateQuality method

            foreach (Item item in Items)
            {
                updateItem(item);
            }
        }

        public void updateItem(Item item)
        {
            //Created new method updateItem

            if (item.Name == "Aged Brie")
            {
                AgedBrieProcessor(item);
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                BackstageProcessor(item);
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                SulfurasProcessor(item);
            }
            else if (item.Name == "Conjured Mana Cake")
            {
                ConjuredProcessor(item);
            }
            else 
            {
                StandartProcessor(item);
            }
            
        }

        private Item AgedBrieProcessor(Item item)
        {
            // Created method for each property

            if (--item.SellIn < 0)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }

            return item;
        }

        private Item BackstageProcessor(Item item)
        {
            // Created method for each property

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 5)
            {
                item.Quality += 3;
            }
            else if (item.SellIn < 10)
            {
                item.Quality += 2;
            }
            else 
            {
                item.Quality ++;
            }

            if (item.Quality > 50)
            {
                item.Quality = 50;
            }

            return item;
        }

        private Item SulfurasProcessor(Item item)
        {
            // Created method for each property

            //emty function on this moment

            return item;
        }

        private Item StandartProcessor(Item item)
        {
            // Created method for each property

            if (--item.SellIn < 0)
            {
                item.Quality -= 2;
            }
            else 
            {
                item.Quality--;
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

            return item;
        }

        private Item ConjuredProcessor(Item item)
        {
            // Created method for each property

            if (--item.SellIn < 0)
            {
                item.Quality -= 4;
            }
            else
            {
                item.Quality -= 2;
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

            return item;
        }
    }
}
