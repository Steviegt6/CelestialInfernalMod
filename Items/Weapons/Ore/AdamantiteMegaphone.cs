using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ore
{
	public class AdamantiteMegaphone : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Adamantite Megaphone"); 
			Tooltip.SetDefault("Fires harmful waves");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.width = 24;
			item.height = 28;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 12, 50, 0);
			item.rare = 4;
			item.knockBack = 7;
			item.noMelee = true;
			item.mana = 10;
			item.UseSound = SoundID.NPCDeath10;
			item.shoot = mod.ProjectileType("MegaWave");
			item.shootSpeed = 20f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(391, 12);
			recipe.AddIngredient(890, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}