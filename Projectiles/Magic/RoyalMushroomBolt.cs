using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Magic
{
	public class RoyalMushroomBolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glowing Bolt");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.WaterBolt);
            aiType = ProjectileID.WaterBolt;
			projectile.friendly = true;
		}
	}
}
