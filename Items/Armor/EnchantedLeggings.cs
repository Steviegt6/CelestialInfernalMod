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
    public class EnchantedLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Leggings");
                                Tooltip.SetDefault("Increased damage by 2%");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 6; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("EnchantedHelmet") && legs.type == mod.ItemType("EnchantedChestplate");
        }
        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.2f;
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
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("RoyalMushroom"), 20);
            r.AddIngredient(ItemID.Mushroom, 8);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}