using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class CobaltBolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sapphire Rocket");
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 18;
			projectile.aiStyle = 16;
			projectile.friendly = true;
			projectile.maxPenetrate = 1;
			projectile.magic = true;
			projectile.timeLeft = 300;
            aiType = ProjectileID.RocketSnowmanIII;
		}
        public override void Kill(int timeLeft) 
        {
            Main.PlaySound(SoundID.NPCDeath14, projectile.position);
            
            int cobdustspeed = Main.rand.Next(-15, 16);
            
            for (int d = 0; d < 10; d++)
            {
	           Dust.NewDust(projectile.position, projectile.width, projectile.height, 59, cobdustspeed, cobdustspeed, 150, default(Color), 2.5f);
            }
        }
	}
}
