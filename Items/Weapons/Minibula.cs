using CelestialInfernalMod.Projectiles.Magic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class Minibula : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mini-Nebula Gun"); 
            Tooltip.SetDefault("Fires floater lasers");
		}

		public override void SetDefaults()
		{
			item.damage = 125;
			item.width = 38;
			item.height = 36;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 9;
			item.knockBack = 8;
			item.noMelee = true;
			item.mana = 13;
			item.UseSound = SoundID.Item75;
			item.shoot = ModContent.ProjectileType<Friendlaser>();
			item.shootSpeed = 15f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LaserRifle);
			recipe.AddIngredient(ItemID.FragmentNebula, 12);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}