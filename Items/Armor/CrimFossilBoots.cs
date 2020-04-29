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
    [AutoloadEquip(EquipType.Legs)]
    public class CrimFossilBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life-stealing Successor's Boots");
                Tooltip.SetDefault("Increases throwing critical chance by 10%"
                                   +"\nIncreases movement speed");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 200000;
            item.rare = 4;
            item.defense = 13; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("CrimFossilMask") && body.type == mod.ItemType("CrimFossilShirt");
        }

        public override void UpdateEquip(Player player)
        {
            player.thrownCrit += 10;
            player.maxRunSpeed += 10f;
            player.noFallDmg = true;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(3376, 1);
            r.AddIngredient(1332, 6);
            r.AddIngredient(521, 15);
            r.AddTile(134);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}