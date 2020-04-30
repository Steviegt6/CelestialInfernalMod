using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class SorcererBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sorcerer's Blade");
			Tooltip.SetDefault("Fires a magic blast that pierces 3 enemies");
		}
		public override void SetDefaults() 
		{
			item.damage = 50;
			item.magic = true;
            item.shoot = ModContent.ProjectileType<SorcererWave>();
            item.shootSpeed = 9f;
			item.width = 30;
			item.height = 34;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 1;
            item.mana = 13;
			item.knockBack = 6;
			item.value = 200000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
