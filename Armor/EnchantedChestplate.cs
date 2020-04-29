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
    public class EnchantedChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Chestplate");
                Tooltip.SetDefault("Increased all damage by 3% and all crit chance by 3");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 20;
            item.value = 1000;
            item.rare = 2;
            item.defense = 8; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("EnchantedHelmet") && legs.type == mod.ItemType("EnchantedLeggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.3f;
            player.meleeCrit += 3;
            player.rangedCrit += 3;
            player.magicCrit += 3;
            player.thrownCrit += 3;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "You feel empowered! Increased all damage by 10% and all crit by 5";
            player.allDamage += 0.10f;
            player.meleeCrit += 5;
            player.rangedCrit += 5;
            player.magicCrit += 5;
            player.thrownCrit += 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("EnchantedShard"), 5); //modded materials
            recipe.AddIngredient(ItemID.Wood, 4); //vanilla materials
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}