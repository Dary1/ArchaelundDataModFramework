# Archaelund Game Data Files Documentation

This document lists all Archaelund game data files, their column structures, and **all available IDs** for use with the Archaelund Data Mod Framework.

## File Structure Overview

All files use **tab-separated values (TSV)** format with the following characteristics:
- **Delimiter**: Tab (`\t`)
- **Comments**: Lines starting with `//` are ignored
- **Section Headers**: Lines starting with `*` (e.g., `*WEAPONS*`) are ignored
- **Case Insensitive**: Column names are matched case-insensitively

---

## 1. items.txt

**Purpose**: Main item catalog and properties  
**ID Column**: `ID`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| ID | String | `iron_longsword`, `steel_mace` | Unique item identifier |
| Type | String | `Weapon`, `Shield`, `Garment` | Item category |
| Icon | String | `sword`, `shield_round` | Icon reference |
| UMA Recipe | String | `PADDED`, `CHAIN_1` | UMA recipe reference |
| Model | String | `longsword`, `o_shield2` | 3D model reference |
| Stack | Integer | `1`, `99999`, `20` | Max stack size |
| Slot | String | `Mainhand`, `Chest`, `Backpack` | Equipment slot |
| Weapon ID | String | `sword_1`, `mace_2` | Reference to weapons.txt |
| Armor ID | String | `armor_leather_3`, `helmet_1` | Reference to armor.txt |
| Bonuses & Powers | String | `willpower 3`, `prot_fire 1` | Special bonuses |
| Weight | Float | `2`, `3.5`, `0.1` | Item weight |
| Price | Integer | `30`, `250`, `-1` | Item price (-1 = not for sale) |
| Sound | String | `Sword`, `MetalArmor`, `General` | Sound effect category |
| Requirements | String | `trait#STR,6`, `skill#healing,2` | Usage requirements |
| durable | Float | `1`, `0.3` | Item durability |

### Available Item IDs:

#### **Weapons (Basic):**
`wooden_club`, `spiked_club`, `bone_club`, `rusty_longsword`, `rusty_shortsword`, `shiv`, `wooden_maul`, `wooden_spear`, `rotten_bow`, `rusty_greatsword`, `iron_mace`, `iron_warhammer`, `iron_longsword`, `iron_battleaxe`, `iron_shortsword`, `iron_dagger`, `iron_maul`, `iron_greatsword`, `iron_greataxe`, `iron_spear`, `wooden_staff`, `hunt_bow`, `long_bow_elm`, `steel_shortsword`, `steel_dagger`, `steel_spear`, `steel_mace`, `steel_warhammer`, `steel_maul`, `long_bow_yew`

#### **Weapons (Advanced):**
`red_battleaxe`, `red_battleaxe_madness`, `bluesteel_battleaxe`, `bluesteel_longsword`, `bluesteel_shortsword`, `centurion_greatsword`, `finisher_maul`, `finisher_dagger`, `blightstone`, `apprentice_staff`, `evirye_staff`, `verdant_staff`, `envoy_lance`, `varsilian_claymore`, `ruffian_blade`, `ironbreaker`, `flaming_dagger`, `death_dagger`, `sword_seafarer`, `shocking_rod`, `obsidian_axe`, `spear_shaman`, `cleaver_iverro`, `silvery_mace`, `desecrated_mace`, `darksteel_mace`, `dark_acolyte_staff`, `foreman_maul`, `orran_bow`, `composite_bow`, `serpentine_bow`, `grey_hunter_bow`, `skirmisher_bow`, `targeteer_longbow`, `stonebell`, `iron_creed`, `ashfall_longsword`, `glacerus_blade`, `crystalline_fang`, `xoladan_greatsword`, `rankbreaker`

#### **Weapons (Special):**
`geldryn_bone_claymore`, `geldryn_bone_spear`, `geldryn_bone_blade`, `gladius`, `spatha`, `dolabra`, `pilum`, `steelfang`, `torch`, `torch_lit`

#### **Shields:**
`off_shield_cracked`, `off_shield_round`, `off_shield_wooden`, `off_shield_knight`, `off_shield_honor`, `off_shield_protector`

#### **Offhand Weapons:**
`off_iron_maigauche`, `off_iron_hatchet`, `off_iron_parrysword`

#### **Arrows:**
`arrow_steel_tipped`, `arrow_balanced`, `arrow_piercing`, `arrow_vanguard`, `arrow_incendiary`, `arrow_ironwood`

#### **Armor (Light):**
`armor_padded`, `armor_hauberk`, `armor_leather`, `armor_leather_reinforced`, `helmet_leather`, `gauntlets_leather`, `boots_leather`, `boots_skin`, `armor_geldryn`, `gauntlets_geldryn`, `boots_geldryn`, `boots_wyvern_damaged`, `armor_wyvern`, `helmet_wyvern`, `gauntlets_wyvern`, `boots_wyvern`

