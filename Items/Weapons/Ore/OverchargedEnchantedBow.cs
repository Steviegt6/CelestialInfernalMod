using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ore
{
	public class OverchargedEnchantedBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Overcharged Enchanted Bow"); 
		}

		public override void SetDefaults()
		{
			item.damage = 55;
			item.width = 26;
			item.height = 36;
			item.useTime = 15;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 14, 90, 0);
			item.rare = 5;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = ProjectileID.EnchantedBeam;
			item.shootSpeed = 10f;
			item.ranged = true;
			item.autoReuse = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 1 + Main.rand.Next(5); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(10);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 2f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage / 2, knockBack, player.whoAmI);
			}
			return false;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}
	}
}