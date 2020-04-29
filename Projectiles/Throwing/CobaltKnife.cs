using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Enums;

namespace CelestialInfernalMod.Projectiles.Throwing
{
	public class CobaltKnife: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 26;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            projectile.tileCollide = true;
            projectile.maxPenetrate = 3;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.aiStyle = 2;
            projectile.penetrate = 3;
        }
        public override void AI()
        {
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(45f);   
        }
        public override void Kill(int timeLeft) 
        {
            Main.PlaySound(SoundID.Dig, projectile.position);
            
            int cobdustspeed = Main.rand.Next(-15, 16);
            
            for (int d = 0; d < 10; d++)
            {
	           Dust.NewDust(projectile.position, projectile.width, projectile.height, 59, cobdustspeed, cobdustspeed, 150, default(Color), 2.5f);
            }
        }
    }
}