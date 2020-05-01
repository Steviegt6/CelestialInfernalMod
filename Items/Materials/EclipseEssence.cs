using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Materials
{
	public class EclipseEssence : ModItem
	{
		public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("The eclipse elemental's remainings");
        }

		public override void SetDefaults()
        {
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 5;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
        }
	}
}
