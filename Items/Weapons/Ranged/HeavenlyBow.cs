using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class HeavenlyBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavenly Bow"); 
		}

		public override void SetDefaults()
		{
			item.damage = 52;
			item.width = 16;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 14, 90, 0);
			item.rare = 5;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = ItemID.HolyArrow;
			item.shootSpeed = 10f;
			item.ranged = true;
			item.autoReuse = true;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 10);
			recipe.AddIngredient(ItemID.PearlstoneBlock, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 10);
			recipe.AddIngredient(ItemID.PearlstoneBlock, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}