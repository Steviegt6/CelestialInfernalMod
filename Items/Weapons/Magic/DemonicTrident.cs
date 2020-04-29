using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Stuff;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class DemonicTrident : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonic Trident");
            Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 36;
			item.width = 44;
			item.height = 44;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 2;
			item.knockBack = 2;
			item.noMelee = true;
			item.mana = 15;
			item.UseSound = SoundID.Item21;
			item.shoot = ProjectileID.DemonScythe;
			item.shootSpeed = 6f;
			item.autoReuse = true;
			item.magic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DemonFlesh>(), 16);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}