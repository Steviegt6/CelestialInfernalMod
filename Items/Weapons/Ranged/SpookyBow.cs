using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class SpookyBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spooky Bow");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.width = 40;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 8;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 1;
			item.shootSpeed = 6f;
			item.ranged = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpookyWood, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}