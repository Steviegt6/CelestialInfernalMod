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
    public class RoyalMushroomHelmet : ModItem
    {
            public override void SetStaticDefaults()
            {
            DisplayName.SetDefault("Royal Mushroom Helmet");
                                    Tooltip.SetDefault("Increased life regen and ranged stats");
        }

            public override void SetDefaults()
            {
                item.width = 24;
                item.height = 20;
                item.value = 1000;
                item.rare = 1;
                item.defense = 3; // The Defence value for this piece of armour.
            }

            public override bool IsArmorSet(Item head, Item body, Item legs)
            {
                return body.type == mod.ItemType("RoyalMushroomChestpiece") && legs.type == mod.ItemType("RoyalMushroomGreaves");
            }

        public override void UpdateEquip(Player player)
        {
            player.lifeRegen += 2;
            player.rangedDamage += 0.1f;
			player.rangedCrit += 5;
            player.ammoCost80 = true;
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