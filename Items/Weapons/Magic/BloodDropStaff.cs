using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Stuff;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class BloodDropStaff : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blood Drop Staff"); 
			Tooltip.SetDefault("Shoots spray of deadly blood");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 19;
			item.width = 24;
			item.height = 24;
			item.useTime = 8;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 3, 12, 0);
			item.rare = 3;
			item.knockBack = 6;
			item.noMelee = true;
			item.mana = 12;
			item.UseSound = SoundID.Item21;
			item.shoot = ProjectileID.RubyBolt;
			item.shootSpeed = 28f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BloodDrop>(), 13); //modded materials
			recipe.AddIngredient(ItemID.Wood, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
