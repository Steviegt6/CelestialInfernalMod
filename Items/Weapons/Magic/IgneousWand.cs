using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class IgneousWand : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Igneous Wand"); 
			Tooltip.SetDefault("Fires a ball of fire that ignites enemies");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 16;
			item.width = 48;
			item.height = 48;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 1;
			item.knockBack = 4;
			item.noMelee = true;
			item.mana = 5;
			item.UseSound = SoundID.Item8;
			item.shoot = ProjectileID.BallofFire;
			item.shootSpeed = 7f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WandofSparking);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}