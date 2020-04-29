using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Throwing
{
	public class CursedKnife : ModItem
	{

		public override void SetDefaults() 
		{
			item.damage = 49;
			item.thrown = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 3;
            item.maxStack = 999;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.consumable = true;
			item.value = Item.buyPrice(0, 0, 5, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("CursedKnife");
			item.shootSpeed = 15f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(279, 100);
            recipe.AddIngredient(522, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}