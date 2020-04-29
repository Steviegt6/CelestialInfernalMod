using Microsoft.Xna.Framework;
using System.IO;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Projectiles
{
    public class SorcererWave : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sorcerer Wave");
        }

        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 16;
            projectile.aiStyle = 29;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.timeLeft = 600;
            projectile.maxPenetrate = 3;
            projectile.light = 0.5f;
            projectile.alpha = 127;
            projectile.penetrate = 3;

        }
        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
        }
    }
}
