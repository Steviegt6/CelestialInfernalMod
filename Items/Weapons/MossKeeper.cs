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
	public class MossKeeper : ModItem
	{
		public override void SetStaticDefaults() 
		{
            DisplayName.SetDefault("Moss Keeper");
			Tooltip.SetDefault("Less confusing than its predecessor");
		}

		public override void SetDefaults() 
		{
			item.damage = 110;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
        {
            Projectile.NewProjectile(player.position.X, player.position.Y, 0f, 0f, 189, 50, 0f, 0);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeKeeper); 
            recipe.AddIngredient(ItemID.TempleKey);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}