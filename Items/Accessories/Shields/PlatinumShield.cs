using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Accessories.Shields 
{
    public class PlatinumShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A diamond-powered shield that lets you dash");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 48;
            item.height = 48;
            item.value = Item.buyPrice(0, 2, 40, 0);
            item.rare = 0;
            item.defense = 2;
            item.expert = false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 0.04f;
            player.dash = 2;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(706, 25);
			recipe.AddIngredient(182, 10);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
