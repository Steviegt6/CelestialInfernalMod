using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Throwing;

namespace CelestialInfernalMod.Items.Weapons.Throwing
{
	public class LeadCutlery : ModItem
	{

		public override void SetDefaults() 
		{
			item.damage = 13;
			item.thrown = true;
			item.width = 26;
			item.height = 28;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 2;
            item.maxStack = 999;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.consumable = true;
			item.value = Item.buyPrice(0, 0, 2, 50);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<LeadCutleryProj>();
			item.shootSpeed = 6f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}