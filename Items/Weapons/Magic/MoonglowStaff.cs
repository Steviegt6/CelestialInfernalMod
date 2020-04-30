using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CelestialInfernalMod.Items.Weapons.Magic
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
			item.shoot = ProjectileID.IceBolt;
			item.shootSpeed = 9f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int bolt = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, 0f);
			Main.projectile[bolt].Celestial().forceMagic = true;
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Moonglow, 3);
			recipe.AddIngredient(ItemID.WandofSparking);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}