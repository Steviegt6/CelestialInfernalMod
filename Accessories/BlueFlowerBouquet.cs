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
    public class BlueFlowerBouquet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This beautiful bouquet fills your body with energy"
                                 + "\nIt increases your max mana by 100 when worn."
                                    + "\nIncreased mana regeneration.");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 48;
            item.height = 48;
            item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 9;
            item.expert = false;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaRegen += 3;
            player.statManaMax2 += 100;
        }
        public override void AddRecipes() 
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NaturesGift, 3);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
        }
    }
}
