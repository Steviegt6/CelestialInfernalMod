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
    public class EclipseCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The power of the sun covered by the moon"
                                + "\nIncreased armor penetration by 5" +
                                "\nIncreased critical strike chance by 10%"
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
            player.armorPenetration += 5;
            player.meleeCrit += 10;
            player.rangedCrit += 10;
            player.magicCrit += 10;
            player.thrownCrit += 10;
            player.allDamage += 0.1f;
        }
    }
}
