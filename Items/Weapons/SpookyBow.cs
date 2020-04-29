using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class SpookyBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spooky Bow");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.width = 40;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 8;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 1;
			item.shootSpeed = 6f;
			item.ranged = true;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
        {
			target.AddBuff(67, 250);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1729, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(9, 10);
            recipe.AddIngredient(8, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(3069, 1);
			recipe.AddRecipe();
		}
	}
}