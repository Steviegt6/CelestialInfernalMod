using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class SpookySword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Spooky Sword"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 70;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
        {
			target.AddBuff(BuffID.OnFire, 250);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpookyWood, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}