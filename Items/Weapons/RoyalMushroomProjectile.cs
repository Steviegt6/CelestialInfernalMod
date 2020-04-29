using Terraria;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class RoyalMushroomProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Royal Mushroom Projectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 22;
			projectile.height = 24;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.melee = true;
			projectile.timeLeft = 100;
			projectile.arrow = false;
		}
	}
}
