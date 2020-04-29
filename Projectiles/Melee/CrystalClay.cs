using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace CelestialInfernalMod.Projectiles.Melee
{
    public class CrystalClay : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Claymore's Crystal");
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 32;
            projectile.aiStyle = 2;
            projectile.hostile = false;
            projectile.friendly = true;
            projectile.melee = true;
        }
    }
}
