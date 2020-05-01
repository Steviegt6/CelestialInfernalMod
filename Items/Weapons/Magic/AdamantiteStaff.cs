using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class AdamantiteStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Adamantite Staff"); 
			Tooltip.SetDefault("Fires adamantite lasers");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.width = 48;
			item.height = 48;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 12, 50, 0);
			item.rare = 4;
			item.knockBack = 10;
			item.noMelee = true;
			item.mana = 11;
			item.UseSound = SoundID.Item8;
			item.shoot = ModContent.ProjectileType<AdamantiteLaser>();
			item.shootSpeed = 20f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 10);
			recipe.AddIngredient(ItemID.LargeRuby);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}