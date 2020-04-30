using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Stuff;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class StarAnger : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Star Anger"); 
			Tooltip.SetDefault("Sends down an artifact of space's rage");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = true;
			item.width = 57;
			item.height = 60;
            item.scale = 1.5f;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;
			item.shoot = ProjectileID.Starfury;
			item.shootSpeed = 25f;
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 3; i++)
			{
				position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
				position.Y -= (100 * i);
				Vector2 heading = target - position;
				if (heading.Y < 0f)
				{
					heading.Y *= -1f;
				}
				if (heading.Y < 20f)
				{
					heading.Y = 20f;
				}
				heading.Normalize();
				heading *= new Vector2(speedX, speedY).Length();
				speedX = heading.X;
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.10f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DensePixieDust>(), 12);
			recipe.AddIngredient(ItemID.Starfury);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}