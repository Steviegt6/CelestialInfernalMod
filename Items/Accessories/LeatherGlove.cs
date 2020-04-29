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
    public class LeatherGlove : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leather Glove");
            Tooltip.SetDefault("A leather glove that gives a chance to not consume throwing weapons");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 22;
            item.height = 24;
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.rare = 1;
            item.expert = false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownCost33 = true;
        }
        public override void AddRecipes() 
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.Leather, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
