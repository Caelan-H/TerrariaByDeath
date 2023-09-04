using System.Net.Http.Headers;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;

using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;

using Terraria.UI;
using Terraria.IO;
using Terraria.Server;
using Terraria.WorldBuilding;
using System.Threading.Tasks;

namespace ReturnByDeath
{
	public class ReturnByDeath : ModPlayer
	{
        public static int checkPointFallStart;
        public static int checkPointFallStart2;
        public static Vector2 checkPointPosition;
        public static Vector2 checkPointBodyPosition;
        public static float checkPointBodyRotation;
        public static Vector2 checkPointBodyVelocity;
        public static bool hasDied = false;
        public ReturnByDeath()
        {
           
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (target.life <= 0)
            {
                CheckPoint();
            }
                base.OnHitNPCWithProj(proj, target, hit, damageDone);
        }
        public override bool OnPickup(Item item)
        {
            if(item.Name == "Dirt Block")
            {

               

               
            }

            if (item.Name == "Mushroom")
            {
                if(System.IO.Directory.Exists(Player.name.ToString()))
                {
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr"))
                    {
                        if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() +  ".plr"))
                        {
                            System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr");
                            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr");

                        }
                        else
                        {
                            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr");

                        }

                    }
                    
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak"))
                    {
                        if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak"))
                        {
                            System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak");
                            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak");

                        }
                        else
                        {
                            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak");

                        }

                    }

                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr"))
                    {
                        if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr"))
                        {
                            System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr");
                            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr");

                        }
                        else
                        {
                            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr");

                        }

                    }

                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak"))
                    {
                        if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak"))
                        {
                            System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak");
                            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak");

                        }
                        else
                        {
                            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak");

                        }

                    }
                    
                }





                //Player.LoadPlayer("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr",false);
                // PreKill() 
                PlayerFileData playerFile = Player.GetFileData("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", false);
                StreamReader a = File.OpenText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData");

                Main.LocalPlayer.inventory = playerFile.Player.inventory;
                
                //CODE THAT PREVENTS MOVEMENT AFTER PICKUP INSIDE

                Main.LocalPlayer.abigailMinion = playerFile.Player.abigailMinion;
                Main.LocalPlayer.accCalendar = playerFile.Player.accCalendar;
                Main.LocalPlayer.accCompass = playerFile.Player.accCompass;
                Main.LocalPlayer.accCritterGuide = playerFile.Player.accCritterGuide;
                Main.LocalPlayer.accCritterGuideCounter = playerFile.Player.accCritterGuideCounter;
                Main.LocalPlayer.accCritterGuideNumber = playerFile.Player.accCritterGuideNumber;
                Main.LocalPlayer.accDepthMeter = playerFile.Player.accDepthMeter;
                Main.LocalPlayer.accDivingHelm = playerFile.Player.accDivingHelm;
                Main.LocalPlayer.accDreamCatcher = playerFile.Player.accDreamCatcher;
                Main.LocalPlayer.accFishFinder = playerFile.Player.accFishFinder;
                Main.LocalPlayer.accFishingBobber = playerFile.Player.accFishingBobber;
                Main.LocalPlayer.accFishingLine = playerFile.Player.accFishingLine;
                Main.LocalPlayer.accJarOfSouls = playerFile.Player.accJarOfSouls;
                Main.LocalPlayer.accLavaFishing = playerFile.Player.accLavaFishing;
                Main.LocalPlayer.accMerman = playerFile.Player.accMerman;
                Main.LocalPlayer.accOreFinder = playerFile.Player.accOreFinder;
                Main.LocalPlayer.accRunSpeed = playerFile.Player.accRunSpeed;
                Main.LocalPlayer.accStopwatch = playerFile.Player.accStopwatch;
                Main.LocalPlayer.accTackleBox = playerFile.Player.accTackleBox;
                Main.LocalPlayer.accThirdEye = playerFile.Player.accThirdEye;
                Main.LocalPlayer.accThirdEyeCounter = playerFile.Player.accThirdEyeCounter;
                Main.LocalPlayer.accThirdEyeNumber = playerFile.Player.accThirdEyeNumber;
                Main.LocalPlayer.accWatch  = playerFile.Player.accWatch;
                Main.LocalPlayer.accWeatherRadio = playerFile.Player.accWeatherRadio;
                //Main.LocalPlayer.active = playerFile.Player.active;
                Main.LocalPlayer.ActuationRodLock = playerFile.Player.ActuationRodLock;
                Main.LocalPlayer.ActuationRodLockSetting = playerFile.Player.ActuationRodLockSetting;
                Main.LocalPlayer.adjHoney = playerFile.Player.adjHoney;
                Main.LocalPlayer.adjLava = playerFile.Player.adjLava;
                Main.LocalPlayer.adjShimmer = playerFile.Player.adjShimmer;
                Main.LocalPlayer.adjWater = playerFile.Player.adjWater;
                Main.LocalPlayer.afkCounter = playerFile.Player.afkCounter;
                Main.LocalPlayer.aggro = playerFile.Player.aggro;
                Main.LocalPlayer.alchemyTable = playerFile.Player.alchemyTable;
                Main.LocalPlayer.altFunctionUse = playerFile.Player.altFunctionUse;
                Main.LocalPlayer.ammoBox = playerFile.Player.ammoBox;
                Main.LocalPlayer.ammoCost75 = playerFile.Player.ammoCost75;
                Main.LocalPlayer.ammoCost80 = playerFile.Player.ammoCost80;
                Main.LocalPlayer.ammoPotion = playerFile.Player.ammoPotion;
                
                //CODE THAT FREEZES ABOVE
                Main.LocalPlayer.anglerQuestsFinished = playerFile.Player.anglerQuestsFinished;
                Main.LocalPlayer.anglerSetSpawnReduction = playerFile.Player.anglerSetSpawnReduction;
                Main.LocalPlayer.archery = playerFile.Player.archery;
                Main.LocalPlayer.arcticDivingGear = playerFile.Player.arcticDivingGear;
                Main.LocalPlayer.armor = playerFile.Player.armor;
                Main.LocalPlayer.armorEffectDrawOutlines = playerFile.Player.armorEffectDrawOutlines;
                Main.LocalPlayer.armorEffectDrawOutlinesForbidden = playerFile.Player.armorEffectDrawOutlinesForbidden;
                Main.LocalPlayer.armorEffectDrawShadow = playerFile.Player.armorEffectDrawShadow;
                Main.LocalPlayer.armorEffectDrawShadowBasilisk = playerFile.Player.armorEffectDrawShadowBasilisk;
                Main.LocalPlayer.armorEffectDrawShadowEOCShield = playerFile.Player.armorEffectDrawShadowEOCShield;
                Main.LocalPlayer.armorEffectDrawShadowLokis = playerFile.Player.armorEffectDrawShadowLokis;
                Main.LocalPlayer.armorEffectDrawShadowSubtle = playerFile.Player.armorEffectDrawShadowSubtle;
                Main.LocalPlayer.arrowDamage = playerFile.Player.arrowDamage;
                Main.LocalPlayer.ashWoodBonus = playerFile.Player.ashWoodBonus;
                Main.LocalPlayer.ateArtisanBread = playerFile.Player.ateArtisanBread;
                Main.LocalPlayer.attackCD = playerFile.Player.attackCD;
                Main.LocalPlayer.autoActuator = playerFile.Player.autoActuator;
                Main.LocalPlayer.autoJump = playerFile.Player.autoJump;
                Main.LocalPlayer.autoPaint = playerFile.Player.autoPaint;
                Main.LocalPlayer.autoReuseAllWeapons = playerFile.Player.autoReuseAllWeapons;
                Main.LocalPlayer.autoReuseGlove = playerFile.Player.autoReuseGlove;
                Main.LocalPlayer.availableAdvancedShadowsCount = playerFile.Player.availableAdvancedShadowsCount;
                Main.LocalPlayer.babyBird = playerFile.Player.babyBird;
                Main.LocalPlayer.babyFaceMonster = playerFile.Player.babyFaceMonster;
                Main.LocalPlayer.back = playerFile.Player.back;
                Main.LocalPlayer.backpack = playerFile.Player.backpack;
                Main.LocalPlayer.ballistaPanic = playerFile.Player.ballistaPanic;
                Main.LocalPlayer.balloon = playerFile.Player.balloon;
                Main.LocalPlayer.balloonFront = playerFile.Player.balloonFront;
                Main.LocalPlayer.bank = playerFile.Player.bank;
                Main.LocalPlayer.bank2 = playerFile.Player.bank2;
                Main.LocalPlayer.bank3 = playerFile.Player.bank3;
                Main.LocalPlayer.bank4 = playerFile.Player.bank4;
                Main.LocalPlayer.bartenderQuestLog = playerFile.Player.bartenderQuestLog;
                Main.LocalPlayer.basiliskCharge = playerFile.Player.basiliskCharge;
                Main.LocalPlayer.batsOfLight = playerFile.Player.batsOfLight;
                Main.LocalPlayer.beard = playerFile.Player.beard;
                Main.LocalPlayer.beardGrowthTimer = playerFile.Player.beardGrowthTimer;
                Main.LocalPlayer.beetleBuff = playerFile.Player.beetleBuff;
                Main.LocalPlayer.beetleCountdown = playerFile.Player.beetleCountdown;
                Main.LocalPlayer.beetleCounter = playerFile.Player.beetleCounter;
                Main.LocalPlayer.beetleDefense = playerFile.Player.beetleDefense;
                Main.LocalPlayer.beetleFrame = playerFile.Player.beetleFrame;
                Main.LocalPlayer.beetleFrameCounter = playerFile.Player.beetleFrameCounter;
                Main.LocalPlayer.beetleOffense = playerFile.Player.beetleOffense;
                Main.LocalPlayer.beetleOrbs = playerFile.Player.beetleOrbs;
                Main.LocalPlayer.beetlePos = playerFile.Player.beetlePos;
                Main.LocalPlayer.beetleVel = playerFile.Player.beetleVel;
                Main.LocalPlayer.behindBackWall = playerFile.Player.behindBackWall;
                Main.LocalPlayer.biomeSight = playerFile.Player.biomeSight;
                Main.LocalPlayer.blackBelt = playerFile.Player.blackBelt;
                Main.LocalPlayer.blackCat = playerFile.Player.blackCat;
                Main.LocalPlayer.blackout = playerFile.Player.blackout;
                Main.LocalPlayer.bleed = playerFile.Player.bleed;
                Main.LocalPlayer.blind = playerFile.Player.blind;
                Main.LocalPlayer.blockExtraJumps = playerFile.Player.blockExtraJumps;
                Main.LocalPlayer.blockRange = playerFile.Player.blockRange;
                Main.LocalPlayer.bloodMoonMonolithShader = playerFile.Player.bloodMoonMonolithShader;
                Main.LocalPlayer.blueFairy = playerFile.Player.blueFairy;
                Main.LocalPlayer.body = playerFile.Player.body;
                Main.LocalPlayer.bodyFrame = playerFile.Player.bodyFrame;
                Main.LocalPlayer.bodyFrameCounter = playerFile.Player.bodyFrameCounter;
                // FIXED ORBIT ISSUE, what about pause?
                //Main.LocalPlayer.bodyPosition = checkPointBodyPosition;
               // Main.LocalPlayer.bodyRotation = checkPointBodyRotation; //REMEMBER
                //Main.LocalPlayer.bodyVelocity = checkPointBodyVelocity;
                //
                Main.LocalPlayer.boneArmor = playerFile.Player.boneArmor;
                Main.LocalPlayer.boneGloveItem = playerFile.Player.boneGloveItem;
                Main.LocalPlayer.boneGloveTimer = playerFile.Player.boneGloveTimer;
                //CHECKTHIS DEATH CODE
                
