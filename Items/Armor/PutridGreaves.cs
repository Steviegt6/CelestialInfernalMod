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
    public class PutridGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
                                   Tooltip.SetDefault("Increases movement speed by 5%"
                                   + "Increases damage reduction by 3%");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 50000;
            item.rare = 3;
            item.defense = 7; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("PutridHelmet") && legs.type == mod.ItemType("PutridChestplate");
        }

        public override void UpdateEquip(Player player)
        {
            player.endurance += 0.03f;
            player.moveSpeed += 0.05f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("PutridVertebrae"), 20);
            r.AddIngredient(ItemID.RottenChunk, 8);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();

            r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("PutridVertebrae"), 20);
            r.AddIngredient(ItemID.Vertebrae, 8);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}