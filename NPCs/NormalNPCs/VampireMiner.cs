using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace CelestialInfernalMod.NPCs.NormalNPCs
{
    public class VampireMiner : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 15;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 48;
            npc.damage = 30;
            npc.defense = 16;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit35;
            npc.DeathSound = SoundID.NPCDeath4;
            npc.value = 500f;
            npc.knockBackResist = 0.30f;
            npc.aiStyle = 3;
            aiType = 44;
            animationType = 44;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedBoss2 == true && spawnInfo.player.ZoneRockLayerHeight) 
                {
                return 0.1f;
                }
            else
                {
                return 0f;
                }
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Batpick"), Main.rand.Next(1, 2));
        }
    }
}
