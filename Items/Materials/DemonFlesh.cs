using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Materials
{
	public class DemonFlesh : ModItem
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Demon Flesh");
			Tooltip.SetDefault("A piece of flesh that was part of a powerful demon");
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
