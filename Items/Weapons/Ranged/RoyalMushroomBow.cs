using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class RoyalMushroomBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Mushroom Bow"); 
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 0, 85, 0);
			item.rare = 1;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 1;
			item.shootSpeed = 5f;
			item.ranged = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<RoyalMushroom>(), 18);
			recipe.AddIngredient(ItemID.Mushroom, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}