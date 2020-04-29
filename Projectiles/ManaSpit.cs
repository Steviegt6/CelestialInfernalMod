using Microsoft.Xna.Framework;
using System.IO;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Projectiles
{
    public class ManaSpit : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vile Spit");
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 29;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = -1;
            projectile.maxPenetrate = 10;
            projectile.light = 0.5f;
            projectile.alpha = 0;
            aiType = 124;
        }
        public override void OnHitNPC (NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(39, 420);
        }
    }
}
