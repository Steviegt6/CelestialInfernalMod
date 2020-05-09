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
    public class HeavyShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A heavy shield that grants immunity to knockback");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 48;
            item.height = 48;
            item.value = Item.buyPrice(0, 0, 50, 0);
            item.rare = 0;
            item.defense = 4;
            item.expert = false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.noKnockback = true;
            player.maxRunSpeed -= 0.8f;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(129, 25);
			recipe.AddIngredient(9, 20);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
