using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class BloodDropSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Blood Drop Sword");
			Tooltip.SetDefault("Tear through the flesh of your enemies");
		}

		public override void SetDefaults() 
		{
			item.damage = 21;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 18;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 3, 0, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<BloodDrop>(), 12);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}