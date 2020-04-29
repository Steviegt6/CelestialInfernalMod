using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class Sbeear : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Stinger");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.Gungnir);
            projectile.tileCollide = false;
            aiType = ProjectileID.Gungnir;
			projectile.friendly = true;
		}
	}
}
