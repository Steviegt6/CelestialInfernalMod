using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class EaterofMana : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Beheaded Spitter"); 
			Tooltip.SetDefault("Spits a vile projectile");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 32;
			item.width = 50;
			item.height = 50;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 2;
			item.knockBack = 7.5f;
			item.noMelee = true;
			item.mana = 10;
			item.UseSound = SoundID.NPCDeath13;
			item.shoot = ModContent.ProjectileType<ManaSpit>();
			item.shootSpeed = 13f;
			item.autoReuse = true;
			item.magic = true;
		}
	}
}