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
    public class PutridCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Corruption and the Crimson's power is pulsing inside it"
                                + "\nYou get Crimson Regen while having this equiped"
                                + "\nYou are immune to Cursed Inferno and Ichor debuff"
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
            player.crimsonRegen = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Ichor] = true;
        }
    }
}