               Main.LocalPlayer.brainOfConfusionDodgeAnimationCounter = playerFile.Player.brainOfConfusionDodgeAnimationCounter;
               Main.LocalPlayer.brainOfConfusionItem = playerFile.Player.brainOfConfusionItem;
               Main.LocalPlayer.breath = playerFile.Player.breath;
               Main.LocalPlayer.breathCD = playerFile.Player.breathCD;
               Main.LocalPlayer.breathMax = playerFile.Player.breathMax;
               Main.LocalPlayer.brokenArmor = playerFile.Player.brokenArmor;
               Main.LocalPlayer.buffImmune = playerFile.Player.buffImmune;
               Main.LocalPlayer.buffTime = playerFile.Player.buffTime;
               Main.LocalPlayer.buffType = playerFile.Player.buffType;
               Main.LocalPlayer.builderAccStatus = playerFile.Player.builderAccStatus;
               Main.LocalPlayer.bulletDamage = playerFile.Player.bulletDamage;
               Main.LocalPlayer.bunny = playerFile.Player.bunny;
               Main.LocalPlayer.burned = playerFile.Player.burned;
               Main.LocalPlayer.cactusThorns = playerFile.Player.cactusThorns;
               Main.LocalPlayer.calmed = playerFile.Player.calmed;
               Main.LocalPlayer.canCarpet = playerFile.Player.canCarpet;
               Main.LocalPlayer.canFloatInWater = playerFile.Player.canFloatInWater;
               Main.LocalPlayer.cAngelHalo = playerFile.Player.cAngelHalo;
               Main.LocalPlayer.canRocket = playerFile.Player.canRocket;
               Main.LocalPlayer.CanSeeInvisibleBlocks = playerFile.Player.CanSeeInvisibleBlocks;
               Main.LocalPlayer.carpet = playerFile.Player.carpet;
               Main.LocalPlayer.carpetFrame = playerFile.Player.carpetFrame;
               Main.LocalPlayer.carpetFrameCounter = playerFile.Player.carpetFrameCounter;
               Main.LocalPlayer.carpetTime = playerFile.Player.carpetTime;
               Main.LocalPlayer.cartFlip = playerFile.Player.cartFlip;
               Main.LocalPlayer.cartRampTime = playerFile.Player.cartRampTime;
               Main.LocalPlayer.cBack = playerFile.Player.cBack;
               Main.LocalPlayer.cBackpack = playerFile.Player.cBackpack;
               Main.LocalPlayer.cBalloon = playerFile.Player.cBalloon;
               Main.LocalPlayer.cBalloonFront = playerFile.Player.cBalloonFront;
               Main.LocalPlayer.cBeard = playerFile.Player.cBeard;
               Main.LocalPlayer.cBody = playerFile.Player.cBody;
               Main.LocalPlayer.cCarpet = playerFile.Player.cCarpet;
               Main.LocalPlayer.cFace = playerFile.Player.cFace;
               Main.LocalPlayer.cFaceFlower = playerFile.Player.cFaceFlower;
               Main.LocalPlayer.cFaceHead = playerFile.Player.cFaceHead;
               Main.LocalPlayer.cFlameWaker = playerFile.Player.cFlameWaker;
               Main.LocalPlayer.cFloatingTube = playerFile.Player.cFloatingTube;
               Main.LocalPlayer.cFront = playerFile.Player.cFront;
               Main.LocalPlayer.cGrapple = playerFile.Player.cGrapple;
               Main.LocalPlayer.cHandOff = playerFile.Player.cHandOff;
               Main.LocalPlayer.cHandOn = playerFile.Player.cHandOn;
               Main.LocalPlayer.changeItem = playerFile.Player.changeItem;
               Main.LocalPlayer.channel = playerFile.Player.channel;
               Main.LocalPlayer.chaosState = playerFile.Player.chaosState;
               Main.LocalPlayer.chatOverhead = playerFile.Player.chatOverhead;
               Main.LocalPlayer.cHead = playerFile.Player.cHead;
               Main.LocalPlayer.chest = playerFile.Player.chest;
               Main.LocalPlayer.chestX = playerFile.Player.chestX;
               Main.LocalPlayer.chestY = playerFile.Player.chestY;
               Main.LocalPlayer.chilled = playerFile.Player.chilled;
               Main.LocalPlayer.chiselSpeed = playerFile.Player.chiselSpeed;
               Main.LocalPlayer.chloroAmmoCost80 = playerFile.Player.chloroAmmoCost80;
               Main.LocalPlayer.CircularRadial = playerFile.Player.CircularRadial;
               Main.LocalPlayer.cLegs = playerFile.Player.cLegs;
               Main.LocalPlayer.cLeinShampoo = playerFile.Player.cLeinShampoo;
               Main.LocalPlayer.cLight = playerFile.Player.cLight;
               Main.LocalPlayer.cMinecart = playerFile.Player.cMinecart;
               Main.LocalPlayer.cMinion = playerFile.Player.cMinion;
               Main.LocalPlayer.cMount = playerFile.Player.cMount;
               Main.LocalPlayer.cNeck = playerFile.Player.cNeck;
               Main.LocalPlayer.coinLuck = playerFile.Player.coinLuck;
               Main.LocalPlayer.coldDash = playerFile.Player.coldDash;
               Main.LocalPlayer.companionCube = playerFile.Player.companionCube;
               Main.LocalPlayer.compositeBackArm = playerFile.Player.compositeBackArm;
               Main.LocalPlayer.compositeFrontArm = playerFile.Player.compositeFrontArm;
               Main.LocalPlayer.confused = playerFile.Player.confused;
               Main.LocalPlayer.controlCreativeMenu = playerFile.Player.controlCreativeMenu;
               Main.LocalPlayer.controlDown = playerFile.Player.controlDown;
               Main.LocalPlayer.controlDownHold = playerFile.Player.controlDownHold;
               Main.LocalPlayer.controlHook = playerFile.Player.controlHook;
               Main.LocalPlayer.controlInv = playerFile.Player.controlInv;
               Main.LocalPlayer.controlJump = playerFile.Player.controlJump;
               Main.LocalPlayer.controlLeft = playerFile.Player.controlLeft;
               Main.LocalPlayer.controlMap = playerFile.Player.controlMap;
               Main.LocalPlayer.controlMount = playerFile.Player.controlMount;
               Main.LocalPlayer.controlQuickHeal = playerFile.Player.controlQuickHeal;
               Main.LocalPlayer.controlQuickMana = playerFile.Player.controlQuickMana;
               Main.LocalPlayer.controlRight = playerFile.Player.controlRight;
               Main.LocalPlayer.controlSmart = playerFile.Player.controlSmart;
               Main.LocalPlayer.controlThrow = playerFile.Player.controlThrow;
               Main.LocalPlayer.controlTorch = playerFile.Player.controlTorch;
               Main.LocalPlayer.controlUp = playerFile.Player.controlUp;
               Main.LocalPlayer.controlUseItem = playerFile.Player.controlUseItem;
               Main.LocalPlayer.controlUseTile = playerFile.Player.controlUseTile;
               Main.LocalPlayer.coolWhipBuff = playerFile.Player.coolWhipBuff;
               Main.LocalPlayer.cordage = playerFile.Player.cordage;
               Main.LocalPlayer.counterWeight = playerFile.Player.counterWeight;
               Main.LocalPlayer.cPet = playerFile.Player.cPet;
               Main.LocalPlayer.cPortableStool = playerFile.Player.cPortableStool;
               Main.LocalPlayer.cratePotion = playerFile.Player.cratePotion;
               Main.LocalPlayer.creativeGodMode = playerFile.Player.creativeGodMode;
               Main.LocalPlayer.creativeInterface = playerFile.Player.creativeInterface;
               Main.LocalPlayer.creativeTracker = playerFile.Player.creativeTracker;
               Main.LocalPlayer.crimsonHeart = playerFile.Player.crimsonHeart;
               Main.LocalPlayer.crimsonRegen = playerFile.Player.crimsonRegen;
               Main.LocalPlayer.crystalLeaf = playerFile.Player.crystalLeaf;
               Main.LocalPlayer.crystalLeafCooldown = playerFile.Player.crystalLeafCooldown;
               Main.LocalPlayer.cSapling = playerFile.Player.cSapling;
               Main.LocalPlayer.cShield = playerFile.Player.cShield;
               Main.LocalPlayer.cShieldFallback = playerFile.Player.cShieldFallback;
               Main.LocalPlayer.cShoe = playerFile.Player.cShoe;
               Main.LocalPlayer.cTail = playerFile.Player.cTail;
               Main.LocalPlayer.cUnicornHorn = playerFile.Player.cUnicornHorn;
               Main.LocalPlayer.CurrentLoadoutIndex = playerFile.Player.CurrentLoadoutIndex;
               Main.LocalPlayer.currentShoppingSettings = playerFile.Player.currentShoppingSettings;
               Main.LocalPlayer.cursed = playerFile.Player.cursed;
               Main.LocalPlayer.cursorItemIconEnabled = playerFile.Player.cursorItemIconEnabled;
               Main.LocalPlayer.cursorItemIconID = playerFile.Player.cursorItemIconID;
               Main.LocalPlayer.cursorItemIconPush = playerFile.Player.cursorItemIconPush;
               Main.LocalPlayer.cursorItemIconReversed = playerFile.Player.cursorItemIconReversed;
               Main.LocalPlayer.cursorItemIconText = playerFile.Player.cursorItemIconText;
               Main.LocalPlayer.cWaist = playerFile.Player.cWaist;
               Main.LocalPlayer.cWings = playerFile.Player.cWings;
               Main.LocalPlayer.cYorai = playerFile.Player.cYorai;
               Main.LocalPlayer.dangerSense = playerFile.Player.dangerSense;
               Main.LocalPlayer.dash = playerFile.Player.dash;
               Main.LocalPlayer.dashDelay = playerFile.Player.dashDelay;
               Main.LocalPlayer.dashTime = playerFile.Player.dashTime;
               Main.LocalPlayer.dashType = playerFile.Player.dashType;
               Main.LocalPlayer.dazed = playerFile.Player.dazed;
               Main.LocalPlayer.dd2Accessory = playerFile.Player.dd2Accessory;
                
                //DEATH CODE BELOW
                //Main.LocalPlayer.dead = playerFile.Player.dead; NOT THIS
                
