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
    public class FossilCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A relic of the past"
                                + "\nIncreases all critical strike chance by 5%."
                                + "\nIncreases thrown damage by 10%;");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 30;
            item.height = 30;
            item.value = item.value = Item.buyPrice(0, 2, 50, 0);
            item.rare = 2;
            item.expert = false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += 0.1f;
            player.thrownCrit += 5;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(999, 10);
			recipe.AddIngredient(3380, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(3347, 1);
			recipe.AddTile(18);
			recipe.SetResult(3348, 4);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
			recipe.AddIngredient(3348, 4);
			recipe.AddTile(18);
			recipe.SetResult(3347, 1);
			recipe.AddRecipe();
		}
    }
}
