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
    public class LeatherCap : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leather Cap");
                Tooltip.SetDefault("Increases minion knockback by 15%"
                                + "\nMinion damage increased by 3%");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.value = 10000;
            item.rare = 1;
            item.defense = 3; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("LeatherShirt") && legs.type == mod.ItemType("LeatherLeggings");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(45, 3600);
            player.minionDamage += 0.1f;
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.03f;
            player.minionKB += 0.15f;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(259, 4);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
            r = new ModRecipe(mod);
            r.AddIngredient(1330, 20);
            r.AddTile(TileID.Anvils);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}