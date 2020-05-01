using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace CelestialInfernalMod.Projectiles
{
    public class CrystalPixie : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pixie Crystal");
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 32;
            projectile.aiStyle = 2;
            projectile.hostile = true;
            projectile.friendly = false;
            projectile.melee = false;
        }
    }
}
