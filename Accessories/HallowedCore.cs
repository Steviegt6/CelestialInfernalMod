using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CelestialInfernalMod.Items.Accessories
{
    public class HallowedCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A relic holding the power of the Hallow"
                                + "\nIncreased all critical strike chance by 15%."
                                + "\nIncreased all damage by 10%;");
        }
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 32;
            item.height = 32;
            item.value = item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 9;
            item.expert = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 0.1f;
            player.meleeCrit += 15;
            player.rangedCrit += 15;
            player.magicCrit += 15;
            player.thrownCrit += 15;
        }
    }
}
