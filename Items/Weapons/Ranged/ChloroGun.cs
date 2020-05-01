using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class ChloroGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chloros Cleanse"); 
            Tooltip.SetDefault("Shoots two or three high-velocity bullets");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.width = 30;
			item.height = 30;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 24, 0, 0);
			item.rare = 6;
			item.noMelee = false;
            item.knockBack = 4f;
			item.useAmmo = AmmoID.Bullet;
			item.UseSound = SoundID.Item11;
			item.shoot = 14;
			item.shootSpeed = 8f;
            item.autoReuse = true;
			item.ranged = true;
		}
         public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2 + Main.rand.Next(2); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(5);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 3f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 3f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}