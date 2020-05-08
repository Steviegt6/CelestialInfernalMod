using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Tools
{
	public class DensePixieHamaxe : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 45;
			item.width = 32;
			item.height = 32;
			item.useTime = 12;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 12, 50, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.melee = true;
			item.hammer = 90;
			item.axe = 25;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DensePixieDust"), 14); //modded materials
			recipe.AddIngredient(ItemID.PixieDust, 10);
			recipe.AddIngredient(ItemID.Pearlwood, 4); //vanilla materials
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
