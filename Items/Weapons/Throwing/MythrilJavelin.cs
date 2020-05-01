using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Throwing;
namespace CelestialInfernalMod.Items.Weapons.Throwing
{
	public class MythrilJavelin : ModItem
	{

		public override void SetDefaults() 
		{
			item.damage = 44;
			item.thrown = true;
			item.width = 44;
			item.height = 44;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.knockBack = 6;
            item.noMelee = true;
            item.noUseGraphic = true;
			item.value = Item.buyPrice(0, 10, 35, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<MythrilJavelin>();
			item.shootSpeed = 12f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MythrilBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}