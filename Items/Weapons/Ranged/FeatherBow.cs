using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Ranged;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class FeatherBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Winged Bow"); 
			Tooltip.SetDefault("Wooden arrows are converted into feathers");
		}

		public override void SetDefaults()
		{
			item.damage = 21;
			item.width = 22;
			item.height = 36;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 2, 0, 0);
			item.rare = 1;
			item.noMelee = true;
            item.knockBack = 1;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 1;
			item.shootSpeed = 7.5f;
			item.ranged = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly) 
			{
				type = ModContent.ProjectileType<ArrowFeather>(); 
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}
	}
}