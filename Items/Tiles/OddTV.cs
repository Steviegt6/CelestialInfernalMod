using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CelestialInfernalMod.Items.Tiles
{
	public class OddTV : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Odd Television");
            Tooltip.SetDefault("Looks like the color of green is on today.");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 20;
			item.useTime = 20;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("OddTV");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Daylight);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddIngredient(ItemID.Wire, 250);
            recipe.AddIngredient(ItemID.UnicornHorn, 2);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}