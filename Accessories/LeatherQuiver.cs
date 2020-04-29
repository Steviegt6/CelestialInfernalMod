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
    public class LeatherQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A leather quiver that gives benefits for rangers");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 48;
            item.height = 48;
            item.value = Item.buyPrice(0, 1, 25, 0);
            item.rare = 1;
            item.expert = false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.ammoCost80 = true;
            player.rangedCrit += 5;
            player.rangedDamage += 0.05f;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(259, 10);
			recipe.AddIngredient(40, 50);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