                Main.LocalPlayer.DeadlySphereMinion = playerFile.Player.DeadlySphereMinion;
                Main.LocalPlayer.defendedByPaladin = playerFile.Player.defendedByPaladin;
                Main.LocalPlayer.DefenseEffectiveness = playerFile.Player.DefenseEffectiveness;
                Main.LocalPlayer.delayUseItem = playerFile.Player.delayUseItem;
                Main.LocalPlayer.desertBoots = playerFile.Player.desertBoots;
                Main.LocalPlayer.desertDash = playerFile.Player.desertDash;
                Main.LocalPlayer.detectCreature = playerFile.Player.detectCreature;
                Main.LocalPlayer.difficulty = playerFile.Player.difficulty;
                Main.LocalPlayer.dino = playerFile.Player.dino;
                Main.LocalPlayer.direction = playerFile.Player.direction;
                Main.LocalPlayer.disableVoidBag = playerFile.Player.disableVoidBag;
                Main.LocalPlayer.discountAvailable = playerFile.Player.discountAvailable;
                Main.LocalPlayer.discountEquipped = playerFile.Player.discountEquipped;
                Main.LocalPlayer.displayedFishingInfo = playerFile.Player.displayedFishingInfo;
                Main.LocalPlayer.dontHurtCritters = playerFile.Player.dontHurtCritters;
                Main.LocalPlayer.dontHurtNature = playerFile.Player.dontHurtNature;
                Main.LocalPlayer.dontStarveShader = playerFile.Player.dontStarveShader;
                Main.LocalPlayer.doorHelper = playerFile.Player.doorHelper;
                Main.LocalPlayer.doubleTapCardinalTimer = playerFile.Player.doubleTapCardinalTimer;
                Main.LocalPlayer.downedDD2EventAnyDifficulty = playerFile.Player.downedDD2EventAnyDifficulty;
                Main.LocalPlayer.DpadRadial = playerFile.Player.DpadRadial;
                Main.LocalPlayer.dpsDamage = playerFile.Player.dpsDamage;
                Main.LocalPlayer.dpsEnd = playerFile.Player.dpsEnd;
                Main.LocalPlayer.dpsLastHit = playerFile.Player.dpsLastHit;
                Main.LocalPlayer.dpsStart = playerFile.Player.dpsStart;
                Main.LocalPlayer.dpsStarted = playerFile.Player.dpsStarted;
                Main.LocalPlayer.drainBoost = playerFile.Player.drainBoost;
                Main.LocalPlayer.drawingFootball = playerFile.Player.drawingFootball;
                Main.LocalPlayer.dripping = playerFile.Player.dripping;
                Main.LocalPlayer.drippingSlime = playerFile.Player.drippingSlime;
                Main.LocalPlayer.drippingSparkleSlime = playerFile.Player.drippingSparkleSlime;
                Main.LocalPlayer.dryadWard = playerFile.Player.dryadWard;
                Main.LocalPlayer.dye = playerFile.Player.dye;
                Main.LocalPlayer.eater = playerFile.Player.eater;
                Main.LocalPlayer.editedChestName = playerFile.Player.editedChestName;
                Main.LocalPlayer.electrified = playerFile.Player.electrified;
                Main.LocalPlayer.emoteTime = playerFile.Player.emoteTime;
                Main.LocalPlayer.empressBlade = playerFile.Player.empressBlade;
                Main.LocalPlayer.empressBrooch = playerFile.Player.empressBrooch;
                Main.LocalPlayer.enabledSuperCart = playerFile.Player.enabledSuperCart;
                Main.LocalPlayer.endurance = playerFile.Player.endurance;
                Main.LocalPlayer.enemySpawns = playerFile.Player.enemySpawns;
                Main.LocalPlayer.environmentBuffImmunityTimer = playerFile.Player.environmentBuffImmunityTimer;
                Main.LocalPlayer.eocDash = playerFile.Player.eocDash;
                Main.LocalPlayer.eocHit = playerFile.Player.eocHit;
                
                
                Main.LocalPlayer.equipmentBasedLuckBonus = playerFile.Player.equipmentBasedLuckBonus;
                Main.LocalPlayer.equippedAnyTileRangeAcc = playerFile.Player.equippedAnyTileRangeAcc;
                Main.LocalPlayer.equippedAnyTileSpeedAcc = playerFile.Player.equippedAnyTileSpeedAcc;
                Main.LocalPlayer.equippedAnyWallSpeedAcc = playerFile.Player.equippedAnyWallSpeedAcc;
                Main.LocalPlayer.equippedWings = playerFile.Player.equippedWings;
                Main.LocalPlayer.extraAccessory = playerFile.Player.extraAccessory;
                Main.LocalPlayer.extraAccessorySlots = playerFile.Player.extraAccessorySlots;
                Main.LocalPlayer.extraFall = playerFile.Player.extraFall;
                Main.LocalPlayer.eyebrellaCloud = playerFile.Player.eyebrellaCloud;
                Main.LocalPlayer.eyeColor = playerFile.Player.eyeColor;
                Main.LocalPlayer.eyeHelper = playerFile.Player.eyeHelper;
                Main.LocalPlayer.eyeSpring = playerFile.Player.eyeSpring;
                Main.LocalPlayer.face = playerFile.Player.face;
                Main.LocalPlayer.faceFlower = playerFile.Player.faceFlower;
                Main.LocalPlayer.faceHead = playerFile.Player.faceHead;
                Main.LocalPlayer.fairyBoots = playerFile.Player.fairyBoots;
                
                
                Main.LocalPlayer.fartKartCloudDelay = playerFile.Player.fartKartCloudDelay;
                Main.LocalPlayer.findTreasure = playerFile.Player.findTreasure;
                Main.LocalPlayer.fireWalk = playerFile.Player.fireWalk;
                Main.LocalPlayer.firstFractalAfterImageOpacity = playerFile.Player.firstFractalAfterImageOpacity;
                Main.LocalPlayer.fishingSkill = playerFile.Player.fishingSkill;
                Main.LocalPlayer.flameRingAlpha = playerFile.Player.flameRingAlpha;
                Main.LocalPlayer.flameRingFrame = playerFile.Player.flameRingFrame;
                Main.LocalPlayer.flameRingRot = playerFile.Player.flameRingRot;
                Main.LocalPlayer.flameRingScale = playerFile.Player.flameRingScale;
                Main.LocalPlayer.flapSound = playerFile.Player.flapSound;
                Main.LocalPlayer.flinxMinion = playerFile.Player.flinxMinion;
                Main.LocalPlayer.flowerBoots = playerFile.Player.flowerBoots;
                
                Main.LocalPlayer.forcedGravity = playerFile.Player.forcedGravity;
                Main.LocalPlayer.forceMerman = playerFile.Player.forceMerman;
                Main.LocalPlayer.forceWerewolf = playerFile.Player.forceWerewolf;
                Main.LocalPlayer.frogLegJumpBoost = playerFile.Player.frogLegJumpBoost;
                
                
                // * GRAVITY DEATH HERE
                Main.LocalPlayer.front = playerFile.Player.front;
                Main.LocalPlayer.frostArmor = playerFile.Player.frostArmor;
                Main.LocalPlayer.frostBurn = playerFile.Player.frostBurn;
                Main.LocalPlayer.frozen = playerFile.Player.frozen;
                Main.LocalPlayer.fullRotation = playerFile.Player.fullRotation;
                Main.LocalPlayer.fullRotationOrigin = playerFile.Player.fullRotationOrigin;
                Main.LocalPlayer.gem = playerFile.Player.gem;
                Main.LocalPlayer.gemCount = playerFile.Player.gemCount;
                
                Main.LocalPlayer.gfxOffY = playerFile.Player.gfxOffY; //
                Main.LocalPlayer.ghost = playerFile.Player.ghost;
                Main.LocalPlayer.ghostDir = playerFile.Player.ghostDir;
                Main.LocalPlayer.ghostDmg = playerFile.Player.ghostDmg;
                Main.LocalPlayer.ghostFade = playerFile.Player.ghostFade;
                Main.LocalPlayer.ghostFrame = playerFile.Player.ghostFrame;
                Main.LocalPlayer.ghostFrameCounter = playerFile.Player.ghostFrameCounter;
                Main.LocalPlayer.ghostHeal = playerFile.Player.ghostHeal;
                Main.LocalPlayer.ghostHurt = playerFile.Player.ghostHurt;
                 //GRAVITY DEATH HERE ABOVE
                Main.LocalPlayer.gills = playerFile.Player.gills;
                Main.LocalPlayer.GoingDownWithGrapple = playerFile.Player.GoingDownWithGrapple;
                Main.LocalPlayer.goldRing = playerFile.Player.goldRing;
                Main.LocalPlayer.golferScoreAccumulated = playerFile.Player.golferScoreAccumulated;
                Main.LocalPlayer.grapCount = playerFile.Player.grapCount;
                Main.LocalPlayer.grappling = playerFile.Player.grappling;
                Main.LocalPlayer.gravControl = playerFile.Player.gravControl;
                Main.LocalPlayer.gravControl2 = playerFile.Player.gravControl2;
                Main.LocalPlayer.gravDir = playerFile.Player.gravDir;
                Main.LocalPlayer.gravity = playerFile.Player.gravity; //NOT THIS
               
                Main.LocalPlayer.greenFairy = playerFile.Player.greenFairy;
                Main.LocalPlayer.grinch = playerFile.Player.grinch;
                Main.LocalPlayer.gross = playerFile.Player.gross;
                Main.LocalPlayer.hair = playerFile.Player.hair;
                Main.LocalPlayer.hairColor = playerFile.Player.hairColor;
                Main.LocalPlayer.hairDye = playerFile.Player.hairDye;
                Main.LocalPlayer.hairDyeColor = playerFile.Player.hairDyeColor;
                Main.LocalPlayer.hairDyeVar = playerFile.Player.hairDyeVar;
                Main.LocalPlayer.hairFrame = playerFile.Player.hairFrame;
                Main.LocalPlayer.handoff = playerFile.Player.handoff;
                Main.LocalPlayer.handon = playerFile.Player.handon;
                Main.LocalPlayer.happyFunTorchTime = playerFile.Player.happyFunTorchTime;
                Main.LocalPlayer.hasAngelHalo = playerFile.Player.hasAngelHalo;
                Main.LocalPlayer.hasCreditsSceneMusicBox = playerFile.Player.hasCreditsSceneMusicBox;
                Main.LocalPlayer.hasFloatingTube = playerFile.Player.hasFloatingTube;
                Main.LocalPlayer.hasFootball = playerFile.Player.hasFootball;
                Main.LocalPlayer.HasGardenGnomeNearby = playerFile.Player.HasGardenGnomeNearby;
                Main.LocalPlayer.hasLuckyCoin = playerFile.Player.hasLuckyCoin;
                Main.LocalPlayer.hasLuck_LuckyCoin = playerFile.Player.hasLuck_LuckyCoin;
               
                // CHECK ABOVE DEATH CODE

