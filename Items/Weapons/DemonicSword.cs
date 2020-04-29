using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class DemonicSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Demon's Claw"); 
			Tooltip.SetDefault("Enpowered by demonic forces");
		}

		public override void SetDefaults() 
		{
			item.damage = 26;
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
            item.shoot = 504;
            item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DemonFlesh"), 20);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}