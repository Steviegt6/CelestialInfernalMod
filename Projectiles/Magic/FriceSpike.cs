using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Magic
{
	public class FriceSpike: ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.IceSpike);
			aiType = ProjectileID.IceSpike;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.tileCollide = false;
			projectile.timeLeft = 600;
			projectile.magic = true;
		}

		public override void OnHitNPC (NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Frostburn, 200);
		}
    }
}