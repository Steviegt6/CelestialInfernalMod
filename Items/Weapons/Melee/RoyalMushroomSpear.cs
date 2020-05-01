using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Melee;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class RoyalMushroomSpear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lentinula Lance"); 
			Tooltip.SetDefault("Careful, it's funky.");
		}

		public override void SetDefaults() 
		{
			item.damage = 12;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 0, 75, 0);
			item.rare = 1;
            item.noUseGraphic = true;
            item.noMelee = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<ShiitakeSpear>();
			item.shootSpeed = 6f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<RoyalMushroom>(), 12);
			recipe.AddIngredient(ItemID.WoodFishingPole);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}