using Terraria;
using Terraria.ModLoader;
using CelestialInfernalMod.Tiles;

namespace CelestialInfernalMod.Items.Tiles
{
    public class OozingMetal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oozing Metal");
        }

        public override void SetDefaults()
        {
            item.createTile = ModContent.TileType<OozeOre>();
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.width = 13;
            item.height = 10;
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 5);
            item.rare = 1;
        }
    }
}
