using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace CelestialInfernalMod.NPCs.MushKing
{
    public class MushroomKingProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mushroom King Projectile");
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 24;
            projectile.aiStyle = 8;
            projectile.hostile = true;
            projectile.friendly = false;
            projectile.melee = true;
        }
    }
}