#### **Armor (Heavy):**
`armor_scrap`, `helmet_iron`, `gloves_swordman`, `armor_light_chain`, `armor_chain`, `helmet_chain`, `gauntlets_chain`, `boots_chain`, `armor_plate`, `helmet_plate`, `gauntlets_plate`, `boots_plate`, `armor_mercian`, `helmet_mercian`, `gauntlets_mercian`, `boots_mercian`, `armor_velites`, `gauntlets_velites`, `boots_velites`, `armor_myrosian`, `helmet_myrosian`, `gauntlets_myrosian`, `boots_myrosian`

#### **Clothing:**
`robes_blue`, `robes_student`, `fine_clothes_green`, `fine_clothes_redblue`, `travel_clothes`, `robes_grey`, `robes_advisor`, `barbarian_clothes3`, `barbarian_clothes5`, `hood_meditation`, `galeb_tricorne`, `journeyman_hat`, `silvery_circlet`, `summoner_circlet`, `zahaid_hat`, `interrogator_hood`, `boots_striding`, `greater_boots_striding`, `gloves_explorer`, `gloves_engineer`, `gloves_artificer`, `burial_gloves`

#### **Cloaks & Belts:**
`winter_cloak`, `brigand_cloak`, `thuram_cloak`, `shaman_mantle`, `fleetfoot_cloak`, `commander_cloak`, `imperial_envoy_belt`, `imperial_legate_belt`, `imperial_enforcer_belt`, `imperial_magistrate_belt`

#### **Jewelry:**
`ring_resist_fire`, `ring_resist_cold`, `ring_elementalist`, `ring_resist_toxic`, `ring_resist_fire_greater`, `ring_resist_cold_greater`, `ring_resist_shock`, `ring_health`, `ring_resist_death`, `ring_resist_mind`, `ring_icanos`, `ring_wizardry_lesser`, `ring_sorcery`, `ring_orran`, `ring_pilgrim`, `ring_silent_god`, `ring_commander`, `charm_hunter`, `charm_shaman`, `pendant_salende`, `medal_galeb`, `pendant_sorcery`, `amulet_geldryn`, `amulet_tainted`, `charm_tracker`, `charm_windcaller`

#### **Consumables:**
`rations`, `lockpick`, `firstaid_1`, `firstaid_2`, `tome_ancient_wisdom`, `moonlight_brew`, `potion_deep_breath`, `potion_greyward`, `potion_heal`, `potion_heal_2`, `potion_antidote`, `potion_antidote_2`, `potion_might`, `potion_speed`, `potion_might_2`, `potion_speed_2`, `potion_resist_fire`, `potion_resist_cold`, `potion_resist_shock`, `potion_resist_toxic`, `potion_resist_vitality`, `potion_resist_death`, `potion_resist_mind`, `potion_remove_curse`, `potion_cure_disease`, `potion_cure_insanity`, `potion_lesser_remedy`, `potion_dark_essence`, `blessed_loaf`, `geldryn_wp_pot`

#### **Herbs:**
`herb_ulmsille`, `herb_dylloris`, `herb_irudal`, `herb_aurum`, `herb_flammata`, `herb_boravis`, `herb_vidanna`

#### **Valuables:**
`diamond`, `pearl`, `ruby`, `sapphire`, `emerald`, `topaz`, `diamond_small`, `pearl_small`, `ruby_small`, `sapphire_small`, `emerald_small`, `topaz_small`, `seashell_1`, `seashell_2`, `seashell_3`, `imperial_crown`, `imperial_penny`

#### **Materials:**
`broken_weapon`, `broken_armor`, `metal_scraps`, `poison_gland`, `norrax_scales`, `norrax_eggs`, `minotaur_horn`, `skull`, `stone_heart`, `hard_chitin`, `ironwood`, `mercian_silk`, `cavernous_extract`, `troll_blood`, `batrax_wax`, `mycora_pods`, `panther_pelt`, `stalker_hide`, `golden_carapace`, `tainted_blood`, `druant_heart`, `warping_pelt`, `shard_madness`, `rumblebeast_tongue`, `poisonous_fangs`, `reptile_eye`, `queen_eyes`

---

## 2. weapons.txt

