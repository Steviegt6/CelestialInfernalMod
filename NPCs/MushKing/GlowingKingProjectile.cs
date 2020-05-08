using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace CelestialInfernalMod.NPCs.MushKing
{
    public class GlowingKingProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom King Glowing Projectile");
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 24;
            projectile.aiStyle = 8;
            projectile.hostile = true;
            projectile.friendly = false;
            projectile.melee = true;
            aiType = 27;
        }
    }
}
