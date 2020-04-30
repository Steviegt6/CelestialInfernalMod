using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Stuff;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class HardenedWoodSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Hardened Wood Sword"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 38;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
            item.scale = 1f;
			item.value = Item.buyPrice(0, 0, 75, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<HardenedWood>(), 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}