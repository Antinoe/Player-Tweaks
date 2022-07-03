using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PlayerTweaks
{
	public class PlayerTweaksPlayer : ModPlayer
	{
		public override void PostUpdateMiscEffects()
		{
			if (PlayerTweaksConfig.Instance.enablePlayerTweaks)
			{
				if (PlayerTweaksConfig.Instance.enablePlayerTweaksMovementVertical)
				{
					Player.jumpHeight += PlayerTweaksConfig.Instance.playerJumpHeight;
					Player.jumpSpeed += PlayerTweaksConfig.Instance.playerJumpSpeed;
					Player.gravity += PlayerTweaksConfig.Instance.playerGravity;
				}
				if (PlayerTweaksConfig.Instance.enablePlayerTweaksLife)
				{
					Player.lifeRegen = PlayerTweaksConfig.Instance.playerLifeRegen;
					Player.breathMax = PlayerTweaksConfig.Instance.playerBreath;
					//Player.statLifeMax2 *=  (int)(Player.statLifeMax * PlayerTweaksConfig.Instance.playerLifeMax);
					//Disabled until I figure out how to fix it.
				}
				/*if (PlayerTweaksConfig.Instance.enablePlayerTweaksMana)
				{
					Player.manaRegen = PlayerTweaksConfig.Instance.playerManaRegen;
				}*/
				//Doesn't work right now.
				if (PlayerTweaksConfig.Instance.enablePlayerTweaksCombatOffensive)
				{
					Player.maxMinions += PlayerTweaksConfig.Instance.playerMaxMinions;
					Player.maxTurrets += PlayerTweaksConfig.Instance.playerMaxTurrets;
				}
				if (PlayerTweaksConfig.Instance.enablePlayerTweaksCombatOffensiveArmorPenetration)
				{
					Player.GetArmorPenetration(DamageClass.Generic) += PlayerTweaksConfig.Instance.playerArmorPenetrationGeneric;
					Player.GetArmorPenetration(DamageClass.Melee) += PlayerTweaksConfig.Instance.playerArmorPenetrationMelee;
					Player.GetArmorPenetration(DamageClass.Ranged) += PlayerTweaksConfig.Instance.playerArmorPenetrationRanged;
					Player.GetArmorPenetration(DamageClass.Magic) += PlayerTweaksConfig.Instance.playerArmorPenetrationMagic;
					Player.GetArmorPenetration(DamageClass.Summon) += PlayerTweaksConfig.Instance.playerArmorPenetrationSummon;
				}
				if (PlayerTweaksConfig.Instance.enablePlayerTweaksCombatDefensive)
				{
					Player.statDefense += PlayerTweaksConfig.Instance.playerDefense;
					Player.endurance += PlayerTweaksConfig.Instance.playerEndurance;
				}
			}
		}
		public override void PostUpdateRunSpeeds()
		{
			if (PlayerTweaksConfig.Instance.enablePlayerTweaks)
			{
				if (PlayerTweaksConfig.Instance.enablePlayerTweaksMovementHorizontal)
				{
					Player.maxRunSpeed += PlayerTweaksConfig.Instance.playerRunSpeedMax;
					Player.runAcceleration += PlayerTweaksConfig.Instance.playerRunAcceleration;
					Player.runSlowdown += PlayerTweaksConfig.Instance.playerRunSlowdown;
				}
			}
		}
		public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
			//Player.immune = true;
			Player.immuneTime += PlayerTweaksConfig.Instance.playerImmuneTime;
        }
	}
}