                //ORBIT IS BELOW             
                Main.LocalPlayer.hasLuck_LuckyHorseshoe = playerFile.Player.hasLuck_LuckyHorseshoe;
                Main.LocalPlayer.hasLucyTheAxe = playerFile.Player.hasLucyTheAxe;
                Main.LocalPlayer.hasMagiluminescence = playerFile.Player.hasMagiluminescence;
                Main.LocalPlayer.hasMoltenQuiver = playerFile.Player.hasMoltenQuiver;
                Main.LocalPlayer.hasPaladinShield = playerFile.Player.hasPaladinShield;
                Main.LocalPlayer.hasRainbowCursor = playerFile.Player.hasRainbowCursor;
                Main.LocalPlayer.hasRaisableShield = playerFile.Player.hasRaisableShield;
                Main.LocalPlayer.hasTitaniumStormBuff = playerFile.Player.hasTitaniumStormBuff;
                Main.LocalPlayer.hasUnicornHorn = playerFile.Player.hasUnicornHorn;
                Main.LocalPlayer.hbLocked = playerFile.Player.hbLocked;
                Main.LocalPlayer.head = playerFile.Player.head;
                Main.LocalPlayer.headcovered = playerFile.Player.headcovered;
                Main.LocalPlayer.headFrame = playerFile.Player.headFrame;
                Main.LocalPlayer.headFrameCounter = playerFile.Player.headFrameCounter;
                Main.LocalPlayer.headPosition = playerFile.Player.headPosition;
                Main.LocalPlayer.headRotation = playerFile.Player.headRotation;
                Main.LocalPlayer.headVelocity = playerFile.Player.headVelocity;
                Main.LocalPlayer.heartyMeal = playerFile.Player.heartyMeal;
                Main.LocalPlayer.height = playerFile.Player.height;
                Main.LocalPlayer.heldProj = playerFile.Player.heldProj;
                Main.LocalPlayer.hellfireTreads = playerFile.Player.hellfireTreads;
                Main.LocalPlayer.hermesStepSound = playerFile.Player.hermesStepSound;
                Main.LocalPlayer.hideInfo = playerFile.Player.hideInfo;
                Main.LocalPlayer.hideMerman = playerFile.Player.hideMerman;
                Main.LocalPlayer.hideMisc = playerFile.Player.hideMisc;
                Main.LocalPlayer.hideVisibleAccessory = playerFile.Player.hideVisibleAccessory;
                Main.LocalPlayer.hideWolf = playerFile.Player.hideWolf;
                Main.LocalPlayer.highestAbigailCounterOriginalDamage = playerFile.Player.highestAbigailCounterOriginalDamage;
                Main.LocalPlayer.highestStormTigerGemOriginalDamage = playerFile.Player.highestStormTigerGemOriginalDamage;
                Main.LocalPlayer.hitReplace = playerFile.Player.hitReplace;
                Main.LocalPlayer.hitTile = playerFile.Player.hitTile;
                Main.LocalPlayer.holdDownCardinalTimer = playerFile.Player.holdDownCardinalTimer;
                Main.LocalPlayer.honey = playerFile.Player.honey;
                Main.LocalPlayer.honeyCombItem = playerFile.Player.honeyCombItem;
                Main.LocalPlayer.honeyWet = playerFile.Player.honeyWet;
                Main.LocalPlayer.hornet = playerFile.Player.hornet;
                Main.LocalPlayer.hornetMinion = playerFile.Player.hornetMinion;
                Main.LocalPlayer.hostile = playerFile.Player.hostile;
                Main.LocalPlayer.HotbarOffset = playerFile.Player.HotbarOffset;
                Main.LocalPlayer.hungry = playerFile.Player.hungry;
                Main.LocalPlayer.huntressAmmoCost90 = playerFile.Player.huntressAmmoCost90;
                Main.LocalPlayer.hurtCooldowns = playerFile.Player.hurtCooldowns;
                Main.LocalPlayer.iceBarrier = playerFile.Player.iceBarrier;
                Main.LocalPlayer.iceBarrierFrame = playerFile.Player.iceBarrierFrame;
                Main.LocalPlayer.iceBarrierFrameCounter = playerFile.Player.iceBarrierFrameCounter;
                Main.LocalPlayer.iceSkate = playerFile.Player.iceSkate;
                Main.LocalPlayer.ichor = playerFile.Player.ichor;
                Main.LocalPlayer.ignoreWater = playerFile.Player.ignoreWater;
                Main.LocalPlayer.immune = playerFile.Player.immune;
                Main.LocalPlayer.immuneAlpha = playerFile.Player.immuneAlpha;
                Main.LocalPlayer.immuneAlphaDirection = playerFile.Player.immuneAlphaDirection;
                Main.LocalPlayer.immuneNoBlink = playerFile.Player.immuneNoBlink;
                Main.LocalPlayer.immuneTime = playerFile.Player.immuneTime;
                Main.LocalPlayer.impMinion = playerFile.Player.impMinion;
                Main.LocalPlayer.inferno = playerFile.Player.inferno;
                Main.LocalPlayer.infernoCounter = playerFile.Player.infernoCounter;
                Main.LocalPlayer.InfoAccMechShowWires = playerFile.Player.InfoAccMechShowWires;
                Main.LocalPlayer.insanityShadowCooldown = playerFile.Player.insanityShadowCooldown;
                Main.LocalPlayer.instantMovementAccumulatedThisFrame = playerFile.Player.instantMovementAccumulatedThisFrame;
                Main.LocalPlayer.inventory = playerFile.Player.inventory;
                Main.LocalPlayer.inventoryChestStack = playerFile.Player.inventoryChestStack;
                Main.LocalPlayer.invis = playerFile.Player.invis;
                Main.LocalPlayer.isControlledByFilm = playerFile.Player.isControlledByFilm;
                Main.LocalPlayer.isDisplayDollOrInanimate = playerFile.Player.isDisplayDollOrInanimate;
                Main.LocalPlayer.isFirstFractalAfterImage = playerFile.Player.isFirstFractalAfterImage;
                Main.LocalPlayer.isFullbright = playerFile.Player.isFullbright;
                Main.LocalPlayer.isHatRackDoll = playerFile.Player.isHatRackDoll;
                Main.LocalPlayer.isOperatingAnotherEntity = playerFile.Player.isOperatingAnotherEntity;
                Main.LocalPlayer.isPerformingPogostickTricks = playerFile.Player.isPerformingPogostickTricks;
                Main.LocalPlayer.isPettingAnimal = playerFile.Player.isPettingAnimal;
                Main.LocalPlayer.isTheAnimalBeingPetSmall = playerFile.Player.isTheAnimalBeingPetSmall;
                Main.LocalPlayer.itemAnimation = playerFile.Player.itemAnimation;
                Main.LocalPlayer.itemAnimationMax = playerFile.Player.itemAnimationMax;
                Main.LocalPlayer.itemFlameCount = playerFile.Player.itemFlameCount;
                Main.LocalPlayer.itemFlamePos = playerFile.Player.itemFlamePos;
                Main.LocalPlayer.itemHeight = playerFile.Player.itemHeight;
                Main.LocalPlayer.itemLocation = playerFile.Player.itemLocation;
                Main.LocalPlayer.itemRotation = playerFile.Player.itemRotation;
                Main.LocalPlayer.itemTime = playerFile.Player.itemTime;
                Main.LocalPlayer.itemTimeMax = playerFile.Player.itemTimeMax;
                Main.LocalPlayer.itemWidth = playerFile.Player.itemWidth;
                Main.LocalPlayer.jump = playerFile.Player.jump;
                Main.LocalPlayer.jumpBoost = playerFile.Player.jumpBoost;
                Main.LocalPlayer.jumpSpeedBoost = playerFile.Player.jumpSpeedBoost;
                Main.LocalPlayer.JustDroppedAnItem = playerFile.Player.JustDroppedAnItem;
                Main.LocalPlayer.justJumped = playerFile.Player.justJumped;
                Main.LocalPlayer.kbBuff = playerFile.Player.kbBuff;
                Main.LocalPlayer.kbGlove = playerFile.Player.kbGlove;
                Main.LocalPlayer.killClothier = playerFile.Player.killClothier;
                Main.LocalPlayer.killGuide = playerFile.Player.killGuide;
                Main.LocalPlayer.ladyBugLuckTimeLeft = playerFile.Player.ladyBugLuckTimeLeft;
                Main.LocalPlayer.lastBoost = playerFile.Player.lastBoost;
                Main.LocalPlayer.lastChest = playerFile.Player.lastChest;
                Main.LocalPlayer.lastCreatureHit = playerFile.Player.lastCreatureHit;
                Main.LocalPlayer.lastDeathPostion = playerFile.Player.lastDeathPostion;
                Main.LocalPlayer.lastDeathTime = playerFile.Player.lastDeathTime;
                Main.LocalPlayer.lastEquipmentBasedLuckBonus = playerFile.Player.lastEquipmentBasedLuckBonus;
                Main.LocalPlayer.lastMouseInterface = playerFile.Player.lastMouseInterface;
                Main.LocalPlayer.lastPortalColorIndex = playerFile.Player.lastPortalColorIndex;
                Main.LocalPlayer.lastStoned = playerFile.Player.lastStoned;
                Main.LocalPlayer.lastTeleportPylonStyleUsed = playerFile.Player.lastTeleportPylonStyleUsed;
                Main.LocalPlayer.lastTileRangeX = playerFile.Player.lastTileRangeX;
                Main.LocalPlayer.lastTileRangeY = playerFile.Player.lastTileRangeY;
                Main.LocalPlayer.lastTimePlayerWasSaved = playerFile.Player.lastTimePlayerWasSaved;
                Main.LocalPlayer.lastVisualizedSelectedItem = playerFile.Player.lastVisualizedSelectedItem;
                Main.LocalPlayer.lavaCD = playerFile.Player.lavaCD;
                Main.LocalPlayer.lavaImmune = playerFile.Player.lavaImmune;
                Main.LocalPlayer.lavaMax = playerFile.Player.lavaMax;
                Main.LocalPlayer.lavaRose = playerFile.Player.lavaRose;
                Main.LocalPlayer.lavaTime = playerFile.Player.lavaTime;
                Main.LocalPlayer.lavaWet = playerFile.Player.lavaWet;
                Main.LocalPlayer.leftTimer = playerFile.Player.leftTimer;
                Main.LocalPlayer.legFrame = playerFile.Player.legFrame;
                Main.LocalPlayer.legFrameCounter = playerFile.Player.legFrameCounter;
                Main.LocalPlayer.legPosition = playerFile.Player.legPosition;
                Main.LocalPlayer.legRotation = playerFile.Player.legRotation;
                Main.LocalPlayer.legs = playerFile.Player.legs;
                Main.LocalPlayer.legVelocity = playerFile.Player.legVelocity;
                Main.LocalPlayer.leinforsHair = playerFile.Player.leinforsHair;
                Main.LocalPlayer.lifeForce = playerFile.Player.lifeForce;
                Main.LocalPlayer.lifeMagnet = playerFile.Player.lifeMagnet;
                Main.LocalPlayer.lifeRegen = playerFile.Player.lifeRegen;
                Main.LocalPlayer.lifeRegenCount = playerFile.Player.lifeRegenCount;
                Main.LocalPlayer.lifeRegenTime = playerFile.Player.lifeRegenTime;
                Main.LocalPlayer.lifeSteal = playerFile.Player.lifeSteal;
                Main.LocalPlayer.lightOrb = playerFile.Player.lightOrb;
                Main.LocalPlayer.lizard = playerFile.Player.lizard;
                Main.LocalPlayer.Loadouts = playerFile.Player.Loadouts;
                Main.LocalPlayer.loadStatus = playerFile.Player.loadStatus;
                Main.LocalPlayer.LocalInputCache = playerFile.Player.LocalInputCache;
                Main.LocalPlayer.longInvince = playerFile.Player.longInvince;
                Main.LocalPlayer.lostCoins = playerFile.Player.lostCoins;
                Main.LocalPlayer.lostCoinString = playerFile.Player.lostCoinString;
                Main.LocalPlayer.loveStruck = playerFile.Player.loveStruck;
                Main.LocalPlayer.luck = playerFile.Player.luck;
                Main.LocalPlayer.luckMaximumCap = playerFile.Player.luckMaximumCap;
                Main.LocalPlayer.luckMinimumCap = playerFile.Player.luckMinimumCap;
                Main.LocalPlayer.luckNeedsSync = playerFile.Player.luckNeedsSync;
                Main.LocalPlayer.luckPotion = playerFile.Player.luckPotion;
                Main.LocalPlayer.magicCuffs = playerFile.Player.magicCuffs;
                Main.LocalPlayer.magicLantern = playerFile.Player.magicLantern;
                Main.LocalPlayer.magicQuiver = playerFile.Player.magicQuiver;
                Main.LocalPlayer.magmaStone = playerFile.Player.magmaStone;
                Main.LocalPlayer.manaCost = playerFile.Player.manaCost;
                Main.LocalPlayer.manaFlower = playerFile.Player.manaFlower;
                Main.LocalPlayer.manaMagnet = playerFile.Player.manaMagnet;
                Main.LocalPlayer.manaRegen = playerFile.Player.manaRegen;
                Main.LocalPlayer.manaRegenBonus = playerFile.Player.manaRegenBonus;
                Main.LocalPlayer.manaRegenBuff = playerFile.Player.manaRegenBuff;
                Main.LocalPlayer.manaRegenCount = playerFile.Player.manaRegenCount;
                Main.LocalPlayer.manaRegenDelay = playerFile.Player.manaRegenDelay;
                Main.LocalPlayer.manaRegenDelayBonus = playerFile.Player.manaRegenDelayBonus;
                Main.LocalPlayer.manaSick = playerFile.Player.manaSick;
                Main.LocalPlayer.manaSickReduction = playerFile.Player.manaSickReduction;
                
