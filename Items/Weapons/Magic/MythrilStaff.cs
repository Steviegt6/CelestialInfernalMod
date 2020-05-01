using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class MythrilStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mythril Staff"); 
			Tooltip.SetDefault("Summons emerald bats");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.width = 42;
			item.height = 42;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 9, 0, 0);
			item.rare = 4;
			item.knockBack = 9;
			item.noMelee = true;
			item.mana = 11;
			item.UseSound = SoundID.Item76;
			item.shoot = ModContent.ProjectileType<MythrilBolt>();
			item.shootSpeed = 16f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MythrilBar, 10);
			recipe.AddIngredient(ItemID.LargeEmerald);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}