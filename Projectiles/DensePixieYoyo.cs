using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class DensePixieYoyo : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Virtuoso");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(563);
            projectile.tileCollide = false;
            aiType = 563;
			projectile.friendly = true;
		}
	}
}
