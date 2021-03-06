﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Tools
{
	public class DemonicPickaxe : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 16;
			item.width = 32;
			item.height = 32;
			item.useTime = 16;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 0, 65, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

			item.pick = 80;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DemonFlesh"), 18); //modded materials
			recipe.AddIngredient(ItemID.HellstoneBar, 4);
			recipe.AddIngredient(ItemID.Wood, 4); //vanilla materials
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
