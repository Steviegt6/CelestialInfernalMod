using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Melee
{
	public class DensePixieYoyo : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Virtuoso");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.Gradient);
            projectile.tileCollide = false;
            aiType = ProjectileID.Gradient;
			projectile.friendly = true;
		}
	}
}
