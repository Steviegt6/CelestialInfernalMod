using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
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
