using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class ShiitakeSpear : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiitake Spear");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.TheRottedFork);
            projectile.tileCollide = false;
            aiType = ProjectileID.TheRottedFork;
			projectile.friendly = true;
		}
	}
}
