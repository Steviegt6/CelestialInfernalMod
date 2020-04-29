using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class Rallyrang : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Checkers"); 
			Tooltip.SetDefault("Crazy good");
		}

		public override void SetDefaults() 
		{
			item.damage = 12;
			item.melee = true;
			item.width = 18;
			item.height = 32;
			item.useTime = 25;
			item.useAnimation = 25;
			item.knockBack = 5;
			item.value = Item.buyPrice(0, 2, 50, 0);
			item.rare = 1;
            item.useStyle = 1;
            item.noUseGraphic = true;
            item.shoot = mod.ProjectileType("Rallyrang");
			 item.shootSpeed = 8f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(mod.ItemType("EnchantedShard"), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedBoomerang);
			recipe.AddRecipe();
		}
	}
}