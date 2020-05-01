using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Materials
{
	public class GreatGel : ModItem
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Great Gastropod's Gel");
			Tooltip.SetDefault("A drop of gel that came from the Great Gastropod");
        }

		public override void SetDefaults()
        {
			item.width = 14;
			item.height = 14;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.rare = 4;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
        }
	}
}
