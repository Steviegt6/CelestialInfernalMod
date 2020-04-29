using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ore
{
	public class PalladiumThrowaxe : ModItem
	{

		public override void SetDefaults() 
		{
			item.damage = 41;
			item.thrown = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 10;
            item.noMelee = true;
            item.noUseGraphic = true;
			item.value = Item.buyPrice(0, 9, 20, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("PalladiumThrowaxe");
			item.shootSpeed = 11f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1184, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}