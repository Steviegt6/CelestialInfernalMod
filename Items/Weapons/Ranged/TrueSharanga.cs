using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Stuff;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class TrueSharanga : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Fright's Solfege"); 
			Tooltip.SetDefault("Shoots a high-velocity arrow");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.ranged = true;
			item.width = 24;
			item.height = 48;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 5;
			item.knockBack = 6;
            item.noMelee = true;
			item.value = 500000;
			item.rare = 7;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 15f;
            item.shoot = 1;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 3 + Main.rand.Next(3); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(10);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 5f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 4f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
        public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .5f;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Sharanga>());
            recipe.AddIngredient(ModContent.ItemType<BrokenHeroBow>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}