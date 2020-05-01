using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Materials
{
	public class EnchantedShard : ModItem
	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Enchanted Shard");
			Tooltip.SetDefault("Blessed with astral power");
        }

		public override void SetDefaults()
        {
			item.width = 14;
			item.height = 14;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 0, 50, 0);
			item.rare = 1;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(706, 1);
			recipe.AddIngredient(75, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(19, 1);
			recipe.AddIngredient(75, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
