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
    public class PutridHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Putrid Helmet");
                                   Tooltip.SetDefault("Increased endurance by 7%");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 1000;
            item.rare = 2;
            item.defense = 7; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("PutridChestplate") && legs.type == mod.ItemType("PutridGreaves");
        }

        public override void UpdateEquip(Player player)
        {
            player.endurance += 0.07f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("PutridVertebrae"), 25);
            r.AddIngredient(ItemID.RottenChunk, 13);
            r.AddTile(TileID.MythrilAnvil);
            r.SetResult(this);
            r.AddRecipe();

            r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("PutridVertebrae"), 25);
            r.AddIngredient(ItemID.Vertebrae, 13);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}