using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons
{
	public class DemonicScythe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Demonic Scythe"); 
			Tooltip.SetDefault("Delightfully devilish");
		}

		public override void SetDefaults() 
		{
			item.damage = 32;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
        {
			target.AddBuff(BuffID.OnFire, 250);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DemonFlesh"), 20);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        public override bool AltFunctionUse(Player player) 
        {
			return true;
		}

		public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
                item.useStyle = 1;
                item.noUseGraphic = true;
				item.useTime = 20;
				item.useAnimation = 20;
				item.damage = 32;
				item.shoot = mod.ProjectileType("DemonicScythe");
			    item.shootSpeed = 10f;
				
			}
			else {
                item.useStyle = 1;
				item.useTime = 22;
				item.useAnimation = 22;
				item.damage = 32;
				
			}
			return base.CanUseItem(player);
		}
	}
}