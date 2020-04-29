using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
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
			item.shoot = 118;
			item.shootSpeed = 7.5f;
            item.noMelee = true;
			item.autoReuse = true;
			item.magic = true;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
        {
			target.AddBuff(BuffID.Frostburn, 60);
		}
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(974, 5);
            r.AddIngredient(2503, 10);
            r.AddTile(18);
            r.SetResult(this);
            r.AddRecipe();
        }
	}
}