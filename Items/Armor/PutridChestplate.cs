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
    public class PutridChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases damage by 10%"
            +"\nIncreases damage reduction by 4%");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 50000;
            item.rare = 3;
            item.defense = 8; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("PutridHelmet") && legs.type == mod.ItemType("PutridGreaves");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(63, 36000);
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.1f;
            player.endurance += 0.04f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("PutridVertebrae"), 30);
            r.AddIngredient(ItemID.RottenChunk, 20);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();

            r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("PutridVertebrae"), 30);
            r.AddIngredient(ItemID.Vertebrae, 20);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}