using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class MoonglowStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonglow Staff"); 
            Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.width = 32;
			item.height = 32;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = 0;
			item.knockBack = 2;
			item.noMelee = true;
			item.mana = 16;
			item.UseSound = SoundID.Item8;
			item.shoot = 118;
			item.shootSpeed = 9f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(314, 3);
			recipe.AddIngredient(3069, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}