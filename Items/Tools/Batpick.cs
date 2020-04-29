using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Tools
{
	public class Batpick : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 16;
			item.width = 32;
			item.height = 32;
			item.useTime = 8;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.melee = true;
			item.pick = 65;
		}
	}
}
