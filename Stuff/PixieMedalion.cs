using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Stuff
{
	public class PixieMedalion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pixie Medalion");
			Tooltip.SetDefault("It looks like a pixie. It might call the strongest of them.");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 14;
			item.maxStack = 99;
			item.value = Item.buyPrice(0, 0, 50, 0);
			item.rare = 4;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useTurn = true;
			item.autoReuse = false;
			item.consumable = true;
			item.useStyle = 4;
		}
		public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPCs(mod.NPCType("HigherPixie"));
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("HigherPixie"));
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y);

			return true;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 30);
			recipe.AddIngredient(ItemID.UnicornHorn, 5);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
