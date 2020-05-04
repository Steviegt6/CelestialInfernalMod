using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CelestialInfernalMod.Items.Materials;

namespace CelestialInfernalMod.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class BloodGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Drop Greaves");
                Tooltip.SetDefault("Increases movement speed by 15%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 40000;
            item.rare = 3;
            item.defense = 4; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("BloodHelm") && body.type == mod.ItemType("BloodChestplate");
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.15f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(729, 1);
            r.AddIngredient(ModContent.ItemType<BloodDrop>(), 16);
            r.AddTile(16);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}