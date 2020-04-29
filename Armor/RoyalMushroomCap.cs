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
    public class RoyalMushroomCap : ModItem
    {
            public override void SetStaticDefaults()
            {
            DisplayName.SetDefault("Royal Mushroom Cap");
                                    Tooltip.SetDefault("Increased life regen and magic stats");
        }

            public override void SetDefaults()
            {
                item.width = 22;
                item.height = 16;
                item.value = 1000;
                item.rare = 1;
                item.defense = 2; // The Defence value for this piece of armour.
            }

            public override bool IsArmorSet(Item head, Item body, Item legs)
            {
                return body.type == mod.ItemType("RoyalMushroomChestpiece") && legs.type == mod.ItemType("RoyalMushroomGreaves");
            }

        public override void UpdateEquip(Player player)
        {
            player.lifeRegen += 2;
            player.magicDamage += 0.1f;
			player.magicCrit += 5;
            player.statManaMax2 += 20;
            player.manaCost -= 0.1f;
        }


        public override void AddRecipes()
            {
                ModRecipe r = new ModRecipe(mod);
                r.AddIngredient(mod.ItemType("RoyalMushroom"), 25);
                r.AddIngredient(ItemID.Mushroom, 10);
                r.AddTile(TileID.Anvils);
                r.SetResult(this);
                r.AddRecipe();
            }
    }
}