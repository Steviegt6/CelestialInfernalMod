using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Melee.Hardmode
{
	public class CelestialSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Celestial Sword");
			Tooltip.SetDefault("Calamitous beings are threatened");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 16;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 18, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.EnchantedBeam;
			item.shootSpeed = 8f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.EnchantedBeam, damage, knockBack, player.whoAmI);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Starfury, damage, knockBack, player.whoAmI);
			}
			return false;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("StarAnger"));
			recipe.AddIngredient(mod.ItemType("OverchargedEnchantedSword"));
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}