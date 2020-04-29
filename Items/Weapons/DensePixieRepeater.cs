using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class DensePixieRepeater : ModItem
	{

		public override void SetDefaults()
		{
			item.damage = 24;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 18, 0, 0);
			item.rare = 5;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 91;
            item.knockBack = 3f;
			item.shootSpeed = 10f;
			item.autoReuse = true;
			item.ranged = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DensePixieDust"), 18); //modded materials
			recipe.AddIngredient(ItemID.AdamantiteRepeater);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DensePixieDust"), 18); //modded materials
			recipe.AddIngredient(ItemID.TitaniumRepeater);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}