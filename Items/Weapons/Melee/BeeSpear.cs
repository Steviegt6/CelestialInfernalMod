using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Melee;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class BeeSpear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Stinger"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 24;
			item.melee = true;
			item.width = 44;
			item.height = 44;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 2, 70, 0);
			item.rare = 3;
            item.noUseGraphic = true;
            item.noMelee = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<Sbeear>();
			item.shootSpeed = 8f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}