**Purpose**: Weapon combat statistics  
**ID Column**: `ID`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| ID | String | `sword_1`, `mace_2`, `bow_3` | Weapon identifier |
| type | String | `longsword`, `mace`, `bow` | Base weapon type |
| Material | String | `Steel`, `Iron` | Material type |
| Accuracy | Integer | `0`, `5`, `10` | Accuracy bonus |
| Crit | Integer | `0`, `3`, `6` | Critical hit bonus |
| A.Pierc. | Integer | `0`, `2`, `4` | Armor piercing |
| Damage | Integer | `0`, `1`, `3` | Damage bonus |
| DamageType | String | `fire`, `cold`, `shock` | Elemental damage type |
| 2nd. Damage | String | `2,3,3`, `1,4` | Secondary damage (chance,power,duration) |
| eff Chance | Integer | `1`, `2`, `3` | Effect chance |
| eff Power | Integer | `poison`, `stun` | Effect type |
| Effect | String | `poison`, `stun`, `paralysis` | Status effect |
| Effect Res | String | `vitality`, `mind`, `spirit` | Resistance type |
| Res Mod | Integer | `15`, `25` | Resistance modifier |
| Powers | String | `betrayed` | Special powers |

### Available Weapon IDs:

#### **Basic Weapons:**
`unarmed`, `torch`, `torch_lit`

#### **Tier 0 (Ruined):**
`mace_0`, `mace_0b`, `sword_0`, `axe_0`, `shortsword_0`, `dagger_0`, `maul_0`, `spear_0`, `staff_0`, `bow_0`, `greatsword_0`

#### **Tier 1 (Iron):**
`mace_1`, `hammer_1`, `sword_1`, `axe_1`, `shortsword_1`, `dagger_1`, `maul_1`, `greatsword_1`, `greataxe_1`, `spear_1`, `bow_1`, `longbow_1`

#### **Tier 2 (Steel):**
`mace_2`, `mace_2b`, `hammer_2`, `sword_2`, `sword_2b`, `axe_2`, `axe_2b`, `axe_2c`, `shortsword_2`, `shortsword_2f`, `dagger_2`, `maul_2`, `maul_2b`, `greatsword_2`, `greatsword_2b`, `greatsword_2c`, `greataxe_2`, `spear_2`, `spear_2b`, `dagger_2p`, `bow_2`, `bow_2b`, `bow_2p`, `longbow_2`, `longbow_2s`

#### **Tier 3 (Blue Steel):**
`mace_3`, `mace_3_stun`, `hammer_3`, `sword_3`, `sword_3f`, `sword_3c`, `axe_3`, `axe_3r`, `shortsword_3`, `gladius`, `spatha`, `dagger_3`, `dagger_3s`, `maul_3`, `maul_3b`, `greatsword_3`, `greatsword_3c`, `dolabra`, `pilum`, `greatsword_3b`, `bow_3`, `longbow_3`, `spear_pilum`, `dagger_steelfang`

#### **Magical Weapons:**
`blightstone`, `cleaver_iverro`, `dagger_frost`, `dagger_fire`, `dagger_sacrifice`, `dagger_lightning`, `dagger_acid`, `sword_betrayed`, `spear_3f`, `greataxe_terminus`

#### **Monster Attacks:**
`bite_fast`, `bite_small`, `bite_medium`, `bite_large`, `bite_large_elite`, `slam`, `slam_2`, `panther_claw`, `panther_claw_elite`, `helliant_claw`, `wolf_bite`, `wolf_bite_elite`, `spider_bite_0`, `spider_bite_1`, `spider_bite_2`, `beetle_gold_bite`, `beetle_bite`, `bomig_bite_test`, `bomig_bite`, `bomig_hunter_bite`, `wight_blade`, `wight_mace`, `ghost_touch`, `claw_sleep`, `guardian_b`, `fire_claw`, `yaksa_1`, `sentinel_punch`, `engineer_hammer`, `mechaedron`, `deadly_punch`, `greatsword_geldryn`, `spear_geldryn`, `dagger_geldryn`, `purecold_claw`, `toxic_punch_elite`, `gorlisk_bite`, `velthane_bite`, `velthane_bite2`

#### **Projectiles:**
`arrow_steel_tipped`, `arrow_balanced`, `arrow_piercing`, `arrow_vanguard`, `arrow_incendiary`, `arrow_ironwood`

---

## 3. basic_weapons.txt

**Purpose**: Base weapon type definitions  
**ID Column**: `id`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| id | String | `longsword`, `bow`, `dagger` | Base weapon type |
| ranged | Integer | `0`, `8`, `9` | Range in tiles (0 = melee) |
| APCost | Integer | `3`, `4`, `5` | Action points to use |
| minDamage | Integer | `1`, `3`, `4` | Minimum damage |
| maxDamage | Integer | `4`, `7`, `12` | Maximum damage |
| dmgTrait | String | `STR`, `AWA` | Damage scaling attribute |
| accuracy | Integer | `0`, `5` | Base accuracy |
| critical | Integer | `0`, `3`, `8` | Base critical chance |
| sound | String | `Small`, `Medium`, `Large` | Sound effect |
| damagetype | String | `Slashing`, `Blunt`, `Piercing` | Physical damage type |
| skill | String | `Light`, `Hand`, `TwoHanded` | Required skill |
| piercing | Integer | `0`, `1`, `2` | Armor piercing |
| style | String | `OneHanded`, `TwoHanded`, `Bow` | Combat style |
| nameTag | String | `BW_LONGSWORD`, `BW_BOW` | Localization tag |
| requirements | String | `trait#STR,4`, `trait#DEX,5` | Stat requirements |

