using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Stuff
{
	public class HardenedWood : ModItem
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Hardened Wood");
			Tooltip.SetDefault("Wood that got fossilized and hardened after spending time underground.");
        }

		public override void SetDefaults()
        {
			item.width = 32;
			item.height = 25;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = 3;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
        }
	}
}
