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
    public class ExecutionerEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("15% increased damage and 10% increased critical strike chance");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 30;
            item.height = 30;
            item.value = item.value = Item.buyPrice(1, 0, 0, 0);
            item.rare = 10;
            item.expert = false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeCrit += 10;
            player.rangedCrit += 10;
            player.magicCrit += 10;
            player.thrownCrit += 10;
            player.allDamage += 0.15f;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1301, 1); //modded materials
            recipe.AddIngredient(ItemID.FragmentVortex, 10);
            recipe.AddIngredient(ItemID.FragmentNebula, 10);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.FragmentStardust, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
