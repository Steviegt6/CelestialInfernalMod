using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class DemonicScythe : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonic Scythe");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(19);
            projectile.tileCollide = false;
            aiType = 19;
            projectile.timeLeft = 300;
			projectile.friendly = true;
		}
	}
}
