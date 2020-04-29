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
	public class Hellbender : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Hellbender"); 
			Tooltip.SetDefault("It came from another world");
            Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 19;
			item.width = 44;
			item.height = 44;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 3, 0, 0);
			item.rare = 3;
			item.knockBack = 4;
			item.noMelee = true;
			item.mana = 10;
			item.UseSound = SoundID.Item20;
			item.shoot = 15;
			item.shootSpeed = 20f;
			item.autoReuse = true;
			item.magic = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(45));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(175, 15);
			recipe.AddIngredient(1322, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}