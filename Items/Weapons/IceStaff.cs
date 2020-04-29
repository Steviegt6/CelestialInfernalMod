using CelestialInfernalMod.Projectiles.Magic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class IceStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ice Spike Staff"); 
			Tooltip.SetDefault("Rains ice spikes down from the sky");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 18;
			item.width = 36;
			item.height = 36;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 2, 0, 0);
			item.rare = 1;
			item.knockBack = 6;
			item.mana = 12;
			item.UseSound = SoundID.Item21;
			item.shoot = ModContent.ProjectileType<FriceSpike>();
			item.shootSpeed = 8f;
			item.autoReuse = true;
			item.magic = true;
			item.noMelee = true;
		}
	}
}