using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Throwing
{
	public class FangShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Venomous Fang");
			Tooltip.SetDefault("Unreal...");
		}

		public override void SetDefaults() 
		{
			item.damage = 40;
			item.thrown = true;
			item.width = 28;
			item.height = 32;
            item.scale = 1.5f;
			item.useTime = 16;
			item.useAnimation = 16;
            item.consumable = true;
            item.maxStack = 999;
			item.useStyle = 3;
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 0, 30, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpiderFang, 1); 
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}