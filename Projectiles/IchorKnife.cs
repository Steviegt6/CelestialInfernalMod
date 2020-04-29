using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Enums;

namespace CelestialInfernalMod.Projectiles
{
	public class IchorKnife: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 24;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            projectile.tileCollide = true;
            projectile.maxPenetrate = 5;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.aiStyle = 2;
            projectile.penetrate = 5;
        }
        public override void OnHitNPC (NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(69, 600);
        }
        public override void AI()
        {
        int chordustspeed = Main.rand.Next(-10, 11);
            
            if (Main.rand.Next(10) == 0)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 152, chordustspeed, chordustspeed, 100, default(Color), 1f);
            }
        }
        public override void Kill(int timeLeft) 
        {
            Main.PlaySound(13, projectile.position);
            
            int ichdustspeed = Main.rand.Next(-15, 16);
            
            for (int d = 0; d < 10; d++)
            {
	           Dust.NewDust(projectile.position, projectile.width, projectile.height, 152, ichdustspeed, ichdustspeed, 150, default(Color), 2.5f);
            }
            if (Main.rand.Next(5) < 4)
            {
                Item.NewItem(projectile.getRect(), mod.ItemType("IchorKnife"), Main.rand.Next(1, 2));
            }
        }
    }
}