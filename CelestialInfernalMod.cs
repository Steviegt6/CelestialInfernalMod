using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Weapons.Melee;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod
{
	public class CelestialInfernalMod : Mod
	{
        private static ModRecipe GetNewRecipe() => new ModRecipe(ModContent.GetInstance<CelestialInfernalMod>());

		public override void AddRecipes()
		{
            ModRecipe recipe = GetNewRecipe();
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Torch, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WandofSparking, 1);
			recipe.AddRecipe();

			recipe = GetNewRecipe();
			recipe.AddIngredient(ModContent.ItemType<Rallyrang>());
			recipe.AddIngredient(ModContent.ItemType<EnchantedShard>(), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedBoomerang);
			recipe.AddRecipe();

			recipe = GetNewRecipe();
			recipe.AddIngredient(ModContent.ItemType<EnchantedShard>(), 8);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();

			recipe = GetNewRecipe();
			recipe.AddIngredient(ModContent.ItemType<EnchantedShard>(), 8);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();
		}
	}
}