                Main.LocalPlayer.mapAlphaDown = playerFile.Player.mapAlphaDown;
                Main.LocalPlayer.mapAlphaUp = playerFile.Player.mapAlphaUp;
                Main.LocalPlayer.mapFullScreen = playerFile.Player.mapFullScreen;
                Main.LocalPlayer.mapStyle = playerFile.Player.mapStyle;
                Main.LocalPlayer.mapZoomIn = playerFile.Player.mapZoomIn;
                Main.LocalPlayer.mapZoomOut = playerFile.Player.mapZoomOut;
                Main.LocalPlayer.maxFallSpeed = playerFile.Player.maxFallSpeed;
                Main.LocalPlayer.maxMinions = playerFile.Player.maxMinions;
                Main.LocalPlayer.maxRegenDelay = playerFile.Player.maxRegenDelay;
                Main.LocalPlayer.maxRunSpeed = playerFile.Player.maxRunSpeed;
                Main.LocalPlayer.maxTurrets = playerFile.Player.maxTurrets;
                Main.LocalPlayer.maxTurretsOld = playerFile.Player.maxTurretsOld;
                Main.LocalPlayer.meleeEnchant = playerFile.Player.meleeEnchant;
                Main.LocalPlayer.meleeNPCHitCooldown = playerFile.Player.meleeNPCHitCooldown;
                Main.LocalPlayer.meleeScaleGlove = playerFile.Player.meleeScaleGlove;
                Main.LocalPlayer.merman = playerFile.Player.merman;
                Main.LocalPlayer.minecartLeft = playerFile.Player.minecartLeft;
                Main.LocalPlayer.miniMinotaur = playerFile.Player.miniMinotaur;
                Main.LocalPlayer.MinionAttackTargetNPC = playerFile.Player.MinionAttackTargetNPC;
                Main.LocalPlayer.MinionRestTargetPoint = playerFile.Player.MinionRestTargetPoint;
                Main.LocalPlayer.miscCounter = playerFile.Player.miscCounter;
                Main.LocalPlayer.miscDyes = playerFile.Player.miscDyes;
                Main.LocalPlayer.miscEquips = playerFile.Player.miscEquips;
                Main.LocalPlayer.miscTimer = playerFile.Player.miscTimer;
                Main.LocalPlayer.moonLeech = playerFile.Player.moonLeech;
                Main.LocalPlayer.moonLordLegs = playerFile.Player.moonLordLegs;
                Main.LocalPlayer.moonLordMonolithShader = playerFile.Player.moonLordMonolithShader;
                Main.LocalPlayer.mount = playerFile.Player.mount;
                Main.LocalPlayer.MountFishronSpecialCounter = playerFile.Player.MountFishronSpecialCounter;
                Main.LocalPlayer.mouseInterface = playerFile.Player.mouseInterface;
                Main.LocalPlayer.movementAbilitiesCache = playerFile.Player.movementAbilitiesCache;
                Main.LocalPlayer.moveSpeed = playerFile.Player.moveSpeed;
                Main.LocalPlayer.mushroomDelayTime = playerFile.Player.mushroomDelayTime;
                Main.LocalPlayer.musicDist = playerFile.Player.musicDist;
                Main.LocalPlayer.name = playerFile.Player.name;
                Main.LocalPlayer.nearbyActiveNPCs = playerFile.Player.nearbyActiveNPCs;
                Main.LocalPlayer.nebulaCD = playerFile.Player.nebulaCD;
                Main.LocalPlayer.nebulaLevelDamage = playerFile.Player.nebulaLevelDamage;
                Main.LocalPlayer.nebulaLevelLife = playerFile.Player.nebulaLevelLife;
                Main.LocalPlayer.nebulaLevelMana = playerFile.Player.nebulaLevelMana;
                Main.LocalPlayer.nebulaManaCounter = playerFile.Player.nebulaManaCounter;
                Main.LocalPlayer.nebulaMonolithShader = playerFile.Player.nebulaMonolithShader;
                //ORBIT CODE IS BELOW BELOW BELOW
                //*
                 Main.LocalPlayer.neck = playerFile.Player.neck;
                 Main.LocalPlayer.netLife = playerFile.Player.netLife;
                 Main.LocalPlayer.netLifeTime = playerFile.Player.netLifeTime;
                 Main.LocalPlayer.netMana = playerFile.Player.netMana;
                 Main.LocalPlayer.netManaTime = playerFile.Player.netManaTime;
                 Main.LocalPlayer.netSkip = playerFile.Player.netSkip;
                 Main.LocalPlayer.nextCycledSpiderMinionType = playerFile.Player.nextCycledSpiderMinionType;
                 Main.LocalPlayer.nightVision = playerFile.Player.nightVision;
                 Main.LocalPlayer.noBuilding = playerFile.Player.noBuilding;
                 Main.LocalPlayer.noFallDmg = playerFile.Player.noFallDmg;
                 Main.LocalPlayer.noItems = playerFile.Player.noItems;
                 Main.LocalPlayer.noKnockback = playerFile.Player.noKnockback;
                 Main.LocalPlayer.nonTorch = playerFile.Player.nonTorch;
                 Main.LocalPlayer.noThrow = playerFile.Player.nonTorch;
                 Main.LocalPlayer.npcTypeNoAggro = playerFile.Player.npcTypeNoAggro;
                 Main.LocalPlayer.numberOfDeathsPVE = playerFile.Player.numberOfDeathsPVE;
                 Main.LocalPlayer.numberOfDeathsPVP = playerFile.Player.numberOfDeathsPVP;
                 Main.LocalPlayer.numMinions = playerFile.Player.numMinions;
                 Main.LocalPlayer.oldAdjHoney = playerFile.Player.oldAdjHoney;
                 Main.LocalPlayer.oldAdjLava = playerFile.Player.oldAdjLava;
                 Main.LocalPlayer.oldAdjShimmer = playerFile.Player.oldAdjShimmer;
                 Main.LocalPlayer.oldAdjWater = playerFile.Player.oldAdjWater;
                 Main.LocalPlayer.oldDirection = playerFile.Player.oldDirection;
                 Main.LocalPlayer.oldLuckPotion = playerFile.Player.oldLuckPotion;
                 Main.LocalPlayer.oldPosition = playerFile.Player.oldPosition;
                 Main.LocalPlayer.oldSelectItem = playerFile.Player.oldSelectItem;
                 Main.LocalPlayer.oldVelocity = playerFile.Player.oldVelocity;
                 Main.LocalPlayer.onFire = playerFile.Player.onFire;
                 Main.LocalPlayer.onFire2 = playerFile.Player.onFire2;
                 Main.LocalPlayer.onFire3 = playerFile.Player.onFire3;
                 Main.LocalPlayer.onFrostBurn = playerFile.Player.onFrostBurn;
                 Main.LocalPlayer.onFrostBurn2 = playerFile.Player.onFrostBurn2;
                 Main.LocalPlayer.onHitDodge = playerFile.Player.onHitDodge;
                 Main.LocalPlayer.onHitPetal = playerFile.Player.onHitPetal;
                 Main.LocalPlayer.onHitRegen = playerFile.Player.onHitRegen;
                 Main.LocalPlayer.onHitTitaniumStorm = playerFile.Player.onHitTitaniumStorm;
                 Main.LocalPlayer.onTrack = playerFile.Player.onTrack;
                 Main.LocalPlayer.onWrongGround = playerFile.Player.onWrongGround;
                 Main.LocalPlayer.opacityForAnimation = playerFile.Player.opacityForAnimation;
                 Main.LocalPlayer.outOfRange = playerFile.Player.outOfRange;
                 Main.LocalPlayer.overrideFishingBobber = playerFile.Player.overrideFishingBobber;
                 Main.LocalPlayer.ownedLargeGems = playerFile.Player.ownedLargeGems;
                 Main.LocalPlayer.ownedProjectileCounts = playerFile.Player.ownedProjectileCounts;
                 Main.LocalPlayer.palladiumRegen = playerFile.Player.palladiumRegen;
                 Main.LocalPlayer.panic = playerFile.Player.panic;
                 Main.LocalPlayer.pantsColor = playerFile.Player.pantsColor;
                 Main.LocalPlayer.parrot = playerFile.Player.parrot;
                 Main.LocalPlayer.parryDamageBuff = playerFile.Player.parryDamageBuff;
                 Main.LocalPlayer.penguin = playerFile.Player.penguin;
                 Main.LocalPlayer.petalTimer = playerFile.Player.petalTimer;
                 Main.LocalPlayer.petFlagBabyImp = playerFile.Player.petFlagBabyImp;
                 Main.LocalPlayer.petFlagBabyRedPanda = playerFile.Player.petFlagBabyRedPanda;
                 Main.LocalPlayer.petFlagBabyShark = playerFile.Player.petFlagBabyShark;
                 Main.LocalPlayer.petFlagBabyWerewolf = playerFile.Player.petFlagBabyWerewolf;
                 Main.LocalPlayer.petFlagBerniePet = playerFile.Player.petFlagBerniePet;
                 Main.LocalPlayer.petFlagBlueChickenPet = playerFile.Player.petFlagBlueChickenPet;
                 Main.LocalPlayer.petFlagBrainOfCthulhuPet = playerFile.Player.petFlagBrainOfCthulhuPet;
                 Main.LocalPlayer.petFlagCaveling = playerFile.Player.petFlagCaveling;
                 Main.LocalPlayer.petFlagChesterPet = playerFile.Player.petFlagChesterPet;
                 Main.LocalPlayer.petFlagDD2BetsyPet = playerFile.Player.petFlagDD2BetsyPet;
                 Main.LocalPlayer.petFlagDD2Dragon = playerFile.Player.petFlagDD2Dragon;
                 Main.LocalPlayer.petFlagDD2Gato = playerFile.Player.petFlagDD2Gato;
                 Main.LocalPlayer.petFlagDD2Ghost = playerFile.Player.ghost;
                 Main.LocalPlayer.petFlagDD2OgrePet = playerFile.Player.petFlagDD2OgrePet;
                 Main.LocalPlayer.petFlagDeerclopsPet = playerFile.Player.petFlagDeerclopsPet;
                 Main.LocalPlayer.petFlagDestroyerPet = playerFile.Player.petFlagDestroyerPet;
                 Main.LocalPlayer.petFlagDirtiestBlock = playerFile.Player.petFlagDirtiestBlock;
                 Main.LocalPlayer.petFlagDukeFishronPet = playerFile.Player.petFlagDukeFishronPet;
                 Main.LocalPlayer.petFlagDynamiteKitten = playerFile.Player.petFlagDynamiteKitten;
                 Main.LocalPlayer.petFlagEaterOfWorldsPet = playerFile.Player.petFlagEaterOfWorldsPet;
                 Main.LocalPlayer.petFlagEverscreamPet = playerFile.Player.petFlagEverscreamPet;
                 Main.LocalPlayer.petFlagEyeOfCthulhuPet = playerFile.Player.petFlagEyeOfCthulhuPet;
                 Main.LocalPlayer.petFlagFairyQueenPet = playerFile.Player.petFlagFairyQueenPet;
                 Main.LocalPlayer.petFlagFennecFox = playerFile.Player.petFlagFennecFox;
                 Main.LocalPlayer.petFlagGlitteryButterfly = playerFile.Player.petFlagGlitteryButterfly;
                 Main.LocalPlayer.petFlagGlommerPet = playerFile.Player.petFlagGlommerPet;
                 Main.LocalPlayer.petFlagGolemPet = playerFile.Player.petFlagGolemPet;
                 Main.LocalPlayer.petFlagIceQueenPet = playerFile.Player.petFlagIceQueenPet;
                 Main.LocalPlayer.petFlagJunimoPet = playerFile.Player.petFlagJunimoPet;
                 Main.LocalPlayer.petFlagKingSlimePet = playerFile.Player.petFlagKingSlimePet;
                 Main.LocalPlayer.petFlagLilHarpy = playerFile.Player.petFlagLilHarpy;
                 Main.LocalPlayer.petFlagLunaticCultistPet = playerFile.Player.petFlagLunaticCultistPet;
                 Main.LocalPlayer.petFlagMartianPet = playerFile.Player.petFlagMartianPet;
                 Main.LocalPlayer.petFlagMoonLordPet = playerFile.Player.petFlagMoonLordPet;
                 Main.LocalPlayer.petFlagPigPet = playerFile.Player.petFlagPigPet;
                 Main.LocalPlayer.petFlagPlanteraPet = playerFile.Player.petFlagPlanteraPet;
                 Main.LocalPlayer.petFlagPlantero = playerFile.Player.petFlagPlantero;
                 Main.LocalPlayer.petFlagPumpkingPet = playerFile.Player.petFlagPumpkingPet;
                 Main.LocalPlayer.petFlagQueenBeePet = playerFile.Player.petFlagQueenBeePet;
                 Main.LocalPlayer.petFlagQueenSlimePet = playerFile.Player.petFlagQueenSlimePet;
                 Main.LocalPlayer.petFlagShadowMimic = playerFile.Player.petFlagShadowMimic;
                 Main.LocalPlayer.petFlagSkeletronPet = playerFile.Player.petFlagSkeletronPet;
                 Main.LocalPlayer.petFlagSkeletronPrimePet = playerFile.Player.petFlagSkeletronPrimePet;
                 Main.LocalPlayer.petFlagSpiffo = playerFile.Player.petFlagSpiffo;
                 Main.LocalPlayer.petFlagSugarGlider = playerFile.Player.petFlagSugarGlider;
                 Main.LocalPlayer.petFlagTwinsPet = playerFile.Player.petFlagTwinsPet;
                 Main.LocalPlayer.petFlagUpbeatStar = playerFile.Player.petFlagUpbeatStar;
                 Main.LocalPlayer.petFlagVoltBunny = playerFile.Player.petFlagVoltBunny;
                 Main.LocalPlayer.phantasmTime = playerFile.Player.phantasmTime;
                 Main.LocalPlayer.phantomPhoneixCounter = playerFile.Player.phantomPhoneixCounter;
                 Main.LocalPlayer.pickSpeed = playerFile.Player.pickSpeed;
                 Main.LocalPlayer.piggyBankProjTracker = playerFile.Player.piggyBankProjTracker;
                 Main.LocalPlayer.pirateMinion = playerFile.Player.pirateMinion;
                 Main.LocalPlayer.poisoned = playerFile.Player.poisoned;
                 Main.LocalPlayer.portableStoolInfo = playerFile.Player.portableStoolInfo;
                 Main.LocalPlayer.portalPhysicsFlag = playerFile.Player.portalPhysicsFlag;
                //TROUBLE HERE
                
                
                //TROUBLE HERE
                 Main.LocalPlayer.potionDelay = playerFile.Player.potionDelay;
                 Main.LocalPlayer.potionDelayTime = playerFile.Player.potionDelayTime;
                 Main.LocalPlayer.PotionOfReturnHomePosition = playerFile.Player.PotionOfReturnHomePosition;
                 Main.LocalPlayer.PotionOfReturnOriginalUsePosition = playerFile.Player.PotionOfReturnOriginalUsePosition;
                 Main.LocalPlayer.poundRelease = playerFile.Player.poundRelease;
                 Main.LocalPlayer.powerrun = playerFile.Player.powerrun;
                 Main.LocalPlayer.preventAllItemPickups = playerFile.Player.preventAllItemPickups;
                 Main.LocalPlayer.pStone = playerFile.Player.pStone;
                 Main.LocalPlayer.pulley = playerFile.Player.pulley;
                 Main.LocalPlayer.pulleyDir = playerFile.Player.pulleyDir;
                 Main.LocalPlayer.pulleyFrame = playerFile.Player.pulleyFrame;
                 Main.LocalPlayer.pulleyFrameCounter = playerFile.Player.pulleyFrameCounter;
                 Main.LocalPlayer.puppy = playerFile.Player.puppy;
                 Main.LocalPlayer.pvpDeath = playerFile.Player.pvpDeath;
                 Main.LocalPlayer.pygmy = playerFile.Player.pygmy;
                 Main.LocalPlayer.QuicksRadial = playerFile.Player.QuicksRadial;
                 Main.LocalPlayer.rabbitOrderFrame = playerFile.Player.rabbitOrderFrame;
                 Main.LocalPlayer.rabid = playerFile.Player.rabid;
                 Main.LocalPlayer.raven = playerFile.Player.raven;
                 Main.LocalPlayer.redFairy = playerFile.Player.redFairy;
                 Main.LocalPlayer.releaseCreativeMenu = playerFile.Player.releaseCreativeMenu;
                 Main.LocalPlayer.releaseDown = playerFile.Player.releaseDown;
                 Main.LocalPlayer.releaseHook = playerFile.Player.releaseHook;
                 Main.LocalPlayer.releaseInventory = playerFile.Player.releaseInventory;
                 Main.LocalPlayer.releaseJump = playerFile.Player.releaseJump;
                 Main.LocalPlayer.releaseLeft = playerFile.Player.releaseLeft;
                 Main.LocalPlayer.releaseMapFullscreen = playerFile.Player.releaseMapFullscreen;
                 Main.LocalPlayer.releaseMapStyle = playerFile.Player.releaseMapStyle;
                 Main.LocalPlayer.releaseMount = playerFile.Player.releaseMount;
                 Main.LocalPlayer.releaseQuickHeal = playerFile.Player.releaseQuickHeal;
                 Main.LocalPlayer.releaseQuickMana = playerFile.Player.releaseQuickMana;
                 Main.LocalPlayer.releaseRight = playerFile.Player.releaseRight;
                 Main.LocalPlayer.releaseSmart = playerFile.Player.releaseSmart;
                 Main.LocalPlayer.releaseThrow = playerFile.Player.releaseThrow;
                 Main.LocalPlayer.releaseUp = playerFile.Player.releaseUp;
                 Main.LocalPlayer.releaseUseItem = playerFile.Player.releaseUseItem;
                 Main.LocalPlayer.releaseUseTile = playerFile.Player.releaseUseTile;
                 Main.LocalPlayer.remoteVisionForDrone = playerFile.Player.remoteVisionForDrone;
                 Main.LocalPlayer.resistCold = playerFile.Player.resistCold;
                 Main.LocalPlayer.respawnTimer = playerFile.Player.respawnTimer;
                 Main.LocalPlayer.restorationDelayTime = playerFile.Player.restorationDelayTime;
                 Main.LocalPlayer.reuseDelay = playerFile.Player.reuseDelay;
                 Main.LocalPlayer.rightTimer = playerFile.Player.rightTimer;
                 Main.LocalPlayer.rocketBoots = playerFile.Player.rocketBoots;
                 Main.LocalPlayer.rocketDelay = playerFile.Player.rocketDelay;
                 Main.LocalPlayer.rocketDelay2 = playerFile.Player.rocketDelay2;
                 Main.LocalPlayer.rocketFrame = playerFile.Player.rocketFrame;
                 Main.LocalPlayer.rocketRelease = playerFile.Player.rocketFrame;
                 Main.LocalPlayer.rocketSoundDelay = playerFile.Player.rocketSoundDelay;
                 Main.LocalPlayer.rocketTime = playerFile.Player.rocketTime;
                 Main.LocalPlayer.rocketTimeMax = playerFile.Player.rocketTimeMax;
                 Main.LocalPlayer.ropeCount = playerFile.Player.ropeCount;
                 Main.LocalPlayer.rulerGrid = playerFile.Player.rulerGrid;
                 Main.LocalPlayer.rulerLine = playerFile.Player.rulerLine;
                 Main.LocalPlayer.runAcceleration = playerFile.Player.runAcceleration;
                 Main.LocalPlayer.runningOnSand = playerFile.Player.runningOnSand;
                 Main.LocalPlayer.runSlowdown = playerFile.Player.runSlowdown;
                 Main.LocalPlayer.runSoundDelay = playerFile.Player.runSoundDelay;
                 Main.LocalPlayer.sailDash = playerFile.Player.sailDash;
                 Main.LocalPlayer.sapling = playerFile.Player.sapling;
                 Main.LocalPlayer.savedPerPlayerFieldsThatArentInThePlayerClass = playerFile.Player.savedPerPlayerFieldsThatArentInThePlayerClass;
                 Main.LocalPlayer.scope = playerFile.Player.scope;
                 Main.LocalPlayer.selectedItem = playerFile.Player.selectedItem;
                 Main.LocalPlayer.setApprenticeT2 = playerFile.Player.setApprenticeT2;
                 Main.LocalPlayer.setApprenticeT3 = playerFile.Player.setApprenticeT3;
                 Main.LocalPlayer.setBonus = playerFile.Player.setBonus;
                 Main.LocalPlayer.setForbidden = playerFile.Player.setForbidden;
                 Main.LocalPlayer.setForbiddenCooldownLocked = playerFile.Player.setForbiddenCooldownLocked;
                 Main.LocalPlayer.setHuntressT2 = playerFile.Player.setHuntressT2;
                 Main.LocalPlayer.setHuntressT3 = playerFile.Player.setHuntressT3;
                 Main.LocalPlayer.setMonkT2 = playerFile.Player.setMonkT2;
                 Main.LocalPlayer.setMonkT3 = playerFile.Player.setMonkT3;
                 Main.LocalPlayer.setNebula = playerFile.Player.setNebula;
                 Main.LocalPlayer.setSolar = playerFile.Player.setSolar;
                 Main.LocalPlayer.setSquireT2 = playerFile.Player.setSquireT2;
                 Main.LocalPlayer.setSquireT3 = playerFile.Player.setSquireT3;
                 Main.LocalPlayer.setStardust = playerFile.Player.setStardust;
                 Main.LocalPlayer.setVortex = playerFile.Player.setVortex;
                 Main.LocalPlayer.shadowArmor = playerFile.Player.shadowArmor;
                 Main.LocalPlayer.shadowCount = playerFile.Player.shadowCount;
                 Main.LocalPlayer.shadowDirection = playerFile.Player.shadowDirection;
                 Main.LocalPlayer.shadowDodge = playerFile.Player.shadowDodge;
                 Main.LocalPlayer.shadowDodgeCount = playerFile.Player.shadowDodgeCount;
                 Main.LocalPlayer.shadowDodgeTimer = playerFile.Player.shadowDodgeTimer;
                 Main.LocalPlayer.shadowOrigin = playerFile.Player.shadowOrigin;
                 Main.LocalPlayer.shadowPos = playerFile.Player.shadowPos;
                 Main.LocalPlayer.shadowRotation = playerFile.Player.shadowRotation;
                 Main.LocalPlayer.sharknadoMinion = playerFile.Player.sharknadoMinion;
                 Main.LocalPlayer.shield = playerFile.Player.shield;
                 Main.LocalPlayer.shieldParryTimeLeft = playerFile.Player.shieldParryTimeLeft;
                 Main.LocalPlayer.shieldRaised = playerFile.Player.shieldRaised;
                 Main.LocalPlayer.shield_parry_cooldown = playerFile.Player.shield_parry_cooldown;
                 Main.LocalPlayer.shimmerImmune = playerFile.Player.shimmerImmune;
                 Main.LocalPlayer.shimmering = playerFile.Player.shimmering;
                 Main.LocalPlayer.shimmerMonolithShader = playerFile.Player.shimmerMonolithShader;
                 Main.LocalPlayer.shimmerTransparency = playerFile.Player.shimmerTransparency;
                 Main.LocalPlayer.shimmerUnstuckHelper = playerFile.Player.shimmerUnstuckHelper;
                 Main.LocalPlayer.shimmerWet = playerFile.Player.shimmerWet;
                 Main.LocalPlayer.shinyStone = playerFile.Player.shinyStone;
                 Main.LocalPlayer.shirtColor = playerFile.Player.shirtColor;
                 Main.LocalPlayer.shoe = playerFile.Player.shoe;
                 Main.LocalPlayer.shoeColor = playerFile.Player.shoeColor;
                 Main.LocalPlayer.showLastDeath = playerFile.Player.showLastDeath;
                 Main.LocalPlayer.shroomiteStealth = playerFile.Player.shroomiteStealth;
                 Main.LocalPlayer.sign = playerFile.Player.sign;
                 Main.LocalPlayer.silence = playerFile.Player.silence;
                 Main.LocalPlayer.sitting = playerFile.Player.sitting;
                 Main.LocalPlayer.skeletron = playerFile.Player.skeletron;
                 Main.LocalPlayer.skinColor = playerFile.Player.skinColor;
                 Main.LocalPlayer.skinDyePacked = playerFile.Player.skinDyePacked;
                 Main.LocalPlayer.skinVariant = playerFile.Player.skinVariant;
                 Main.LocalPlayer.skipAnimatingValuesInPlayerFrame = playerFile.Player.skipAnimatingValuesInPlayerFrame;
                 Main.LocalPlayer.skyStoneEffects = playerFile.Player.skyStoneEffects;
                 Main.LocalPlayer.sleeping = playerFile.Player.sleeping;
                 Main.LocalPlayer.slideDir = playerFile.Player.slideDir;
                 Main.LocalPlayer.sliding = playerFile.Player.sliding;
                 Main.LocalPlayer.slime = playerFile.Player.slime;
                 Main.LocalPlayer.slippy = playerFile.Player.slippy;
                 Main.LocalPlayer.slippy2 = playerFile.Player.slippy2;
                 Main.LocalPlayer.sloping = playerFile.Player.sloping;
                

