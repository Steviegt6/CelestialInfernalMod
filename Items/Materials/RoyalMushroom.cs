using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Materials
{
	public class RoyalMushroom : ModItem
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Royal Mushroom");
			Tooltip.SetDefault("This type of mushroom seems to be quite rare");
        }

		public override void SetDefaults()
        {
			item.width = 14;
			item.height = 14;
			item.maxStack = 99;
			item.value = Item.buyPrice(0, 0, 1, 0);
			item.rare = 4;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
        }
	}
}
