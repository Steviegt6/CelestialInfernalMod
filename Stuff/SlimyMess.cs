using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Stuff
{
	public class SlimyMess : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("'Slimy Mess'");
			Tooltip.SetDefault("'Theodor S. Geisel'");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 14;
			item.maxStack = 99;
			item.value = Item.buyPrice(0, 0, 50, 0);
			item.rare = 4;
			item.useStyle = 1;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useTurn = true;
			item.autoReuse = false;
			item.consumable = true;
			item.useStyle = 4;
		}
		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(mod.NPCType("GrandSlime"));
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("GrandSlime"));
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y);

			return true;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddIngredient(ItemID.Gel, 100);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(20, 10);
			recipe.AddIngredient(21, 8);
            recipe.AddIngredient(19, 6);
			recipe.AddTile(18);
			recipe.SetResult(18, 1);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(703, 10);
			recipe.AddIngredient(705, 8);
            recipe.AddIngredient(706, 6);
			recipe.AddTile(18);
			recipe.SetResult(18, 1);
			recipe.AddRecipe();
		}
	}
}

