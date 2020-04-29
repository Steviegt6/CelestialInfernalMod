using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Stuff;

namespace CelestialInfernalMod.Items.Weapons.Ranged
{
	public class BloodDropBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Drop Bow"); 
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.width = 14;
			item.height = 24;
			item.useTime = 15;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.value = Item.buyPrice(0, 2, 90, 0);
			item.rare = 3;
			item.noMelee = true;
			item.useAmmo = AmmoID.Arrow;
			item.UseSound = SoundID.Item5;
			item.shoot = 4;
			item.shootSpeed = 10f;
			item.ranged = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.WoodenArrowFriendly, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BloodDrop>(), 12);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}