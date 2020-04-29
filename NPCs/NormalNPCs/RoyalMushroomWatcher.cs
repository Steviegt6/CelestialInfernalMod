using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace CelestialInfernalMod.NPCs.NormalNPCs
{
    public class RoyalMushroomWatcher : ModNPC
    {

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.width = 80;
            npc.height = 55;
            npc.damage = 10;
            npc.defense = 1;
            npc.lifeMax = 50;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 50f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 3;
            aiType = NPCID.BlueSlime;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 2f;
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Mushroom, Main.rand.Next(3, 8));
        }
    }
}
