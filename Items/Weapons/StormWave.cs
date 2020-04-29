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
	public class StormWave : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Storm Wave"); 
            Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 48;
			item.width = 28;
			item.height = 32;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 25, 0, 0);
			item.rare = 5;
			item.knockBack = 8;
			item.noMelee = true;
			item.mana = 20;
			item.UseSound = SoundID.Item21;
			item.shoot = 27;
			item.shootSpeed = 9f;
			item.autoReuse = true;
			item.magic = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2 + Main.rand.Next(2); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(10);
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
			recipe.AddIngredient(165, 1);
			recipe.AddIngredient(547, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}