using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class SlimySword : ModItem
	{
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Slimy Sword"); 
			Tooltip.SetDefault("Watch out, it's slippery.");
		}
		public override void SetDefaults() 
		{
			item.damage = 13;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.25f;
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) 
        {
			target.AddBuff(BuffID.Slimed, 1800);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<StrangeGel>());
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}