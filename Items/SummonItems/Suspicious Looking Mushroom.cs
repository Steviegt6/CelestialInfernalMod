using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CelestialInfernalMod.NPCs.MushroomKingBoss;

namespace CelestialInfernalMod.Items.SummonItems
{
	public class SuspiciousLookingMushroom : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Suspicious Looking Mushroom");
			Tooltip.SetDefault("It could be used to declare war to the mushroom king");
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
			return !NPC.AnyNPCs(ModContent.NPCType<MushroomKing>());
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<MushroomKing>());
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y);

			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 30);
			recipe.AddIngredient(ItemID.GoldCrown, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

