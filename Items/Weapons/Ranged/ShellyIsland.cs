using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class ShellyIsland : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Shelly Island"); 
			Tooltip.SetDefault("Shoots a high-velocity water bolt");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 30;
			item.height = 48;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 6;
            item.noMelee = true;
			item.value = 50000;
			item.rare = 3;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
            item.shootSpeed = 17.5f;
            item.shoot = ProjectileID.WaterBolt;
        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int star = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.WaterBolt, damage, knockBack, player.whoAmI, 0f, 0f);
			Main.projectile[star].Celestial().forceRanged = true;
			return false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sapphire, 12);
            recipe.AddIngredient(ItemID.GoldBar, 6);
            recipe.AddIngredient(ItemID.Bone, 24);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}