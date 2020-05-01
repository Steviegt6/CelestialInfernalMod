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

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class SilverSniper : ModItem //no, I don't know why this is internally called silver sniper, but it's not made of silver
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellfire Pistol");
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
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}