using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class FeatherBane : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Feathered Sword");
			Tooltip.SetDefault("It's not a crimson bull, but it still makes an impact");
		}

		public override void SetDefaults() 
		{
			item.damage = 24;
			item.melee = true;
			item.width = 50;
			item.height = 42;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 4.5f;
			item.value = Item.buyPrice(0, 1, 50, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 10); 
            recipe.AddIngredient(ItemID.LightsBane);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 10); 
            recipe.AddIngredient(ItemID.BloodButcherer);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            
		}
	}
}