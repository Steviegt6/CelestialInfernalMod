using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class DensePixieStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Stave of the Stars"); 
			Tooltip.SetDefault("Fires hallowed stars");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 64;
			item.width = 34;
			item.height = 34;
			item.useTime = 8;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 16, 0, 0);
			item.rare = 5;
			item.knockBack = 6;
			item.noMelee = true;
			item.mana = 12;
			item.UseSound = SoundID.Item21;
			item.shoot = ProjectileID.HallowStar;
			item.shootSpeed = 28f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int star = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, 0f);
			Main.projectile[star].Celestial().forceMagic = true;
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DensePixieDust>(), 18); //modded materials
			recipe.AddIngredient(ItemID.StarCannon);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}