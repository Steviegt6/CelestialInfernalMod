using System;
using System.IO;
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
    public class HigherPixie : ModNPC
    {
        private Player player;
        private float speed;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Higher Pixie");
            Main.npcFrameCount[npc.type] = 10;
        }

        public override void SetDefaults()
        {
            npc.lifeMax = 24000;
            npc.damage = 65;
            npc.defense = 20;
            npc.knockBackResist = 0f;
            npc.width = 50;
            npc.height = 60;
            npc.value = 150000;
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit5;
            npc.DeathSound = SoundID.NPCDeath7;
            npc.scale = 1.5f;
            bossBag = mod.ItemType("HigherPixieTreasureBag");
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/SunDance");
        }

        public override void AI()
        {
            Target();

            DespawnHandler();

            Move(new Vector2(0, -100f));
        
            npc.ai[1]++;
            if (npc.ai[1] >= 120)
            {
                int PixieAttack = Main.rand.Next(3);
            switch (PixieAttack)
            {
                case 0:
                if (npc.ai[1] % 30 == 0)
                {
                NPC.NewNPC((int)npc.Center.X + 20, (int)npc.Center.Y, NPCID.Pixie);
                }
                if (npc.ai[1] >= 180)
                {    
                npc.ai[1] = 0;
                }
                break;
            case 1:
                if (npc.ai[1] % 15 == 0)
                {
                float Speed = 8f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width), npc.position.Y + (npc.height / 2));
                int damage = 40;
                int type = ProjectileID.LostSoulHostile;
                Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 8);
                float rotation = (float)Math.Atan2(vector8.Y - (player.position.Y + (player.height * 0.5f)), vector8.X - (player.position.X + (player.width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                }
                if (npc.ai[1] >= 160)
                {    
                npc.ai[1] = 0;
                }
                break;
            case 2:
                if (npc.ai[1] % 10 == 0)
                {
                float IceSpeed = 5f;
                Vector2 vector9 = new Vector2(npc.position.X + Main.rand.Next(-250, 250), npc.position.Y - 400);
                int IceDamage = 50;
                int IceType = 174;
                Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 9);
                float IceRotation = (float)Math.Atan2(vector9.Y - (player.position.Y + (player.height * 0.5f)), vector9.X - (player.position.X + (player.width * 0.5f)));
                int num55 = Projectile.NewProjectile(vector9.X, vector9.Y, (float)((Math.Cos(IceRotation) * IceSpeed) * -1), (float)((Math.Sin(IceRotation) * IceSpeed) * -1), IceType, IceDamage, 0f, 0);
                }
                if (npc.ai[1] >= 180)
                {    
                npc.ai[1] = 0;
                }
                break;
            }
        }
    }

        private void Target()
        {
            player = Main.player[npc.target];
        }

        private void Move(Vector2 offset)
        {
            speed = 6f;
            Vector2 moveTo = player.Center + offset;
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
            npc.damage = (int)(npc.damage + 30f);
            npc.defense = (int)(npc.defense * 1.5f);
        }
        
        private const int Frame_Idle_1 = 0;
        private const int Frame_Idle_2 = 1;
        private const int Frame_Idle_3 = 2;
        private const int Frame_Spell_1 = 3;
        private const int Frame_Spell_2 = 4;
        private const int Frame_Spell_3 = 5;
		  
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter++;
            if (npc.ai[1] >= 120)
            {
                if (npc.frameCounter < 5) {
					npc.frame.Y = Frame_Spell_1 * frameHeight;
				}
				else if (npc.frameCounter < 10) {
					npc.frame.Y = Frame_Spell_2 * frameHeight;
				}
				else if (npc.frameCounter < 15) {
					npc.frame.Y = Frame_Spell_3 * frameHeight;
				}
                else if (npc.frameCounter < 20) {
					npc.frame.Y = Frame_Spell_2 * frameHeight;
				}
				else {
					npc.frameCounter = 0;
				} 
            }
            else
            {
                if (npc.frameCounter < 5) {
					npc.frame.Y = Frame_Idle_1 * frameHeight;
				}
				else if (npc.frameCounter < 10) {
					npc.frame.Y = Frame_Idle_2 * frameHeight;
				}
				else if (npc.frameCounter < 15) {
					npc.frame.Y = Frame_Idle_3 * frameHeight;
				}
                else if (npc.frameCounter < 20) {
					npc.frame.Y = Frame_Idle_2 * frameHeight;
				}
				else {
					npc.frameCounter = 0;
				} 
            }
        }
        public override void NPCLoot()
        {
            if(Main.expertMode)
            {
                npc.DropBossBags();
            }
            else
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DensePixieDust"), Main.rand.Next(12, 16));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PixieDust, Main.rand.Next(20, 32));
            }
            CelestialInfernalModWorld.downedHigherPixie = true;
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = 499;
        }
    }
}
