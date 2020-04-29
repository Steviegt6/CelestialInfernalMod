using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class StarCane : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Cane"); 
            Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 32;
			item.width = 56;
			item.height = 56;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 4;
			item.knockBack = 2;
			item.noMelee = true;
			item.mana = 20;
			item.UseSound = SoundID.Item9;
			item.shoot = 12;
			item.shootSpeed = 8f;
			item.autoReuse = true;
			item.magic = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2 + Main.rand.Next(4); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(5);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 2f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StarWand"), 1);
			recipe.AddIngredient(575, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}