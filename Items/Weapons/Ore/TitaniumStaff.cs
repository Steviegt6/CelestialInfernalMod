using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ore
{
	public class TitaniumStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Titanium Staff"); 
			Tooltip.SetDefault("Shoots hard-hitting titanium bolts");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.width = 44;
			item.height = 44;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 16, 0, 0);
			item.rare = 4;
			item.knockBack = 25;
			item.noMelee = true;
			item.mana = 10;
			item.UseSound = SoundID.Item21;
			item.shoot = 88;
			item.shootSpeed = 20f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1198, 10);
			recipe.AddIngredient(1527, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}