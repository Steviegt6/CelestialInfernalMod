using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Throwing;

namespace CelestialInfernalMod.Items.Weapons.Throwing
{
	public class CobaltKnife : ModItem
	{

		public override void SetDefaults() 
		{
			item.damage = 39;
			item.thrown = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 1;
			item.knockBack = 10;
            item.noMelee = true;
            item.noUseGraphic = true;
			item.value = Item.buyPrice(0, 6, 90, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<CobaltKnife>();
			item.shootSpeed = 10f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}