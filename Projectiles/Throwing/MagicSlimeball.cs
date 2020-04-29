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
	public class MagicSlimeball: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 9;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            projectile.tileCollide = true;
            projectile.maxPenetrate = 1;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 150;
        }
        public override void AI()
        {
			projectile.position = Main.MouseWorld;
			projectile.rotation += 0.4f * (float)projectile.direction;
            
            int slimedustspeed = Main.rand.Next(-15, 16);
            
            if (Main.rand.NextBool(10))
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 183, slimedustspeed, slimedustspeed, 150, default(Color), 2.5f);
            }
        }

        public override void Kill(int timeLeft) 
        {
            Main.PlaySound(SoundID.NPCDeath1, projectile.position);
        }
    }
}