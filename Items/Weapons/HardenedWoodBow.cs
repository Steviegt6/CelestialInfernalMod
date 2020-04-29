using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class HardenedWoodBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hardened Wood Bow"); 
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.width = 17;
			item.height = 32;
			item.useTime = 24;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 0, 55, 0);
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
			recipe.AddIngredient(mod.ItemType("HardenedWood"), 15);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}