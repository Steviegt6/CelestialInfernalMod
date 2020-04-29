using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
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
            item.shoot = mod.ProjectileType("SorcererWave");
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
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("EnchantedShard"), 8);
            r.AddIngredient(3484, 1);
            r.AddTile(TileID.Anvils);
            r.SetResult(989, 1);
            r.AddRecipe();
        }
	}
}
