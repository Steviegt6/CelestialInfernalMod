using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CelestialInfernalMod.Projectiles.Magic
{
	public class MythrilBolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emerald Bat");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 20;
			projectile.aiStyle = 29;
			projectile.friendly = true;
			projectile.maxPenetrate = 1;
			projectile.magic = true;
			projectile.timeLeft = 300;
            aiType = ProjectileID.EmeraldBolt;
		}
        public override void AI()
        {
            projectile.rotation += 0.4f * (float)projectile.direction;
        }
        public override void OnHitNPC (NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Poisoned, 1800);
		}
        public override void Kill(int timeLeft) 
        {
            Main.PlaySound(SoundID.NPCDeath4, projectile.position);
            
            int mythdustspeed = Main.rand.Next(-15, 16);
            
            for (int d = 0; d < 10; d++)
            {
	           Dust.NewDust(projectile.position, projectile.width, projectile.height, 61, mythdustspeed, mythdustspeed, 150, default(Color), 2.5f);
            }
        }
	}
}
