using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Melee
{
	public class GraniteYoyo : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Granite Throw");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.Amarok);
            projectile.tileCollide = false;
            aiType = ProjectileID.Amarok;
			projectile.friendly = true;
		}
	}
}