### Available Base Weapon IDs:
`claw_fast`, `claw`, `claw_slow`, `slam`, `unarmed`, `mace`, `hammer`, `dagger`, `shortsword`, `longsword`, `battleaxe`, `spear`, `staff`, `greatsword`, `greataxe`, `maul`, `bow`, `bow_long`, `arrow`, `bolt`

---

## 4. careers.txt

**Purpose**: Character career/class definitions  
**ID Column**: `id`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| id | String | `apprentice`, `bandit`, `knight` | Career identifier |
| category | String | `sage`, `warrior`, `advanced` | Career category |
| lightw | Integer | `1`, `3`, `5` | Light weapons skill |
| handw | Integer | `1`, `3`, `6` | Hand weapons skill |
| 2hw | Integer | `1`, `4`, `6` | Two-handed weapons skill |
| unarw | Integer | `1`, `3`, `5` | Unarmed combat skill |
| rangw | Integer | `1`, `4`, `6` | Ranged weapons skill |
| crit | Integer | `0`, `1`, `3` | Critical hit skill |
| dodge | Integer | `0`, `2`, `4` | Dodge skill |
| armor | String | `1,0,1,0,1,0` | Armor proficiency |
| default traits | String | `3,4,4,4,5,6,7` | Starting attributes |
| skillpoints | Integer | `1`, `3`, `4` | Skill points per level |
| skills | String | `alchemy, meditation` | Starting skills |
| health | Integer | `1`, `4`, `6` | Health bonus |
| levels | Integer | `4`, `6`, `8` | Max levels |
| disciplines | String | `Impetus, Gateway` | Magic disciplines |
| magic adv | String | `1,1,2,1,1,2` | Magic advancement |
| req1, req2, req3 | String | `trait#INT,6`, `race#human` | Requirements |
| hidden | Integer | `0`, `1` | Hidden career flag |

### Available Career IDs:

#### **Basic Careers:**
`apprentice`, `bandit`, `barbarian`, `beggar` *(hidden)*, `bodyguard`, `burglar`, `charmer`, `hunter`, `initiate`, `labourer`, `minstrel` *(hidden)*, `naturalist` *(hidden)*, `oblate` *(hidden)*, `pilgrim`, `pikeman`, `ruffian`, `scavenger` *(hidden)*, `seaman`, `squire`, `trickster` *(hidden)*, `witch` *(hidden)*

#### **Advanced Careers:**
`arcanist` *(hidden)*, `assassin` *(hidden)*, `bounty_hunter` *(hidden)*, `captain` *(hidden)*, `gladiator` *(hidden)*, `journeyman` *(hidden)*, `knight` *(hidden)*, `mercenary` *(hidden)*, `monk` *(hidden)*, `priest` *(hidden)*, `warden` *(hidden)*

#### **NPC Careers:**
`NPC_weak`, `NPC_monster`, `NPC_strong`, `NPC_elite`, `NPC_epic`

---

## 5. careers_talents.txt

**Purpose**: Career talent progression  
**ID Column**: `id`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| id | String | `apprentice`, `bandit` | Career identifier |
| tal1-tal8 | String | `erudite_spellcaster`, `open` | Talent names |
| lvl_tal1-lvl_tal8 | Integer | `1`, `3`, `5` | Level requirements |
| trait1, trait2 | String | `INT`, `DEX`, `STR` | Bonus traits |
| lvl_tr1, lvl_tr2 | Integer | `4`, `6`, `8` | Trait bonus levels |

### Available Career IDs:
Same as careers.txt (all career IDs listed above)

---

## 6. talents.txt

**Purpose**: Talent definitions and effects  
**ID Column**: `id`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| id | String | `erudite_spellcaster`, `rage` | Talent identifier |
| icon | String | `scroll`, `dodge` | Icon reference |
| type | String | `P`, `A` | Type (Passive/Active) |
| cost_AP | Integer | `2`, `4`, `6` | Action point cost |
| cost_wp | Integer | `1`, `3`, `6` | Willpower cost |
| dailyuses | Integer | `1`, `3` | Daily use limit |
| combatuses | Integer | `1` | Combat use limit |
| req1, req2, req3 | String | `trait#str,4` | Requirements |
| category | String | `open` | Talent category |
| target | String | `enemy`, `ally`, `self` | Valid targets |
| range | Integer | `2`, `7`, `99` | Range in tiles |
| passive bonus | String | `willpower 5`, `dodge 5` | Passive effects |
| notes | String | `hunter`, `apprentice` | Additional notes |
| unimplemented | Integer | `0`, `1` | Implementation status |

