using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ore
{
	public class IronCutlery : ModItem
	{

		public override void SetDefaults() 
		{
			item.damage = 12;
			item.thrown = true;
			item.width = 26;
			item.height = 28;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 2;
            item.maxStack = 999;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.consumable = true;
			item.value = Item.buyPrice(0, 0, 2, 0);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("IronCutlery");
			item.shootSpeed = 6f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(22, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}