using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Materials
{
	public class StrangeGel : ModItem
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Strange Gel"); 
			Tooltip.SetDefault("It's really gooey");
        }

		public override void SetDefaults()
        {
			item.width = 14;
			item.height = 22;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 0, 20, 0);
			item.rare = 1;
        }
	}
}
