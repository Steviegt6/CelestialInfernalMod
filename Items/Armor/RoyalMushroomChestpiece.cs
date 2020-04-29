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
    public class RoyalMushroomChestpiece : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Royal Mushroom Chestpiece");
                Tooltip.SetDefault("Increased life regen by 3");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 1000;
            item.rare = 2;
            item.defense = 5; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("RoyalMushroomHelmet") && legs.type == mod.ItemType("RoyalMushroomGreaves");
        }

        public override void UpdateEquip(Player player)
        {
            player.lifeRegen += 3;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("RoyalMushroom"), 30);
            r.AddIngredient(ItemID.Mushroom, 15);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}