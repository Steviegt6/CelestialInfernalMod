using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
                        shop.item[nextSlot].SetDefaults(mod.ItemType("SorcererBlade"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("StarCane"));
                        nextSlot++;
                    }
                    break;
                case NPCID.Merchant:
                    if (Main.hardMode)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("CursedKnife"));
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(mod.ItemType("IchorKnife"));
                        nextSlot++;
                    }
                    break;
            }
        }
         public override void NPCLoot(NPC npc)
        {
         if (npc.type == NPCID.Mothron && Main.rand.Next(4) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BrokenHeroBow"), 1);
            }
         if (npc.type == NPCID.Pixie && Main.rand.Next(100) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PixieMedalion"), 1);
            }
         if (Main.rand.Next(100) == 0 && NPC.downedBoss3 == true && npc.type == NPCID.EaterofSouls || Main.rand.Next(100) == 0 && NPC.downedBoss3 == true && npc.type == NPCID.Crimera)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GrossSpine"), 1);
            }
         if (npc.type == NPCID.VoodooDemon && Main.rand.Next(10) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DemonicIdol"), 1);
            }
         if (npc.type == NPCID.EaterofWorldsHead && Main.rand.Next(20) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EaterofMana"), 1);
            }
        }
    }
}