### Available Talent IDs:

#### **Basic Talents:**
`arcane_blood`, `backstabber`, `beast_slayer`, `beast_mastery`, `deathblow`, `erudite_spellcaster`, `fortitude`, `hand_mercy`, `hardiness`, `locksmith`, `mind_bender`, `mind_tricks`, `nature_way`, `pathfinding`, `phalanx_discipline`, `protector`, `rage`, `sacrifice`, `shield_master`

#### **Advanced Talents:**
`gifted_pupil`, `adept_student`, `adept_summoner`, `arcane_scholar`, `battle_awareness`, `battle_momentum`, `battle_tide`, `channeling`, `charge`, `combat_mobility`, `combat_mobility_2`, `defensive_stance`, `dodge_expert`, `fast_loading`, `flanking_expert`, `gifted_enchanter`, `heavyhand`, `heavyhand_2`, `heavyhand_3`, `herbalist`, `heroic_surge`, `iron_will`, `knockdown`, `lightning_reflexes`, `magic_researcher`, `marksmanship`, `martial_training`, `mighty_spells`, `mighty_spells_2`, `mighty_spells_3`, `no_blind_spots`, `polearm_training`, `resolve`, `resolve_2`, `resolve_3`, `second_skin`, `shield_expert`, `scribe`, `stunning_blow`, `swashbuckler`, `tactical_mind`, `tenacious_fortitude`, `tenacious_fortitude_2`, `tenacious_fortitude_3`, `threatening_fire`, `totemic_might`

#### **Special Talents:**
`open`, `blessing_might`, `blessing_perception`, `blessing_passion`, `blessing_judgement`, `vision_horrors`

#### **Hidden/NPC Talents:**
`pack_leader`, `maintenance`, `arcane_mastery`, `troll_regen`, `acid_blood`, `pyrophobia`, `unwilling_adventurer`, `lifeless`, `stable`, `petty_lord`, `wooden`, `warpbeast`, `regeneration`, `voice_depth`, `drain_life`, `fear`, `charismatic`, `bewilder`, `infantry_training`, `garleas_blessing`, `martial_artist`, `soft_feet`, `retribution`, `heavy_hitter`, `legend_lore`, `packhorse`, `performance`, `precission_strike`, `showdown`, `fearless`, `sword_training`, `taunt`, `trap_sense`, `treacherous_stab`, `vampiric_touch`, `whirlwind`, `slam`, `quick_hands`, `vicious_slash`, `thaumaturgist`, `magic_prodigy`, `focused_preparation`, `finishing_shot`

---

## 7. spells.txt

**Purpose**: Magic spell definitions  
**ID Column**: `id`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| id | String | `thunder_arrow`, `firebrand` | Spell identifier |
| icon | String | `ice_shards`, `barrier` | Icon reference |
| Discipline | String | `Impetus`, `Gateway`, `Piety` | Magic discipline |
| Rank | Integer | `1`, `2`, `3` | Spell rank/level |
| price | Integer | `100`, `250` | Learning cost |
| ap | Integer | `2`, `4`, `8` | Action point cost |
| cost_wp | Integer | `3`, `5`, `10` | Willpower cost |
| type | String | `C`, `E`, `CE` | Cast type |
| target | String | `enemy`, `ally`, `area2` | Valid targets |
| range | Integer | `7`, `9`, `t` | Range (t=touch) |
| resist | String | `vitality`, `mind`, `spirit` | Resistance type |
| duration | String | `12r`, `30m`, `3r+SP` | Effect duration |
| delay | Float | `0.7`, `1`, `5.5` | Cast delay |
| effectTarget | String | `2d6h + SP`, `summon_beast#` | Effect description |
| excludetargets | String | `not_beasts`, `c` | Target exclusions |
| FX_caster | String | `aura,blue`, `fire_ring` | Caster visual effect |
| FX_target_uniq | String | `magic_impact` | Unique target effect |
| FX_target | String | `aura,magenta` | Target visual effect |
| FX_projectile | String | `fire_bolt`, `force_bolt` | Projectile effect |
| tags | String | `hostile,damage`, `friendly,heal` | Spell categories |
| notes | String | `Special behavior notes` | Additional info |
| AI data | Integer | `0` | AI usage data |
| hidden | Integer | `0`, `1` | Hidden spell flag |

### Available Spell IDs by Discipline:

#### **Impetus (Elemental Magic):**
`thunder_arrow`, `static_burst`, `scorching_wave`, `firebrand`, `blizzard_shards`, `fire_arrow`, `ice_spike`

