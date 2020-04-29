using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.NPCs.Ghosts
{
    public class GrassGhost : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 1;
        }
        public override void SetDefaults()
        {
            npc.width = 56;
            npc.height = 56;
            npc.damage = 28;
            npc.defense = 28;
            npc.lifeMax = 140;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 1350f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 23;
            aiType = 84;
        }
        public override void OnHitPlayer(Player player, int damage, bool crit)
        {
            if (Main.rand.Next(4) == 0) // the chance
            {
                player.AddBuff(BuffID.Poisoned, 300, true);
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (!Main.hardMode && spawnInfo.player.ZoneRockLayerHeight && NPC.downedBoss2 && spawnInfo.player.ZoneJungle) 
                {
                return 0.025f;
                }
            else if (!Main.hardMode && spawnInfo.player.ZoneOverworldHeight && NPC.downedBoss2 && spawnInfo.player.ZoneJungle || Main.hardMode && spawnInfo.player.ZoneRockLayerHeight && spawnInfo.player.ZoneJungle || Main.hardMode && spawnInfo.player.ZoneDirtLayerHeight && spawnInfo.player.ZoneJungle) 
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
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.JungleSpores, Main.rand.Next(3, 9));
            if (Main.rand.Next(10) < 1)
            {
                Item.NewItem(npc.getRect(), ItemID.BladeofGrass, Main.rand.Next(1, 2));
            }
        }
    }
}
