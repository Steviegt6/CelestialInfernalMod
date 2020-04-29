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

namespace CelestialInfernalMod.Items.Weapons
{
	public class Gigashark : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("RoyalMushroomBow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("The Minishark's father");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.width = 108;
			item.height = 42;
			item.useTime = 6;
			item.useAnimation = 6;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 8;
			item.noMelee = false;
            item.knockBack = 4f;
			item.useAmmo = AmmoID.Bullet;
			item.UseSound = SoundID.Item11;
			item.shoot = 14;
			item.shootSpeed = 12.5f;
            item.autoReuse = true;
			item.ranged = true;
		}
        public override bool ConsumeAmmo(Player player)
            {
            return Main.rand.NextFloat() >= .75f;
            }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Megashark);
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}