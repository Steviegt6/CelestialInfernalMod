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
	public class IronCutlery: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 28;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            projectile.tileCollide = true;
            projectile.maxPenetrate = 2;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.aiStyle = 2;
            projectile.penetrate = 2;
        }
        public override void AI()
        {
         projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(45f);   
        }
        public override void Kill(int timeLeft) 
        {
            if (Main.rand.Next(5) < 4)
            {
                Item.NewItem(projectile.getRect(), mod.ItemType("IronCutlery"), Main.rand.Next(1, 2));
            }
        }
    }
}