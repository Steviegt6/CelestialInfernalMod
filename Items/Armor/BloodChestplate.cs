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
    [AutoloadEquip(EquipType.Body)]
    public class BloodChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Drop Chestplate");
                Tooltip.SetDefault("Increases damage by 10% and critical chance by 5%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 50000;
            item.rare = 3;
            item.defense = 5; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("BloodHelm") && legs.type == mod.ItemType("BloodGreaves");
        }
         public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases the efficiency of your marrow";
            player.lifeRegen += 2;
            player.buffImmune[30] = true;
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeCrit += 5;
            player.rangedCrit += 5;
            player.magicCrit += 5;
            player.thrownCrit += 5;
            player.allDamage += 0.1f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(728, 1);
            r.AddIngredient(ModContent.ItemType<BloodDrop>(), 20);
            r.AddTile(16);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}