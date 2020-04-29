using Microsoft.Xna.Framework;
using System.IO;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Projectiles.Magic
{
    public class PalladiumBolt : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Topaz Stream");
        }

        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.aiStyle = 12;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.maxPenetrate = 10;
            projectile.light = 1f;
            projectile.alpha = 255;
            aiType = ProjectileID.GoldenShowerFriendly;
        }
    }
}