#### **Conjuration (Manifestation):**
`barrier_force`, `summon_shield`, `flame_ward`, `ice_ward`, `impact`, `energy_ward`, `summon_fire_sword`, `summon_terminus`

#### **Gateway (Summoning):**
`escape`, `summon_vermin_skreeval`, `summon_vermin_spider`, `dark_tendrils`, `summon_stone_guardian`, `banish_summoned`, `summon_void_spider`

#### **Mentalism (Mind Magic):**
`fascinate`, `bliss`, `outrage`, `mind_matter`, `slumber`, `mind_surge`, `agony_grasp`, `peace_mind`, `bewitch`

#### **Piety (Divine Magic):**
`nivaria_hand`, `purification`, `holy_sustenance`, `psalm_renewal`, `miracle_minor`, `nivaria_word`, `lesser_remedy`

#### **Animism (Nature Magic):**
`breath_life`, `soothe_wild`, `ensnaring_tendrils`, `mark_wolf`, `mark_bear`, `insect_swarm`, `regrowth`

#### **Auspice (Divination):**
`sixth_sense`, `ethereal_lantern`, `precognition`, `unseal`, `blinding_flash`, `unseal_greater`

#### **Order (Holy Combat):**
`swift_justice`, `sacred_flame`, `nivaria_barrier`, `cleansing_flame`, `arms_righteous`, `avatar_justice`, `nivaria_shield`

#### **Malediction (Dark Magic):**
`hand_dead`, `evil_eye`, `last_rites`, `torment_needles`, `drain_essence`, `searing_malison`, `doom_touch`, `melt_armor`

---

## 8. items_actions.txt

**Purpose**: Item usage actions and conditions  
**ID Column**: `ID`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| ID | String | `potion_heal`, `torch` | Item identifier |
| take_conditions | String | `NoStep#lament_deep,95` | Conditions to take item |
| take_actions | String | `AddStep#lament_deep,95` | Actions when taken |
| daily_uses | Integer | `1`, `2` | Daily use limit |
| charges | Integer | `10`, `20` | Item charges |
| use_conditions | String | `VarLower#mushroom_hunting,210` | Conditions to use |
| use_actions | String | `heal#18`, `cast#slumber` | Actions when used |
| read | String | `scroll7;stain1;c08_letter` | Reading content |
| usability | String | `C`, `CE`, `E` | Usage context |
| use_sound | String | `horn`, `General` | Sound when used |

### Available Item Action IDs:
`yaksa_draught`, `potion_deep_breath`, `potion_greyward`, `potion_heal`, `potion_heal_2`, `potion_antidote`, `potion_antidote_2`, `herb_ulmsille`, `herb_dylloris`, `herb_vidanna`, `herb_aurum`, `herb_boravis`, `herb_flammata`, `potion_resist_fire`, `potion_resist_cold`, `potion_resist_shock`, `potion_resist_toxic`, `potion_resist_vitality`, `potion_resist_death`, `potion_dark_essence`, `potion_resist_mind`, `potion_might`, `potion_speed`, `potion_might_2`, `potion_speed_2`, `potion_remove_curse`, `potion_cure_disease`, `potion_cure_insanity`, `potion_lesser_remedy`, `tome_ancient_wisdom`, `charm_purification`, `horn_lament`, `torch`, `torch_lit`, `blessed_loaf`, `geldryn_wp_pot`, `restraining_order`, `court_dismissal`

---

## 9. armor.txt

**Purpose**: Armor and protection statistics  
**ID Column**: First column (no header name)

### Columns:
| Column Position | Type | Sample Values | Description |
|----------------|------|---------------|-------------|
| 1 | String | `armor_padded_1`, `shield_0` | Armor identifier |
| 2 (Armor) | Integer | `0`, `5`, `9` | Armor rating |
| 3 (Crit Def) | Integer | `0`, `3`, `8` | Critical defense |
| 4 (Penalty) | Integer | `1`, `5`, `10` | Movement penalty |
| 5 (Deflect) | Integer | `0`, `8`, `16` | Deflection rating |
| 6 (Powers) | String | `prot_fire 1` | Special powers |
| 7 (Category) | String | `light`, `heavy` | Armor category |

### Available Armor IDs:

#### **Basic Armor:**
`h_armor_0`, `h_gloves_0`, `h_boots_0`, `l_armor_0`

#### **Shields:**
`shield_0`, `shield_1`, `shield_2`, `shield_truewood`, `shield_3`

#### **Body Armor:**
`armor_padded_1`, `armor_leather_2`, `armor_leather_3`, `armor_leather_4`, `armor_geldryn_4`, `armor_wyvern_6b`, `armor_scrap_5`, `armor_chain_5b`, `armor_chain_6`, `armor_velites`, `armor_plate_7`, `armor_mercian_8`, `armor_myrosian_9`, `robes_advisor`