               //Whatever Sent me in orbit is above
               
               Main.LocalPlayer.slotsMinions = playerFile.Player.slotsMinions;
               Main.LocalPlayer.slow = playerFile.Player.slow;
               Main.LocalPlayer.slowFall = playerFile.Player.slowFall;
               Main.LocalPlayer.slowOgreSpit = playerFile.Player.slowOgreSpit;
               Main.LocalPlayer.smolstar = playerFile.Player.smolstar;
               Main.LocalPlayer.snowBallLauncherInteractionCooldown = playerFile.Player.snowBallLauncherInteractionCooldown;
               Main.LocalPlayer.snowman = playerFile.Player.snowman;
               Main.LocalPlayer.socialGhost = playerFile.Player.socialGhost;
               Main.LocalPlayer.socialIgnoreLight = playerFile.Player.socialIgnoreLight;
               Main.LocalPlayer.socialShadowRocketBoots = playerFile.Player.socialShadowRocketBoots;
               Main.LocalPlayer.solarCounter = playerFile.Player.solarCounter;
               Main.LocalPlayer.solarDashConsumedFlare = playerFile.Player.solarDashConsumedFlare;
               Main.LocalPlayer.solarDashing = playerFile.Player.solarDashing;
               Main.LocalPlayer.solarMonolithShader = playerFile.Player.solarMonolithShader;
               Main.LocalPlayer.solarShieldPos = playerFile.Player.solarShieldPos;
               Main.LocalPlayer.solarShields = playerFile.Player.solarShields;
               Main.LocalPlayer.solarShieldVel = playerFile.Player.solarShieldVel;
               Main.LocalPlayer.sonarPotion = playerFile.Player.sonarPotion;
               Main.LocalPlayer.soulDrain = playerFile.Player.soulDrain;
               Main.LocalPlayer.spaceGun = playerFile.Player.spaceGun;
               Main.LocalPlayer.spawnMax = playerFile.Player.spawnMax;
               Main.LocalPlayer.SpawnX = playerFile.Player.SpawnX;
               Main.LocalPlayer.SpawnY = playerFile.Player.SpawnY;
               Main.LocalPlayer.specialistDamage = playerFile.Player.specialistDamage;
               Main.LocalPlayer.speedSlice = playerFile.Player.speedSlice;
               Main.LocalPlayer.spelunkerTimer = playerFile.Player.spelunkerTimer;
               Main.LocalPlayer.spI = playerFile.Player.spI;
               Main.LocalPlayer.spider = playerFile.Player.spider;
               Main.LocalPlayer.spiderArmor = playerFile.Player.spiderArmor;
               Main.LocalPlayer.spiderMinion = playerFile.Player.spiderMinion;
               Main.LocalPlayer.spikedBoots = playerFile.Player.spikedBoots;
               Main.LocalPlayer.spN = playerFile.Player.spN;
               Main.LocalPlayer.sporeSac = playerFile.Player.sporeSac;
               Main.LocalPlayer.spX = playerFile.Player.spX;
               Main.LocalPlayer.spY = playerFile.Player.spY;
               Main.LocalPlayer.squashling = playerFile.Player.squashling;
               Main.LocalPlayer.stairFall = playerFile.Player.stairFall;
               Main.LocalPlayer.starCloakCooldown = playerFile.Player.starCloakCooldown;
               Main.LocalPlayer.starCloakItem = playerFile.Player.starCloakItem;
               Main.LocalPlayer.starCloakItem_beeCloakOverrideItem = playerFile.Player.starCloakItem_beeCloakOverrideItem;
               Main.LocalPlayer.starCloakItem_manaCloakOverrideItem = playerFile.Player.starCloakItem_manaCloakOverrideItem;
               Main.LocalPlayer.starCloakItem_starVeilOverrideItem = playerFile.Player.starCloakItem_starVeilOverrideItem;
               Main.LocalPlayer.stardustDragon = playerFile.Player.stardustDragon;
               Main.LocalPlayer.stardustGuardian = playerFile.Player.stardustGuardian;
               Main.LocalPlayer.stardustMinion = playerFile.Player.stardustMinion;
               Main.LocalPlayer.stardustMonolithShader = playerFile.Player.stardustMonolithShader;
               Main.LocalPlayer.starving = playerFile.Player.starving;
               Main.LocalPlayer.statDefense = playerFile.Player.statDefense;
               
