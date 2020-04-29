using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Accessories
{
    public class StingerNecklace : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stinger Necklace");
			Tooltip.SetDefault("Increases armor penetration by 10"
							+ "\nIncreases damage by 5%"
							+ "\nYou can inflict posion");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.rare = 2;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.accessory = true;
			item.expert = false;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.armorPenetration += 10;
			player.allDamage += 0.05f;
            player.AddBuff(79, 3600);
		}	
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SharkToothNecklace, 1);
            recipe.AddIngredient(209, 10);
            recipe.AddIngredient(210, 5);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
