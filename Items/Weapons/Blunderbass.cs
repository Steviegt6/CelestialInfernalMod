using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class Blunderbass : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("RoyalMushroomBow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Is this how the Minishark was made?");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.width = 46;
			item.height = 28;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 0, 50, 0);
			item.rare = 0;
			item.noMelee = true;
            item.knockBack = 3;
			item.useAmmo = AmmoID.Bullet;
			item.UseSound = SoundID.Item11;
			item.shoot = 14;
			item.shootSpeed = 9f;
            item.autoReuse = true;
			item.ranged = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bass);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 70);
			recipe.AddIngredient(ItemID.TungstenBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SilverBullet, 70);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MusketBall, 50);
			recipe.AddRecipe();
		}
	}
}