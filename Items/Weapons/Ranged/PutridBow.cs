using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Stuff;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class PutridBow : ModItem
	{

		public override void SetDefaults()
		{
			item.damage = 30;
			item.width = 40;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 2, 10, 0);
			item.rare = 3;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 4;
			item.shootSpeed = 4.8f;
			item.ranged = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<PutridVertebrae>(), 18); //modded materials
			recipe.AddIngredient(ItemID.DemonBow);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<PutridVertebrae>(), 18); //modded materials
			recipe.AddIngredient(ItemID.TendonBow);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}