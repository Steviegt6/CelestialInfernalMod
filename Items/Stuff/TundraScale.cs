using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Stuff
{
	public class TundraScale : ModItem
	{
		public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("The scales of a worm made of snow, ice, and memories");
        }

		public override void SetDefaults()
        {
			item.width = 14;
			item.height = 22;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.rare = 8;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
        }
	}
}
