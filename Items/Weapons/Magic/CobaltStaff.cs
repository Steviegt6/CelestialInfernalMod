using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class CobaltStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cobalt Staff"); 
			Tooltip.SetDefault("Fires explosive sapphire rockets");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 35;
			item.width = 38;
			item.height = 38;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 6, 0, 0);
			item.rare = 4;
			item.knockBack = 6;
			item.noMelee = true;
			item.mana = 10;
			item.UseSound = SoundID.Item8;
			item.shoot = ModContent.ProjectileType<CobaltBolt>();
			item.shootSpeed = 12f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddIngredient(ItemID.LargeSapphire);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}