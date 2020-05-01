using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class OrichalcumStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Orichalcum Staff"); 
			Tooltip.SetDefault("Shoots suffocating amethyst bolts");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 43;
			item.width = 44;
			item.height = 44;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 11, 0, 0);
			item.rare = 4;
			item.knockBack = 9;
			item.noMelee = true;
			item.mana = 10;
			item.UseSound = SoundID.Item21;
			item.shoot = ModContent.ProjectileType<OrichalcumBolt>();
			item.shootSpeed = 10f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OrichalcumBar, 10);
			recipe.AddIngredient(ItemID.LargeAmethyst);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}