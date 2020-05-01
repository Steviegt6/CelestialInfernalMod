using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Materials;
using CelestialInfernalMod.Projectiles.Melee;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class RoyalMushroomSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Royal Mushroom Sword"); 
			Tooltip.SetDefault("Fires a royal mushroom when swung");
		}

		public override void SetDefaults() 
		{
			item.damage = 16;
			item.melee = true;
			item.width = 38;
			item.height = 38;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 0, 65, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<RoyalMushroomProjectile>();
			item.shootSpeed = 8f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<RoyalMushroom>(), 12);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<RoyalMushroom>(), 12);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}