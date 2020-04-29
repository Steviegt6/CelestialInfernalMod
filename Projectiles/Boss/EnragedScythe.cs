using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Boss
{
	public class EnragedScythe : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enraged Demon's Scythe");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.Flamarang);
            projectile.tileCollide = false;
            aiType = ProjectileID.Flamarang;
            projectile.timeLeft = 60;
			projectile.hostile = true;
            projectile.friendly = false;
			projectile.melee = false;
		}
	}
}
