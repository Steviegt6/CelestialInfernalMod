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
    public class GoldShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A ruby-powered shield that lets you dash");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 48;
            item.height = 48;
            item.value = Item.buyPrice(0, 2, 20, 0);
            item.rare = 0;
            item.defense = 2;
            item.expert = false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 0.04f;
            player.dash = 1;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(19, 25);
			recipe.AddIngredient(178, 10);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
