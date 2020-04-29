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

namespace CelestialInfernalMod.Items.Weapons.Ore
{
	public class SilverSniper : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("RoyalMushroomBow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Shoots a medium-velocity bullet");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.width = 30;
			item.height = 30;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 2, 50, 0);
			item.rare = 3;
			item.noMelee = false;
            item.knockBack = 4f;
			item.useAmmo = AmmoID.Bullet;
			item.UseSound = SoundID.Item11;
			item.shoot = 14;
			item.shootSpeed = 7.5f;
            item.autoReuse = true;
			item.ranged = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(175, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}