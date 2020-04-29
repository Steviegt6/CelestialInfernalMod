using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CelestialInfernalMod.Items.NPCs
{
    [AutoloadBossHead]
    public class PutridCoagulation : ModNPC
    {
        private Player player;
        private float speed;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Putrid Coagulation");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.lifeMax = 6000;
            npc.damage = 40;
            npc.defense = 20;
            npc.knockBackResist = 0f;
            npc.width = 128;
            npc.height = 128;
            npc.value = 50000;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit18;
            npc.DeathSound = SoundID.NPCDeath1;
            music = MusicID.Boss2;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (Main.rand.Next(10) == 0)
            {
                NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BigCrimera);
            }
            if (Main.rand.Next(20) == 1)
            {
                NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BigEater);
            }
        }

        public override void AI()
        {
            Target();

            DespawnHandler();

            Move(new Vector2(0, -100f));

            npc.ai[1]++;
            if (npc.ai[1] % 110 == 0)
            {
                float Speed = 10f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
                int damage = 25;
                int type = Main.rand.Next(2);
                switch (type)
                {
                    case 0:
                      type = ProjectileID.CursedFlameHostile;
                        break;
                    case 1:
                        type = ProjectileID.GoldenShowerHostile;
                        break;
                }
                Main.PlaySound(4, (int)npc.position.X, (int)npc.position.Y, 13);
                float rotation = (float)Math.Atan2(vector8.Y - (player.position.Y + (player.height * 0.5f)), vector8.X - (player.position.X + (player.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
            }
            if (npc.ai[1] == 600)
            {
                npc.ai[1] = 0;   
            }
        }

        private void Target()
        {
            player = Main.player[npc.target];
        }

        private void Move(Vector2 offset)
        {
            speed = 6f + Main.rand.Next(6);
            Vector2 moveTo = player.Center + offset * 2f;
            Vector2 move = moveTo - npc.Center;
            float magnitude = Magnitude(move);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            float turnResistance = 10f;
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            magnitude = Magnitude(move);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            npc.velocity = move;
        }

        private void DespawnHandler()
        {
            if (!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if (!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, -10f);
                    if (npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                }
                return;
            }
        }
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense + numPlayers);
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 1;
            npc.frameCounter %= 20;
            int frame = (int)(npc.frameCounter / 2.0);
            if (frame >= Main.npcFrameCount[npc.type]) frame = 0;
            npc.frame.Y = frame * frameHeight;
        }
        public override void NPCLoot()
        {
            if(Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PutridCoagulationBag"));
            }
            else
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PutridVertebrae"), Main.rand.Next(12, 16));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.RottenChunk, Main.rand.Next(15, 30));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Vertebrae, Main.rand.Next(15, 30));
            }
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = 188;
        }
    }
}
