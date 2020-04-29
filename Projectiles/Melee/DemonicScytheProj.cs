using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Melee
{
	public class DemonicScytheProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonic Scythe");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.Flamarang);
            projectile.tileCollide = false;
            aiType = ProjectileID.Flamarang;
            projectile.timeLeft = 300;
			projectile.friendly = true;
		}
	}
}
