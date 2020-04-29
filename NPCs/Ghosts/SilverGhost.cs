using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.NPCs.Ghosts
{
    public class SilverGhost : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 1;
        }
        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 40;
            npc.damage = 16;
            npc.defense = 11;
            npc.lifeMax = 55;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 300f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 23;
            aiType = 84;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (!Main.hardMode && spawnInfo.player.ZoneRockLayerHeight || !Main.hardMode && spawnInfo.player.ZoneDirtLayerHeight) 
                {
                return 0.025f;
                }
            else if (!Main.dayTime && !Main.hardMode && spawnInfo.player.ZoneOverworldHeight || Main.hardMode && spawnInfo.player.ZoneRockLayerHeight || Main.hardMode && spawnInfo.player.ZoneDirtLayerHeight) 
                {
                return 0.01f;
                }
            else
                {
                return 0f;
                }
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SilverOre, Main.rand.Next(5, 13));
            if (Main.rand.Next(10) < 1)
            {
                Item.NewItem(npc.getRect(), ItemID.SilverBroadsword, Main.rand.Next(1, 2));
            }
        }
    }
}