#### **Helmets:**
`l_helm_0`, `helmet_1`, `helmet_1b`, `helmet_wyvern_6b`, `h_helm_0`, `helmet_iron`, `helmet_chain_6`, `helmet_plate_7`, `helmet_mercian_8`, `helmet_9`

#### **Gauntlets:**
`gauntlets_1`, `gauntlets_2`, `gauntlets_geldryn_4`, `gauntlets_chain_6`, `gauntlets_wyvern_6b`, `gauntlets_velites`, `gauntlets_plate_7`, `gauntlets_8`, `gauntlets_9`

#### **Boots:**
`boots_1`, `boots_geldryn_4`, `boots_chain_6`, `boots_wyvern_6b`, `boots_velites`, `boots_plate_7`, `boots_8`, `boots_9`

---

## 10. bestiary.txt

**Purpose**: Monster and NPC definitions  
**ID Column**: `ID`

### Columns:
| Column Name | Type | Sample Values | Description |
|-------------|------|---------------|-------------|
| ID | String | `Norrax`, `Skeleton`, `BanditM` | Creature identifier |
| portrait | String | `norrax`, `skeleton` | Portrait image |
| prefab | String | `Norrax`, `Humanoid` | 3D model prefab |
| width | Float | `1`, `1.6`, `4.9` | Creature width |
| height | Float | `1`, `1.6`, `4.9` | Creature height |
| outfit | String | `banditNH`, `barbarian5` | Outfit/clothing |
| UMA_dna | String | `skeleton`, `thug` | UMA DNA reference |
| Level | Integer | `1`, `5`, `10` | Creature level |
| Career | String | `NPC_weak`, `bandit` | Career/class |
| Gender | String | `M`, `F` | Gender |
| Race | String | `Human`, `Other`, `Skeleton` | Race |
| Speed | String | `0.75,0.8`, `1.1,1.6` | Movement speed |
| Traits SDEAPIF | String | `3,4,2,4,1,1,1` | Attribute array |
| AP | Integer | `7`, `9`, `11` | Action points |
| Armor | Integer | `0`, `3`, `9` | Armor rating |
| CritDef | Integer | `0`, `10`, `30` | Critical defense |
| Avoid | Integer | `0`, `5`, `20` | Avoidance rating |
| Weapon 1 | String | `bite_small`, `sword_1` | Primary weapon |
| Style1 | String | `Unarmed`, `SwordAndShield` | Combat style |
| mhand,o-hand | String | `rusty_longsword,off_shield_cracked` | Equipment |
| sounds | String | `skeleton`, `ghost` | Sound set |
| talents | String | `pack_leader`, `rage` | Special talents |
| resist VSM | String | `0,0,50`, `20,30,60` | Resistances |
| protection FCST | String | `3,3,-2,3`, `6,6,-6,6` | Protections |
| spells | String | `thunder_arrow`, `heal` | Known spells |
| Faction | String | `Monsters`, `Party` | Faction alignment |
| Loot | String | `norrax`, `bandit_2` | Loot table |
| Type | String | `beast`, `undead`, `human` | Creature type |
| Myth | String | `norrax`, `skeleton` | Mythology reference |
| XP | Integer | `20`, `100`, `500` | Experience reward |

### Available Creature IDs:

#### **Beasts:**
`Norrax`, `Norrax_Alpha`, `Norrax_enraged`, `Wolf`, `Medrin_Panther`, `Galxair`, `Stalker`, `Urthagar`, `Warp_Wolf`, `Warp_Wolf_alpha`, `Rumblebeast`

#### **Insects & Vermin:**
`Bomig_hatchling`, `Bomig`, `Bomig_hunter`, `Bomig_herdling`, `Crab`, `Crab_Elder`, `Crab_Metuselah`, `Mirmek`, `Mirmek_herder`, `Mirmek_warrior`, `Pyrochiton`, `Beetle`, `Beetle_Gold`, `Spider_Giant`, `Spider_Blight`, `Tharnarach`, `skreeval`, `Skreeval_rabid`

#### **Plants & Fungi:**
`Mycora`, `Mycora_elder`, `Druant_elder`, `Druant`

#### **Constructs:**
`guardian_broken`, `Mechaedron`, `Sentient_rock`, `Stone_Sentinel`

#### **Undead:**
`Skeleton`, `Skeleton_crypt`, `Skeletal_warrior_2h`, `Skeletal_labourer`, `Skeletal_foreman`, `Skeletal_Champion`, `Skeletal_constable`, `Skeletal_engineer`, `SkeletalArcher`, `SkeletalTargeteer`, `Ghoul`, `Ghoul_6`, `Wight`, `Wight_lawyer`, `Wight_vanthas`, `Wight_sorcerer`, `d07_mino_zombie`, `Ghost`, `Ghost_Arcane`

