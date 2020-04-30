using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class FeatherousBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Featherous Bow"); 
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.width = 16;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 14, 90, 0);
			item.rare = 5;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 4;
			item.shootSpeed = 10f;
			item.ranged = true;
			item.autoReuse = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 6 + Main.rand.Next(2);  //This defines how many projectiles to shot
			for (int index = 0; index < numberProjectiles; ++index)
			{
				Vector2 vector2_1 = new Vector2((float)(player.Center.X + (Main.rand.Next(201) * -player.direction) + Main.mouseX + Main.screenPosition.X - player.position.X), player.Center.Y - 600f);   //this defines the projectile width, direction and position
				vector2_1.X = ((vector2_1.X + player.Center.X) / 2f) + Main.rand.NextFloat(-200, 200);
				vector2_1.Y -= (float)(100 * index);
				float num12 = Main.mouseX + Main.screenPosition.X - vector2_1.X;
				float num13 = Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
				if (num13 < 0f)
				{
					num13 *= -1f;
				}
				if (num13 < 20f)
				{
					num13 = 20f;
				}
				float num14 = new Vector2(num12, num13).Length();
				float num15 = item.shootSpeed / num14;
				float num16 = num12 * num15;
				float num17 = num13 * num15;
				float SpeedX = num16 + Main.rand.NextFloat(-40, 40) * 0.02f;  //this defines the projectile X position speed and randomnes
				float SpeedY = num17 + Main.rand.NextFloat(-40, 40) * 0.02f;  //this defines the projectile Y position speed and randomnes
				Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0f, (float)Main.rand.Next(5));
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 20);
			recipe.AddIngredient(ItemID.WoodenBow);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}