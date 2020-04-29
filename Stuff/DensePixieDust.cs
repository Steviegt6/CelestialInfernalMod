using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Stuff
{
	public class DensePixieDust : ModItem
	{
		public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("Pixie dust, but full of power and a lot of them");
        }

		public override void SetDefaults()
        {
			item.width = 14;
			item.height = 14;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 0, 20, 0);
			item.rare = 4;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
        }
	}
}
