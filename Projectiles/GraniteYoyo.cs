using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class GraniteYoyo : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Granite Throw");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(552);
            projectile.tileCollide = false;
            aiType = 552;
			projectile.friendly = true;
		}
	}
}