#### **Reptiles:**
`Gorlisk`, `Velthane`, `Velthane_Queen`

#### **Humanoids (Bandits):**
`HumanCaster_M3`, `Thug`, `Brute`, `BanditF`, `BanditM`, `Bandit_M3`, `Bandit_sergeant`, `Bandit_chief`, `Bandit_chief_nosom`, `Bandit_chief_gienne`, `Firedancer_M3`, `BanditM_goblin`, `BanditF_goblin`, `BanditArcher`, `BanditMarksman`, `BanditVarannariM`, `BanditMino`, `Rogue_4`, `VeiledBlade_5`

#### **Humanoids (Military):**
`Spear_4`, `Spear_4_f`, `Sergeant_5`, `Sergeant_5_mino`, `halrick_npc`, `legion_spear_6`, `legion_ss_6`, `velites_archer`, `velites_infantry`

#### **Humanoids (Nomads):**
`VarannariNomad`, `VarannariNomadF`, `VarannariNomadChief`, `Witch_5_varannari`

#### **Humanoids (Geldryn):**
`Geldryn_Raider`, `Geldryn_Screamer`, `Geldryn_Voidcaller`, `Geldryn_Bonewarden`

#### **Fey & Spirits:**
`Yaksa_scout`, `Harit`, `Meliae`, `Helliant`

#### **NPCs & Guards:**
`GuardM`, `GuardF`, `L4_priest`, `L4_guard`, `d08_garrav`, `d08_brem`

#### **Base Templates:**
`BaseHumanM`, `BaseHumanF`, `BaseVarannariM`, `BaseVarannariF`, `BaseTeldorianM`, `BaseTeldorianF`, `GeldrynM`, `GeldrynF`, `MinoM`, `MinoF`, `GoblinM`, `GoblinF`, `BarbarianM`, `BarbarianF`, `BaseHuman`, `BaseVarannari`, `Geldryn`, `Mino`, `Goblin`, `Batrax`, `Batrax_caster_3`, `Batrax_caster_6`

#### **Special Encounters:**
`Troll`, `Red_Eyes_Girl`, `Red_Eyes_Bouncer`, `Red_Eyes_Boss`

---

## Usage Examples

### Example 1: Modify Iron Longsword Price
```json
{
  "fileName": "items.txt",
  "idColumn": "ID", 
  "replacements": [{
    "rowIdentifier": "iron_longsword",
    "columnName": "Price",
    "newValue": "15",
    "comment": "Make iron longsword cheaper"
  }]
}
```

### Example 2: Boost Steel Dagger Critical Hit
```json
{
  "fileName": "weapons.txt",
  "idColumn": "ID",
  "replacements": [{
    "rowIdentifier": "dagger_2",
    "columnName": "Crit",
    "newValue": "8",
    "oldValue": "3",
    "comment": "Buff steel dagger critical chance"
  }]
}
```

### Example 3: Enable Hidden Career
```json
{
  "fileName": "careers.txt",
  "idColumn": "id",
  "replacements": [{
    "rowIdentifier": "witch",
    "columnName": "hidden",
    "newValue": "0",
    "oldValue": "1",
    "comment": "Unlock witch career"
  }]
}
```

### Example 4: Increase Norrax XP Reward
```json
{
  "fileName": "bestiary.txt",
  "idColumn": "ID",
  "replacements": [{
    "rowIdentifier": "Norrax",
    "columnName": "XP",
    "newValue": "25",
    "oldValue": "20",
    "comment": "Increase Norrax experience reward"
  }]
}
```

### Example 5: Make Apprentice Career Start with More Health
```json
{
  "fileName": "careers.txt",
  "idColumn": "id",
  "replacements": [{
    "rowIdentifier": "apprentice", 
    "columnName": "health",
    "newValue": "3",
    "oldValue": "1",
    "comment": "Give apprentice more starting health"
  }]
}
```

### Example 6: Reduce Healing Potion Price
```json
{
  "fileName": "items.txt",
  "idColumn": "ID",
  "replacements": [{
    "rowIdentifier": "potion_heal",
    "columnName": "Price", 
    "newValue": "80",
    "oldValue": "120",
    "comment": "Make healing potions cheaper"
  }]
}
```

---

## Notes

- **Case Insensitive**: All column names and IDs are matched case-insensitively
- **Hidden Items**: Items marked *(hidden)* require special unlocking or may be NPC-only
- **References**: Some items reference others (Weapon ID → weapons.txt, Armor ID → armor.txt)
- **Special Values**: Empty strings `""`, `-1` prices, and `0` values have special meanings
- **Optional Validation**: Set `oldValue` to validate current values before replacement
- **Comments**: Use `//` for file comments, `*` for section headers
- **Multiple Files**: You can modify multiple files in a single config
- **Backup**: Plugin can create backups of original files (configurable)
