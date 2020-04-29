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
	public class NinjaKunai: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 48;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            projectile.tileCollide = true;
            projectile.maxPenetrate = 1;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.aiStyle = 2;
            projectile.penetrate = 1;
        }
        public override void AI()
        {
			int chordustspeed = Main.rand.Next(-10, 11);
            
            if (Main.rand.Next(10) == 0)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 41, chordustspeed, chordustspeed, 100, default(Color), 1f);
            }
        }
        public override void Kill(int timeLeft) 
        {
            Main.PlaySound(SoundID.NPCDeath1, projectile.position);
            
            int ichdustspeed = Main.rand.Next(-15, 16);
            
            for (int d = 0; d < 10; d++)
            {
	           Dust.NewDust(projectile.position, projectile.width, projectile.height, 41, ichdustspeed, ichdustspeed, 150, default(Color), 2.5f);
            }
        }
    }
}