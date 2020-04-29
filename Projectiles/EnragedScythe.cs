using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class EnragedScythe : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enraged Demon's Scythe");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(19);
            projectile.tileCollide = false;
            aiType = 19;
            projectile.timeLeft = 60;
			projectile.hostile = true;
            projectile.friendly = false;
		}
	}
}
