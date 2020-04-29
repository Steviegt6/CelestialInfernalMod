using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class CrimFossilShirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life-stealing Successor's Shirt");
                Tooltip.SetDefault("Increases throwing critical chance by 10%"
                                   +"\nIncreases throwing damage by 20%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 250000;
            item.rare = 4;
            item.defense = 17; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("CrimFossilMask") && legs.type == mod.ItemType("CrimFossilBoots");
        }
         public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(151, 36000);
            player.thrownCost50 = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.thrownCrit += 10;
            player.thrownDamage += 0.2f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(3375, 1);
            r.AddIngredient(1332, 10);
            r.AddIngredient(521, 20);
            r.AddIngredient(892, 1);
            r.AddTile(134);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}