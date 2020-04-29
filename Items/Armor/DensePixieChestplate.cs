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
    public class DensePixieChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dense Pixie Chestplate");
            Tooltip.SetDefault("Increased all damage by 10%"
            +"Increased damage reduction by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 1000;
            item.rare = 5;
            item.defense = 18; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("DensePixieHelmet") && legs.type == mod.ItemType("DensePixieLeggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += 0.1f;
            player.endurance += 0.1f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("DensePixieDust"), 30);
            r.AddIngredient(ItemID.PixieDust, 20);
            r.AddTile(TileID.MythrilAnvil);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}