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
    public class DensePixieLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dense Pixie Leggings");
                                   Tooltip.SetDefault("Increased all damage by 5%"
                                   + "\nIncreased movement speed by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 1000;
            item.rare = 5;
            item.defense = 15; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("DensePixieHelmet") && body.type == mod.ItemType("DensePixieChestplate");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Summons a pixie";
            player.AddBuff(27, 36000);
        }
        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.05f;
            player.moveSpeed += 0.1f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("DensePixieDust"), 25);
            r.AddIngredient(ItemID.PixieDust, 15);
            r.AddTile(TileID.MythrilAnvil);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}