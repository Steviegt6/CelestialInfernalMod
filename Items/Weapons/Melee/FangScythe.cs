using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class FangScythe : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Fang Scythe");
			Tooltip.SetDefault("Unreal...");
		}

		public override void SetDefaults() 
		{
			item.damage = 64;
			item.melee = true;
			item.width = 50;
			item.height = 42;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 16, 0, 0);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpiderFang, 16); 
            recipe.AddIngredient(ItemID.BorealWoodTable);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}