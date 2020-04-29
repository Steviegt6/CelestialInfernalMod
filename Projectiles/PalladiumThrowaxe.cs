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
	public class PalladiumThrowaxe: ModProjectile
    {
         public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Palladium Throwing Axe");
        }
        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 40;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            projectile.tileCollide = true;
            projectile.maxPenetrate = 3;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.aiStyle = 2;
            projectile.penetrate = 3;
            projectile.timeLeft = 240;
        }
        public override void AI()
        {
         projectile.rotation += 0.5f * (float)projectile.direction;
        }
        public override void Kill(int timeLeft) 
        {
            Main.PlaySound(SoundID.Dig, projectile.position);
        }
    }
}