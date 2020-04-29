using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Tools
{
	public class AntlionPickaxe : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 10;
			item.width = 32;
			item.height = 32;
			item.useTime = 6;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 3.25f;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.melee = true;

			item.pick = 25;
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3509, 1); //modded materials
            recipe.AddIngredient(323, 12); //modded materials
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(3503, 1); //modded materials
            recipe.AddIngredient(323, 12); //modded materials
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
