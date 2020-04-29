using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Throwing
{
	public class KingKunai : ModItem
	{

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.thrown = true;
			item.width = 22;
			item.height = 48;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5.5f;
            item.noMelee = true;
            item.noUseGraphic = true;
			item.value = Item.buyPrice(0, 2, 0, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("NinjaKunai");
			item.shootSpeed = 10f;
		}
	}
}