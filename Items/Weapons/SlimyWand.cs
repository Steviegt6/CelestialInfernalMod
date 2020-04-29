using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class SlimyWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy Wand"); 
            Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.width = 36;
			item.height = 36;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 0;
			item.knockBack = 2;
			item.noMelee = true;
			item.mana = 15;
			item.UseSound = SoundID.Item8;
			item.shoot = mod.ProjectileType("MagicSlimeball");
			item.shootSpeed = 9f;
			item.autoReuse = true;
			item.magic = true;
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StrangeGel"));
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}