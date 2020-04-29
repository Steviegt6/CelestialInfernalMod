using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class BlizzardBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blizzard Blade"); 
			Tooltip.SetDefault("Enpowered by demonic forces");
		}

		public override void SetDefaults() 
		{
			item.damage = 66;
			item.melee = true;
			item.width = 54;
			item.height = 54;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 9f;
			item.value = Item.buyPrice(0, 54, 0, 0);
			item.rare = 7;
			item.UseSound = SoundID.Item1;
            item.shoot = 119;
            item.shootSpeed = 21.5f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(676, 1);
            recipe.AddIngredient(724, 1);
			recipe.AddIngredient(1570, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}