using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class DemonicBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("RoyalMushroomBow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			item.damage = 24;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 2;
			item.noMelee = true;
            item.knockBack = 10;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 1;
			item.shootSpeed = 9f;
			item.ranged = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DemonFlesh>(), 18);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}