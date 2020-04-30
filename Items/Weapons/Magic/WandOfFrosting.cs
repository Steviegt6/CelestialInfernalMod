using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CelestialInfernalMod.Items.Weapons.Magic
{
	public class WandOfFrosting : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wand of Frosting"); 
			Tooltip.SetDefault("Fires an icy bolt");
		}
		public override void SetDefaults()
		{
			item.damage = 9;
			item.width = 15;
			item.height = 15;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 1;
			item.value = Item.buyPrice(0, 0, 60, 0);
			item.rare = 1;
			item.knockBack = 1;
			item.mana = 5;
			item.UseSound = SoundID.Item8;
			item.shoot = ProjectileID.IceBolt;
			item.shootSpeed = 7.5f;
            item.noMelee = true;
			item.autoReuse = true;
			item.magic = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int bolt = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, 0f);
			Main.projectile[bolt].Celestial().forceMagic = true;
			return false;
		}

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.IceTorch, 5);
            r.AddIngredient(ItemID.BorealWood, 10);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
	}
}