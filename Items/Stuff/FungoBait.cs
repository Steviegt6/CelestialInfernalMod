using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Stuff
{
	public class FungoBait : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fungo Fry");
			Tooltip.SetDefault("The uncommon funkyfish");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.maxStack = 99;
			item.value = Item.buyPrice(0, 2, 50, 0);
			item.rare = 4;
			item.consumable = true;
            item.bait = 30;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(2436, 1);
			recipe.AddIngredient(183, 10);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(2437, 1);
			recipe.AddIngredient(183, 10);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(2438, 1);
			recipe.AddIngredient(183, 10);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
