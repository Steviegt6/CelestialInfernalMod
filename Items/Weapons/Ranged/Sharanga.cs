using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class Sharanga : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fright's Solfege"); 
			Tooltip.SetDefault("Shoots a high-velocity arrow");
		}

		public override void SetDefaults() 
		{
			item.damage = 32;
			item.ranged = true;
			item.width = 20;
			item.height = 44;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = 5;
			item.knockBack = 5;
            item.noMelee = true;
			item.value = 54000;
			item.rare = 3;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 12f;
            item.shoot = 1;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2 + Main.rand.Next(2); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(5);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 5f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

        public override bool ConsumeAmmo(Player player) => Main.rand.NextFloat() >= .25f;

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DemonicBow>());
            recipe.AddIngredient(ModContent.ItemType<PutridBow>());
            recipe.AddIngredient(ModContent.ItemType<Sporeshooter>());
            recipe.AddIngredient(ModContent.ItemType<ShellyIsland>());
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}