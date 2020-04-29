using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class StarWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Wand"); 
            Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.width = 36;
			item.height = 36;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 1, 20, 0);
			item.rare = 1;
			item.knockBack = 2;
			item.noMelee = true;
			item.mana = 15;
			item.UseSound = SoundID.Item9;
			item.shoot = 12;
			item.shootSpeed = 8f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(75, 5);
			recipe.AddIngredient(751, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}