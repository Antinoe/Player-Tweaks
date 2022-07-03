using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PlayerTweaks
{
    [Label("Server Config")]
    public class PlayerTweaksConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static PlayerTweaksConfig Instance;
		
        [Label("Enable Mod")]
        [Tooltip("If false, this mod's features are disabled.\n[Default: Off]")]
        [DefaultValue(true)]
        public bool enablePlayerTweaks {get; set;}
		
	[Header("Player Movement (Vertical)")]
		
        [Label("Enable This Section")]
        [Tooltip("If false, Player Movement modifiers will not be applied.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enablePlayerTweaksMovementVertical {get; set;}
		
        [Label("Jump Height")]
        [Tooltip("[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-10, 10)]
        [Increment(1)]
        public int playerJumpHeight {get; set;}
		
        [Label("Jump Speed")]
        [Tooltip("[Default: 0]")]
        [Slider]
        [DefaultValue(0f)]
        [Range(-1f, 1f)]
        [Increment(0.1f)]
        public float playerJumpSpeed {get; set;}
		
        [Label("Gravity")]
        [Tooltip("[Default: 0]")]
        [Slider]
        [DefaultValue(0f)]
        [Range(-1f, 1f)]
        [Increment(0.1f)]
        public float playerGravity {get; set;}
		
	[Header("Player Movement (Horizontal)")]
		
        [Label("Enable This Section")]
        [Tooltip("If false, Player Movement modifiers will not be applied.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enablePlayerTweaksMovementHorizontal {get; set;}
		
        [Label("Max Run Speed")]
        [Tooltip("[Default: 0]")]
        [Slider]
        [DefaultValue(0f)]
        [Range(-1f, 1f)]
        [Increment(1f)]
        public float playerRunSpeedMax {get; set;}
		
        [Label("Run Acceleration")]
        [Tooltip("[Default: 0]")]
        [Slider]
        [DefaultValue(0f)]
        [Range(-1f, 1f)]
        [Increment(0.05f)]
        public float playerRunAcceleration {get; set;}
		
        [Label("Run Slowdown")]
        [Tooltip("[Default: 0]")]
        [Slider]
        [DefaultValue(0f)]
        [Range(-1f, 1f)]
        [Increment(0.1f)]
        public float playerRunSlowdown {get; set;}
		
	[Header("Player Life")]
		
        [Label("Enable This Section")]
        [Tooltip("If false, Player Life modifiers will not be applied.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enablePlayerTweaksLife {get; set;}
		
        [Label("Life Regeneration")]
        [Tooltip("Initial Life Regeneration Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(0, 10)]
        [Increment(1)]
        public int playerLifeRegen {get; set;}
		
        [Label("Immune Time")]
        [Tooltip("Additional Immunity Players have after receiving damage\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-20, 80)]
        [Increment(10)]
        public int playerImmuneTime {get; set;}
		
        [Label("Breath")]
        [Tooltip("Initial Breath Time Players have.\n[Default: 200]")]
        [Slider]
        [DefaultValue(200)]
        [Range(0, 400)]
        [Increment(20)]
        public int playerBreath {get; set;}
		
	[Header("Player Combat (Offensive)")]
		
        [Label("Enable This Section")]
        [Tooltip("If false, offensive Player Combat modifiers will not be applied.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enablePlayerTweaksCombatOffensive {get; set;}
		
        [Label("Maximum Minions")]
        [Tooltip("Additional Minions Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-1, 10)]
        [Increment(1)]
        public int playerMaxMinions {get; set;}
		
        [Label("Maximum Sentries")]
        [Tooltip("Additional Sentries Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-1, 10)]
        [Increment(1)]
        public int playerMaxTurrets {get; set;}
		
	[Header("Player Combat (Offensive) - Armor Penetration")]
		
        [Label("Enable This Section")]
        [Tooltip("If false, Armor Penetration modifiers will not be applied to Players.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enablePlayerTweaksCombatOffensiveArmorPenetration {get; set;}
		
        [Label("Armor Penetration (Generic)")]
        [Tooltip("Additional Generic Armor Penetration Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-1, 10)]
        [Increment(1)]
        public int playerArmorPenetrationGeneric {get; set;}
		
        [Label("Armor Penetration (Melee)")]
        [Tooltip("Additional Melee Armor Penetration Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-1, 10)]
        [Increment(1)]
        public int playerArmorPenetrationMelee {get; set;}
		
        [Label("Armor Penetration (Ranged)")]
        [Tooltip("Additional Ranged Armor Penetration Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-1, 10)]
        [Increment(1)]
        public int playerArmorPenetrationRanged {get; set;}
		
        [Label("Armor Penetration (Magic)")]
        [Tooltip("Additional Magic Armor Penetration Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-1, 10)]
        [Increment(1)]
        public int playerArmorPenetrationMagic {get; set;}
		
        [Label("Armor Penetration (Summoner)")]
        [Tooltip("Additional Summoner Armor Penetration Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(-1, 10)]
        [Increment(1)]
        public int playerArmorPenetrationSummon {get; set;}
		
	[Header("Player Combat (Defensive)")]
		
        [Label("Enable This Section")]
        [Tooltip("If false, defensive Player Combat modifiers will not be applied.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool enablePlayerTweaksCombatDefensive {get; set;}
		
        [Label("Defense")]
        [Tooltip("Additional Defense Points Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(0, 20)]
        [Increment(1)]
        public int playerDefense {get; set;}
		
        [Label("Endurance")]
        [Tooltip("Additional percentage of Damage Reduction Players have.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0f)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float playerEndurance {get; set;}
    }
}