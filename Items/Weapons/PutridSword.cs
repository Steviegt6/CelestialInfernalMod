using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class PutridSword : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Light's Butcherer"); 
			Tooltip.SetDefault("Inflicts the powers of both evil components");
		}
		public override void SetDefaults() 
		{
			item.damage = 37;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 2, 70, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.5f;
		}
         public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
        {
			target.AddBuff(39, 120);
            target.AddBuff(69, 120);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PutridVertebrae"), 10); //modded materials
			recipe.AddIngredient(46, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PutridVertebrae"), 10); //modded materials
			recipe.AddIngredient(795, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}