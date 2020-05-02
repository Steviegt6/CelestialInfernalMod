using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Projectiles.Throwing;

namespace CelestialInfernalMod.Items.Weapons.Throwing
{
	public class IchorKnife : ModItem
	{

		public override void SetDefaults() 
		{
			item.damage = 42;
			item.thrown = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 3;
            item.maxStack = 999;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.consumable = true;
			item.value = Item.buyPrice(0, 0, 5, 0);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<IchorKnifeProj>();
			item.shootSpeed = 15f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ThrowingKnife, 100);
            recipe.AddIngredient(ItemID.Ichor);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}
