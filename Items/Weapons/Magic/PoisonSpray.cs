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
using CelestialInfernalMod.Projectiles.Magic;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class PoisonSpray : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poisonous Spray"); 
            Item.staff[item.type] = true;
		}
        public override void SetDefaults()
		{
			item.damage = 20;
			item.width = 36;
			item.height = 36;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 2, 25, 0);
			item.rare = 2;
			item.knockBack = 2.5f;
			item.noMelee = true;
			item.mana = 9;
			item.UseSound = SoundID.Item20;
			item.shoot = ModContent.ProjectileType<SporeBolt>();
			item.shootSpeed = 10f;
			item.autoReuse = true;
			item.magic = true;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(331, 12); //modded materials
			recipe.AddIngredient(209, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}