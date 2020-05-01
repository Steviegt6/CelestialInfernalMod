using CelestialInfernalMod.Items.Materials;
using CelestialInfernalMod.Items.SummonItems;
using CelestialInfernalMod.Items.Weapons.Magic;
using CelestialInfernalMod.Items.Weapons.Throwing;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CelestialInfernalMod.NPCs
{
    public class CelestialInfernalGlobalNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            Player player = Main.player[Main.myPlayer];
            switch (type)
            {
                case NPCID.Wizard:
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<SorcererBlade>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<StarCane>());
                        nextSlot++;
                    }
                    break;
                case NPCID.Merchant:
					if (NPC.downedBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<SuspiciousLookingMushroom>());
                        nextSlot++;
                    }
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(ItemType<CursedKnife>());
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemType<IchorKnife>());
                        nextSlot++;
                    }
                    break;
            }
        }

		public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.Mothron && Main.rand.NextBool(4))
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemType<BrokenHeroBow>(), 1);
			}
			if (npc.type == NPCID.Pixie && Main.rand.NextBool(100))
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemType<PixieMedalion>(), 1);
			}
			if (Main.rand.NextBool(100) && NPC.downedBoss3)
			{
				if (npc.type == NPCID.EaterofSouls || npc.type == NPCID.Crimera)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemType<GrossSpine>(), 1);
				}
			}
			if (npc.type == NPCID.VoodooDemon && Main.rand.NextBool(10))
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemType<DemonicIdol>(), 1);
			}
			if (npc.type == NPCID.EaterofWorldsHead && Main.rand.NextBool(20))
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemType<EaterofMana>(), 1);
			}
		}
    }
}