               Main.LocalPlayer.stealth = playerFile.Player.stealth;
               Main.LocalPlayer.stealthTimer = playerFile.Player.stealthTimer;
               Main.LocalPlayer.step = playerFile.Player.step;
               Main.LocalPlayer.stepSpeed = playerFile.Player.stepSpeed;
               Main.LocalPlayer.sticky = playerFile.Player.sticky;
               Main.LocalPlayer.stickyBreak = playerFile.Player.stickyBreak;
               Main.LocalPlayer.stinky = playerFile.Player.stinky;
               Main.LocalPlayer.stoned = playerFile.Player.stoned;
               Main.LocalPlayer.stormTiger = playerFile.Player.stormTiger;
               Main.LocalPlayer.stringColor = playerFile.Player.stringColor;
               Main.LocalPlayer.strongBees = playerFile.Player.strongBees;
               Main.LocalPlayer.suffocateDelay = playerFile.Player.suffocateDelay;
               Main.LocalPlayer.suffocating = playerFile.Player.suffocating;
               Main.LocalPlayer.sunflower = playerFile.Player.sunflower;
               Main.LocalPlayer.suspiciouslookingTentacle = playerFile.Player.suspiciouslookingTentacle;
               Main.LocalPlayer.swimTime = playerFile.Player.swimTime;
               Main.LocalPlayer.tail = playerFile.Player.tail;
               Main.LocalPlayer.tankPet = playerFile.Player.tankPet;
               Main.LocalPlayer.tankPetReset = playerFile.Player.tankPetReset;
               Main.LocalPlayer.taxMoney = playerFile.Player.taxMoney;
               Main.LocalPlayer.taxTimer = playerFile.Player.taxTimer;
               Main.LocalPlayer.team = playerFile.Player.team;
               Main.LocalPlayer.teleporting = playerFile.Player.teleporting;
               Main.LocalPlayer.teleportStyle = playerFile.Player.teleportStyle;
               Main.LocalPlayer.teleportTime = playerFile.Player.teleportTime;
               Main.LocalPlayer.thorns = playerFile.Player.thorns;
               Main.LocalPlayer.tiki = playerFile.Player.tiki;
               Main.LocalPlayer.tileEntityAnchor = playerFile.Player.tileEntityAnchor;
               Main.LocalPlayer.tileInteractAttempted = playerFile.Player.tileInteractAttempted;
               Main.LocalPlayer.tileInteractionHappened = playerFile.Player.tileInteractAttempted;
               Main.LocalPlayer.tileSpeed = playerFile.Player.tileSpeed;
               Main.LocalPlayer.timeShimmering = playerFile.Player.timeShimmering;
               Main.LocalPlayer.timeSinceLastDashStarted = playerFile.Player.timeSinceLastDashStarted;
               Main.LocalPlayer.tipsy = playerFile.Player.tipsy;
               Main.LocalPlayer.titaniumStormCooldown = playerFile.Player.titaniumStormCooldown;
               Main.LocalPlayer.tongued = playerFile.Player.tongued;
               Main.LocalPlayer.toolTime = playerFile.Player.toolTime;
               Main.LocalPlayer.torchLuck = playerFile.Player.torchLuck;
               Main.LocalPlayer.TouchedTiles = playerFile.Player.TouchedTiles;
               Main.LocalPlayer.townNPCs = playerFile.Player.townNPCs;
               Main.LocalPlayer.trackBoost = playerFile.Player.trackBoost;
               Main.LocalPlayer.trapDebuffSource = playerFile.Player.trapDebuffSource;
               Main.LocalPlayer.trashItem = playerFile.Player.trashItem;
               Main.LocalPlayer.treasureMagnet = playerFile.Player.treasureMagnet;
               Main.LocalPlayer.trident = playerFile.Player.trident;
               Main.LocalPlayer.truffle = playerFile.Player.truffle;
               Main.LocalPlayer.tryKeepingHoveringDown = playerFile.Player.tryKeepingHoveringDown;
               Main.LocalPlayer.tryKeepingHoveringUp = playerFile.Player.tryKeepingHoveringUp;
               Main.LocalPlayer.turtle = playerFile.Player.turtle;
               Main.LocalPlayer.turtleArmor = playerFile.Player.turtleArmor;
               Main.LocalPlayer.turtleThorns = playerFile.Player.turtleThorns;
               Main.LocalPlayer.twinsMinion = playerFile.Player.twinsMinion;
               Main.LocalPlayer.UFOMinion = playerFile.Player.UFOMinion;
               Main.LocalPlayer.underShirtColor = playerFile.Player.underShirtColor;
               Main.LocalPlayer.unlockedBiomeTorches = playerFile.Player.unlockedBiomeTorches;
               Main.LocalPlayer.unlockedSuperCart = playerFile.Player.unlockedSuperCart;
               Main.LocalPlayer.usedAegisCrystal = playerFile.Player.usedAegisCrystal;
               Main.LocalPlayer.usedAegisFruit = playerFile.Player.usedAegisFruit;
               Main.LocalPlayer.usedAmbrosia = playerFile.Player.usedAmbrosia;
               Main.LocalPlayer.usedArcaneCrystal = playerFile.Player.usedArcaneCrystal;
               Main.LocalPlayer.usedGalaxyPearl = playerFile.Player.usedGalaxyPearl;
               Main.LocalPlayer.usedGummyWorm = playerFile.Player.usedGummyWorm;
               Main.LocalPlayer.vampireFrog = playerFile.Player.vampireFrog;
               Main.LocalPlayer.vanityRocketBoots = playerFile.Player.vanityRocketBoots;
               Main.LocalPlayer.velocity = playerFile.Player.velocity;
               Main.LocalPlayer.venom = playerFile.Player.venom;
               Main.LocalPlayer.voidLensChest = playerFile.Player.voidLensChest;
               Main.LocalPlayer.voidVaultInfo = playerFile.Player.voidVaultInfo;
               Main.LocalPlayer.volatileGelatin = playerFile.Player.volatileGelatin;
               Main.LocalPlayer.volatileGelatinCounter = playerFile.Player.volatileGelatinCounter;
               Main.LocalPlayer.vortexDebuff = playerFile.Player.vortexDebuff;
               Main.LocalPlayer.vortexMonolithShader = playerFile.Player.vortexMonolithShader;
               Main.LocalPlayer.vortexStealthActive = playerFile.Player.vortexStealthActive;
               Main.LocalPlayer.waist = playerFile.Player.waist;
               Main.LocalPlayer.wallSpeed = playerFile.Player.wallSpeed;
               Main.LocalPlayer.waterWalk = playerFile.Player.waterWalk;
               Main.LocalPlayer.waterWalk2 = playerFile.Player.waterWalk2;
               Main.LocalPlayer.wearsRobe = playerFile.Player.wearsRobe;
               Main.LocalPlayer.webbed = playerFile.Player.webbed;
               Main.LocalPlayer.wellFed = playerFile.Player.wellFed;
               Main.LocalPlayer.wereWolf = playerFile.Player.wereWolf;
               Main.LocalPlayer.wet = playerFile.Player.wet;
               Main.LocalPlayer.wetCount = playerFile.Player.wetCount;
               Main.LocalPlayer.wetSlime = playerFile.Player.wetSlime;
               Main.LocalPlayer.whipRangeMultiplier = playerFile.Player.whipRangeMultiplier;
               Main.LocalPlayer.whoAmI = playerFile.Player.whoAmI;
               Main.LocalPlayer.width = playerFile.Player.width;
               Main.LocalPlayer.windPushed = playerFile.Player.windPushed;
               Main.LocalPlayer.wingAccRunSpeed = playerFile.Player.wingAccRunSpeed;
               Main.LocalPlayer.wingFrame = playerFile.Player.wingFrame;
               Main.LocalPlayer.wingFrameCounter = playerFile.Player.wingFrameCounter;
               Main.LocalPlayer.wingRunAccelerationMult = playerFile.Player.wingRunAccelerationMult;
               Main.LocalPlayer.wings = playerFile.Player.wings;
               Main.LocalPlayer.wingsLogic = playerFile.Player.wingsLogic;
               Main.LocalPlayer.wingTime = playerFile.Player.wingTime;
               Main.LocalPlayer.wingTimeMax = playerFile.Player.wingTimeMax;
               Main.LocalPlayer.wireOperationsCooldown = playerFile.Player.wireOperationsCooldown;
               Main.LocalPlayer.wisp = playerFile.Player.wisp;
               Main.LocalPlayer.witheredArmor = playerFile.Player.witheredArmor;
               Main.LocalPlayer.witheredWeapon = playerFile.Player.witheredWeapon;
               Main.LocalPlayer.wolfAcc = playerFile.Player.wolfAcc;
               Main.LocalPlayer.yoraiz0rDarkness = playerFile.Player.yoraiz0rDarkness;
               Main.LocalPlayer.yoraiz0rEye = playerFile.Player.yoraiz0rEye;
               Main.LocalPlayer.yoyoGlove = playerFile.Player.yoyoGlove;
               Main.LocalPlayer.yoyoString = playerFile.Player.yoyoString;
               Main.LocalPlayer.zephyrfish = playerFile.Player.zephyrfish;
               Main.LocalPlayer.zone1 = playerFile.Player.zone1;
               Main.LocalPlayer.zone2 = playerFile.Player.zone2;
               Main.LocalPlayer.zone3 = playerFile.Player.zone3;
               Main.LocalPlayer.zone4 = playerFile.Player.zone4;
               Main.LocalPlayer.zone5 = playerFile.Player.zone5;
               Main.LocalPlayer._framesLeftEligibleForDeadmansChestDeathAchievement = playerFile.Player._framesLeftEligibleForDeadmansChestDeathAchievement;
               Main.LocalPlayer._funkytownAchievementCheckCooldown = playerFile.Player._funkytownAchievementCheckCooldown;
               Main.LocalPlayer._portalPhysicsTime = playerFile.Player._portalPhysicsTime;
               Main.LocalPlayer.Center = playerFile.Player.Center;

               





