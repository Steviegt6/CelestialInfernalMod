using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class PalladiumStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Palladium Staff"); 
			Tooltip.SetDefault("Fires weakening topaz streams");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 24;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 8, 0, 0);
			item.rare = 4;
			item.knockBack = 7;
			item.noMelee = true;
			item.mana = 6;
			item.UseSound = SoundID.Item8;
			item.shoot = ModContent.ProjectileType<PalladiumBolt>();
			item.shootSpeed = 15f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 10);
			recipe.AddIngredient(ItemID.LargeTopaz);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}