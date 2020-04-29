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
    [AutoloadEquip(EquipType.Head)]
    public class CrimFossilMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life-stealing Successor's Mask");
                Tooltip.SetDefault("Increases throwing damage by 10%"
                                   +"\nIncreases throwing velocity by 25%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 150000;
            item.rare = 4;
            item.defense = 9; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("CrimFossilShirt") && legs.type == mod.ItemType("CrimFossilBoots");
        }

        public override void UpdateEquip(Player player)
        {
            player.thrownDamage += 0.1f;
            player.thrownVelocity += 0.25f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(3374, 1);
            r.AddIngredient(1332, 4);
            r.AddIngredient(521, 10);
            r.AddTile(134);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}