                Main.LocalPlayer.position.X = float.Parse(a.ReadLine());
                Main.LocalPlayer.position.Y = float.Parse(a.ReadLine());
                Main.LocalPlayer.fallStart = int.Parse(a.ReadLine()); //GRAVIGTY DEATH
                Main.LocalPlayer.fallStart2 = int.Parse(a.ReadLine()); //GRAVITY DEATH
                Main.LocalPlayer.statLife = int.Parse(a.ReadLine()); 
                Main.LocalPlayer.statLifeMax = int.Parse(a.ReadLine()); 
                Main.LocalPlayer.statLifeMax2 = int.Parse(a.ReadLine()); 
                Main.LocalPlayer.statMana = int.Parse(a.ReadLine()); ;
                Main.LocalPlayer.statManaMax = int.Parse(a.ReadLine()); 
                Main.LocalPlayer.statManaMax2 = int.Parse(a.ReadLine());                 Main.LocalPlayer.bodyPosition.X = float.Parse(a.ReadLine());
                Main.LocalPlayer.bodyPosition.Y = float.Parse(a.ReadLine());
                Main.LocalPlayer.bodyRotation = float.Parse(a.ReadLine());
                Main.LocalPlayer.bodyVelocity.X = float.Parse(a.ReadLine());
                Main.LocalPlayer.bodyVelocity.Y = float.Parse(a.ReadLine());
                Main.LocalPlayer.aggro = int.Parse(a.ReadLine());
                Main.LocalPlayer.blockExtraJumps = bool.Parse(a.ReadLine());
                Main.LocalPlayer.breath = int.Parse(a.ReadLine());
                Main.LocalPlayer.breathCD = int.Parse(a.ReadLine());
                Main.LocalPlayer.breathMax = int.Parse(a.ReadLine());
                Main.LocalPlayer.dash = int.Parse(a.ReadLine());
                Main.LocalPlayer.dashDelay = int.Parse(a.ReadLine());
                Main.LocalPlayer.delayUseItem = bool.Parse(a.ReadLine());
                Main.LocalPlayer.desertDash = bool.Parse(a.ReadLine());
                Main.LocalPlayer.sailDash = bool.Parse(a.ReadLine());
                Main.LocalPlayer.direction = int.Parse(a.ReadLine());
                Main.LocalPlayer.forceMerman = bool.Parse(a.ReadLine());
                Main.LocalPlayer.forceWerewolf = bool.Parse(a.ReadLine());
                Main.LocalPlayer.immuneTime = int.Parse(a.ReadLine());
                Main.LocalPlayer.lavaCD = int.Parse(a.ReadLine());
                Main.LocalPlayer.lavaImmune = bool.Parse(a.ReadLine());
                Main.LocalPlayer.lavaMax = int.Parse(a.ReadLine());
                Main.LocalPlayer.lavaTime = int.Parse(a.ReadLine());
                Main.LocalPlayer.manaSick = bool.Parse(a.ReadLine());
                Main.LocalPlayer.manaSickReduction = float.Parse(a.ReadLine());
                Main.LocalPlayer.potionDelay = int.Parse(a.ReadLine());
                Main.LocalPlayer.potionDelayTime = int.Parse(a.ReadLine());
                Main.LocalPlayer.rocketBoots = int.Parse(a.ReadLine());
                Main.LocalPlayer.rocketDelay = int.Parse(a.ReadLine());
                Main.LocalPlayer.rocketDelay2 = int.Parse(a.ReadLine());
                Main.LocalPlayer.rocketFrame = bool.Parse(a.ReadLine());
                Main.LocalPlayer.rocketRelease = bool.Parse(a.ReadLine());
                Main.LocalPlayer.rocketSoundDelay = int.Parse(a.ReadLine());
                Main.LocalPlayer.rocketTime = int.Parse(a.ReadLine());
                Main.LocalPlayer.rocketTimeMax = int.Parse(a.ReadLine());
                Main.LocalPlayer.starCloakCooldown = int.Parse(a.ReadLine());
                Main.LocalPlayer.suffocateDelay = byte.Parse(a.ReadLine());
                Main.LocalPlayer.suffocating = bool.Parse(a.ReadLine());
                Main.LocalPlayer.swimTime = int.Parse(a.ReadLine());
                Main.LocalPlayer.velocity.X = float.Parse(a.ReadLine());
                Main.LocalPlayer.velocity.Y = float.Parse(a.ReadLine());
                Main.LocalPlayer.wingAccRunSpeed = float.Parse(a.ReadLine());
                Main.LocalPlayer.wingFrame = int.Parse(a.ReadLine());
                Main.LocalPlayer.wingFrameCounter = int.Parse(a.ReadLine());
                Main.LocalPlayer.wingRunAccelerationMult = float.Parse(a.ReadLine());
                Main.LocalPlayer.wings = int.Parse(a.ReadLine());
                Main.LocalPlayer.wingsLogic = int.Parse(a.ReadLine());
                Main.LocalPlayer.wingTime = float.Parse(a.ReadLine());
                Main.LocalPlayer.wingTimeMax = int.Parse(a.ReadLine());





                a.Close();
                /*
                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wld"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wld");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldp", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wld");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldp", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wld");
                }
                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twld"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twld");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldp", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twld");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldp", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twld");
                }
                */
                Main.LocalPlayer.HealEffect(50);
                //WorldFile.LoadWorld(false);
                return base.OnPickup(item);
            }
            return base.OnPickup(item);
        }

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            hasDied = true;
            //PlayerFileData playerFile = Player.GetFileData("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr", false);
            //Player.SavePlayer(playerFile, true);
            //System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr");
            //System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr.bak");
           // System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.tplr");
            //System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.tplr.bak");
            
            //System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString());
           // System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\BEans.plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr.bak");
           // System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\BEans.tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.tplr");
            //System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\BEans.tplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.tplr.bak");
            //Player.LoadPlayer("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\D.plr", false);
            //Player.FixLoadedData();
            //WorldFile.SaveWorld();
            //Main.WorldPath = "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\.wld";
            //WorldFile.LoadWorld(false);
            //WorldFile.SaveWorld();

            //Player.FixLoadedData();
           // Main.LocalPlayer.HealEffect(50);

            //Player.SavePlayer("BEans.plr", false);
            //base.Kill(damage, hitDirection, pvp, damageSource);
        }

        public async void CheckPoint()
        {
            //Main.WorldPath = "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\d.wld";
            //Main.GoToWorldSelect();
            //THIS IS THE WORLD
            // WorldFile.SaveWorld();
            // System.IO.File.WriteAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "PATH", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wld");

            //System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wld", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldx");

            WorldFile.SaveWorld();
            if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldx"))
            {
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldx");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wld", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldx");
            }
            else
            {
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wld", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldx");
            }

            
            if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldx"))
            {
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldx");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twld", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldx");
            }
            else
            {
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twld", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldx");
            }
            

            
            //WorldFile.LoadWorld(false);
            if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr"))
            {
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr");

            }
            else
            {
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr");

            }

            if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr.bak"))
            {
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr.bak");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr.bak");

            }
            else
            {
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr.bak");
            }

            //////
            ///

            if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr"))
            {
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr");

            }
            else
            {
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr");

            }

            if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr.bak"))
            {
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr.bak");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr.bak");

            }
            else
            {
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr.bak");
            }

            System.IO.File.WriteAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", Main.LocalPlayer.position.X.ToString() + "\n" + Main.LocalPlayer.position.Y.ToString() + "\n" + Main.LocalPlayer.fallStart.ToString() + "\n" + Main.LocalPlayer.fallStart2.ToString() + "");
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.statLife.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.statLifeMax.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.statLifeMax2.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.statMana.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.statManaMax.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.statManaMax2.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.bodyPosition.X.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.bodyPosition.Y.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.bodyRotation.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.bodyVelocity.X.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.bodyVelocity.Y.ToString());

            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.aggro.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.blockExtraJumps.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.breath.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.breathCD.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.breathMax.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.dash.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.dashDelay.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.delayUseItem.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.desertDash.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.sailDash.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.direction.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.forceMerman.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.forceWerewolf.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.immuneTime.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.lavaCD.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.lavaImmune.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.lavaMax.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.lavaTime.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.manaSick.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.manaSickReduction.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.potionDelay.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.potionDelayTime.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.rocketBoots.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.rocketDelay.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.rocketDelay2.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.rocketFrame.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.rocketRelease.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.rocketSoundDelay.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.rocketTime.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.rocketTimeMax.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.starCloakCooldown.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.suffocateDelay.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.suffocating.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.swimTime.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.velocity.X.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.velocity.Y.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.wingAccRunSpeed.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.wingFrame.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.wingFrameCounter.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.wingRunAccelerationMult.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.wings.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.wingsLogic.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.wingTime.ToString());
            System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "\n" + Main.LocalPlayer.wingTimeMax.ToString());

            /*
            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr.bak");
            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr");
            System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr.bak");
           */
            hasDied = false;
            await Task.Delay(15000);
            if(hasDied == true)
            {
                hasDied = false;
            }
            else
            {
                
                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldp"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldp");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldx", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldp");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldx", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".wldp");
                }

                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldp"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldp");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldx", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldp");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldx", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Worlds\\" + Main.worldName + ".twldp");
                }

                



                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                 // FOR .plr
                if(System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                }
                // For .plr.bak
                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                }
                //For .tplr
                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                }
                //For .tplr.bak
                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                }
                /*
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".Xtplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                */



                //PlayerFileData playerFile = Player.GetFileData("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", false);
                //Player.SavePlayer(playerFile, true);
                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr"))
                {
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr"))
                    {
                        System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                    }
                    else
                    {
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr");
                    }

                }

                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak"))
                {
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak"))
                    {
                        System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                    }
                    else
                    {
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".plr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".plr.bak");
                    }

                }

                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr"))
                {
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr"))
                    {
                        System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                    }
                    else
                    {
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr");
                    }

                }

                if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak"))
                {
                    if (System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak"))
                    {
                        System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr.bak", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                    }
                    else
                    {
                        System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + ".tplr", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + Player.name.ToString() + ".tplr.bak");
                    }

                }

                Main.LocalPlayer.HealEffect(50);
                if(System.IO.File.Exists("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData"))
                {
                    System.IO.File.Delete("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData");
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData");
                }
                else
                {
                    System.IO.File.Copy("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointDataX", "C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData");
                }
                /* IMPORTANT SWAP SECTION FOR POSITION*/
                //checkPointPosition = Main.LocalPlayer.position;
                //checkPointBodyPosition.

                //checkPointFallStart = Main.LocalPlayer.fallStart;
                //checkPointFallStart2 = Main.LocalPlayer.fallStart2;

                /*
                System.IO.File.WriteAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", Main.LocalPlayer.position.X.ToString() + "\n" + Main.LocalPlayer.position.Y.ToString() + "\n" + Main.LocalPlayer.fallStart.ToString() + "\n" + Main.LocalPlayer.fallStart2.ToString() + "");
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.statLife.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.statLifeMax.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.statLifeMax2.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.statMana.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.statManaMax.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.statManaMax2.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.bodyPosition.X.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.bodyPosition.Y.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.bodyRotation.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.bodyVelocity.X.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.bodyVelocity.Y.ToString());

                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.aggro.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.blockExtraJumps.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.breath.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.breathCD.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.breathMax.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.dash.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.dashDelay.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.delayUseItem.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.desertDash.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.sailDash.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.direction.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.forceMerman.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.forceWerewolf.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.immuneTime.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.lavaCD.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.lavaImmune.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.lavaMax.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.lavaTime.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.manaSick.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.manaSickReduction.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.potionDelay.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.potionDelayTime.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.rocketBoots.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.rocketDelay.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.rocketDelay2.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.rocketFrame.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.rocketRelease.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.rocketSoundDelay.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.rocketTime.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.rocketTimeMax.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.starCloakCooldown.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.suffocateDelay.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.suffocating.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.swimTime.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.velocity.X.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.velocity.Y.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.wingAccRunSpeed.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.wingFrame.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.wingFrameCounter.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.wingRunAccelerationMult.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.wings.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.wingsLogic.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.wingTime.ToString());
                System.IO.File.AppendAllText("C:\\Users\\caela\\Documents\\my games\\Terraria\\tModLoader-preview\\Players\\" + Player.name.ToString() + "\\" + "CheckpointData", "\n" + Main.LocalPlayer.wingTimeMax.ToString());
                */










                //checkPointBodyPosition = Main.LocalPlayer.bodyPosition;
                //checkPointBodyRotation = Main.LocalPlayer.bodyRotation;
                //checkPointBodyVelocity = Main.LocalPlayer.bodyVelocity;


            }

        }



    }
}