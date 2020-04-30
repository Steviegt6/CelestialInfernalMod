using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Items.Weapons.Melee
{
	public class TrueMuramasa : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Supermasa"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 63;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = Item.buyPrice(0, 54, 0, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Muramasa);
            recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}