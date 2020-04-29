using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Stuff
{
	public class BrokenHeroBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Hero Bow");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.width = 20;
			item.height = 40;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 8;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 1;
			item.shootSpeed = 1f;
			item.ranged = true;
		}
	}
}