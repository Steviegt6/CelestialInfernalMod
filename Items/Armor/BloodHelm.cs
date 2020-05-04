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
    [AutoloadEquip(EquipType.Head)]
    public class BloodHelm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Drop Helm");
                Tooltip.SetDefault("Increases all damage by 5%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 60000;
            item.rare = 3;
            item.defense = 3; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("BloodChestplate") && legs.type == mod.ItemType("BloodGreaves");
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.05f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(727, 1);
            r.AddIngredient(ModContent.ItemType<BloodDrop>(), 12);
            r.AddTile(16);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}