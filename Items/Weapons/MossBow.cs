using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class MossBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mossbow"); 
		}

		public override void SetDefaults()
		{
			item.damage = 62;
			item.width = 38;
			item.height = 60;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.rare = 7;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 189;
			item.shootSpeed = 10f;
			item.ranged = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeesKnees);
			recipe.AddIngredient(ItemID.TatteredBeeWing);
            recipe.AddIngredient(ItemID.TempleKey);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}