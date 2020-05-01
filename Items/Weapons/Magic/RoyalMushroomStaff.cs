using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Materials;
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class RoyalMushroomStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Mushroom Staff"); 
            Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 1;
			item.knockBack = 2;
			item.noMelee = true;
			item.mana = 14;
			item.UseSound = SoundID.Item21;
			item.shoot = ModContent.ProjectileType<RoyalMushroomBolt>();
			item.shootSpeed = 10f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<RoyalMushroom>(), 16);
			recipe.AddIngredient(ItemID.GlowingMushroom, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}