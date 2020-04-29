using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace CelestialInfernalMod.Projectiles.Ranged
{
    public class ArrowFeather : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Feathered Arrow");
        }

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 24;
			projectile.aiStyle = 1;
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.arrow = true;
		}

		public override void AI()
		{
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);   
		}
    }
}
