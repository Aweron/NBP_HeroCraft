using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NBP_Prototype
{
    public class CharacterClass
    {
        public string ClassName { get; set; }
        public Character Character { get; set; }

        public int MaxHealth { get; set; }
        public int ArmorClass { get; set; }
        public int MaxResource { get; set; }

        public string PrimaryName { get; set; }
        public string SecondaryName { get; set; }

        public static Random roll = new Random();

        public CharacterClass(Character character)
        {
            ClassName = character.Class;
            Character = character;

            int dex;
            switch (ClassName)
            {
                case "Barbarian":
                    MaxHealth = 40 + 5 * ConvertToMod(character.stats[2]); // Average HP + Lvl * CON, assumed level 5
                    ArmorClass = 10 + ConvertToMod(character.stats[1]) + ConvertToMod(character.stats[2]); // AC = 10 + DEX + CON
                    MaxResource = 1;
                    PrimaryName = "Greataxe (Action)";
                    SecondaryName = "Rage (Bonus Action)";

                    break;
                case "Bard":
                    MaxHealth = 28 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 11 + ConvertToMod(character.stats[1]); // AC = 11 + DEX (Leather armor)
                    MaxResource = 2;
                    PrimaryName = "Rapier (Action)";
                    SecondaryName = "Hideous Laughter (Action)";
                    break;
                case "Cleric":
                    MaxHealth = 28 + 5 * ConvertToMod(character.stats[2]);
                    dex = ConvertToMod(character.stats[1]);
                    if (dex > 2) dex = 2; 
                    ArmorClass = 14 + dex; // AC = 14 + DEX(max 2) (Scale Mail)
                    MaxResource = 2;
                    PrimaryName = "Sacred Flame (Action)";
                    SecondaryName = "Healing Word (Bonus Action)";
                    break;
                case "Druid":
                    MaxHealth = 28 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 11 + ConvertToMod(character.stats[1]); // AC = 11 + DEX (Leather armor)
                    MaxResource = 2;
                    PrimaryName = "Shillelagh (Action)";
                    SecondaryName = "Entangle (Action)";
                    break;
                case "Fighter":
                    MaxHealth = 34 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 16; // AC = 16 (Chain Mail)
                    MaxResource = 1;
                    PrimaryName = "Greatsword (Action)";
                    SecondaryName = "Second Wind (Bonus Action)";
                    break;
                case "Monk":
                    MaxHealth = 28 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 10 + ConvertToMod(character.stats[1]) + ConvertToMod(character.stats[4]); // AC = 10 + DEX + WIS
                    MaxResource = 2;
                    PrimaryName = "Unarmed Strike (Action)";
                    SecondaryName = "Flurry of Blows (Bonus Action)";
                    break;
                case "Paladin":
                    MaxHealth = 34 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 16; // AC = 16 (Chain Mail)
                    MaxResource = 2;
                    PrimaryName = "Warhammer (Action)";
                    SecondaryName = "Divine Smite (Bonus Action)";
                    break;
                case "Ranger":
                    MaxHealth = 34 + 5 * ConvertToMod(character.stats[2]);
                    dex = ConvertToMod(character.stats[1]);
                    if (dex > 2) dex = 2;
                    ArmorClass = 14 + dex; // AC = 14 + DEX(max 2) (Scale Mail)
                    MaxResource = 1;
                    PrimaryName = "Longbow (Action)";
                    SecondaryName = "Hunter's Mark (Bonus Action)";
                    break;
                case "Rogue":
                    MaxHealth = 28 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 11 + ConvertToMod(character.stats[1]); // AC = 11 + DEX (Leather armor)
                    MaxResource = 1;
                    PrimaryName = "Dagger (Action)";
                    SecondaryName = "Off-hand Dagger (Bonus Action)";
                    break;
                case "Sorcerer":
                    MaxHealth = 22 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 13 + ConvertToMod(character.stats[1]); // AC = 13 + DEX (Mage armor)
                    MaxResource = 2;
                    PrimaryName = "Frostbite (Action)";
                    SecondaryName = "Chaos Bolt (Bonus Action)";
                    break;
                case "Warlock":
                    MaxHealth = 28 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 11 + ConvertToMod(character.stats[1]); // AC = 11 + DEX (Leather armor)
                    MaxResource = 1;
                    PrimaryName = "Eldritch Blast (Action)";
                    SecondaryName = "Hex (Bonus Action)";
                    break;
                case "Wizard":
                    MaxHealth = 22 + 5 * ConvertToMod(character.stats[2]);
                    ArmorClass = 13 + ConvertToMod(character.stats[1]); // AC = 13 + DEX (Mage armor)
                    MaxResource = 2;
                    PrimaryName = "Fire Bolt (Action)";
                    SecondaryName = "Magic Missile (Action)";
                    break;
                default:
                    break;
            }
        }

        public int ConvertToMod(int stat)
        {
            return (stat - 8) / 2 - 1;
        }

        public int RollDie(int die)
        {
            return roll.Next(1, die);
        }

        public bool RollAttack(int opponentAC)
        {
            RedisManager redis = new RedisManager();
            int roll = RollDie(20);
            if (roll >= opponentAC)
            {
                redis.AddToCombatLog(Character.Name + " rolled a " + roll + " and hit the opponent!");
                return true;
            }
            else
            {
                redis.AddToCombatLog(Character.Name + " rolled a " + roll + " and missed the opponent.");
                return false;
            }
        }

        public int RollDamage(int amountOfDice, int die, int stat, int bonus)
        {
            int damage = 0;

            for (int i = 0; i < amountOfDice; i++)
                damage += RollDie(die);
            if (stat >= 0)
                damage += ConvertToMod(Character.stats[stat]) + bonus;
            else damage += bonus;
            RedisManager redis = new RedisManager();
            return damage;
        }

        public bool RollSpellSave(int casterStat, int saveStat, CharacterClass opponent)
        {
            RedisManager redis = new RedisManager();
            int spellSaveDC = 10 + ConvertToMod(Character.stats[casterStat]);
            int opponentSave = RollDie(20) + ConvertToMod(opponent.Character.stats[saveStat]);
            if (opponentSave > spellSaveDC)
            {
                redis.AddToCombatLog(opponent.Character.Name + " rolled a " + opponentSave + ", succeeding the saving throw.");
                return true;
            }
            else
            {
                redis.AddToCombatLog(opponent.Character.Name + " rolled a " + opponentSave + ", failing the saving throw!");
                return false;
            }
        }

        public bool PrimaryAttack(bool isPlayer1, CharacterClass opponent) // returns true if killing blow
        {
            RedisManager redis = new RedisManager();
            int damage = 0;

            switch (ClassName)
            {
                case "Barbarian":
                    if (RollAttack(opponent.ArmorClass))
                    {
                        int rage = 0;
                        if (redis.CheckIfEffectActive(isPlayer1, "Raging"))
                            rage = 2;
                        damage = RollDamage(1, 12, (int)Stat.Str, rage); // 1d12 + STR + 2(Rage damage if active)
                    }
                    break;
                case "Bard":
                    if (RollAttack(opponent.ArmorClass))
                        damage = RollDamage(1, 8, (int)Stat.Dex, 0); // 1d8 + DEX
                    break;
                case "Cleric":
                    if (!RollSpellSave((int)Stat.Wis, (int)Stat.Dex, opponent)) // 1d8(DEX Save)
                        damage = RollDie(8);
                    break;
                case "Druid":
                    if (RollAttack(opponent.ArmorClass))
                        damage = RollDamage(1, 8, (int)Stat.Wis, 0); // 1d8 + WIS
                    break;
                case "Fighter":
                    if (RollAttack(opponent.ArmorClass))
                        damage = RollDamage(2, 6, (int)Stat.Str, 0); // 2d6 + STR
                    break;
                case "Monk":
                    if (RollAttack(opponent.ArmorClass))
                        damage = RollDamage(1, 4, (int)Stat.Dex, 0); // 1d4 + DEX
                    break;
                case "Paladin":
                    if (RollAttack(opponent.ArmorClass))
                    {
                        int smite = 0;
                        if (redis.CheckIfEffectActive(isPlayer1, "Smiting"))
                        {
                            smite = RollDie(8);
                            //redis.DecrementResource(isPlayer1);
                            redis.RemoveEffect(isPlayer1, "Smiting");
                        }
                        damage = RollDamage(1, 8, (int)Stat.Str, smite); // 1d8 + STR
                    }
                    break;
                case "Ranger":
                    if (RollAttack(opponent.ArmorClass))
                    {
                        int mark = 0;
                        if (redis.CheckIfEffectActive(isPlayer1, "Marking"))
                            mark = RollDie(6);
                        damage = RollDamage(1, 8, (int)Stat.Dex, mark); // 1d8 + DEX
                    }
                    break;
                case "Rogue":
                    if (RollAttack(opponent.ArmorClass))
                    {
                        damage = RollDamage(1, 4, (int)Stat.Dex, RollDie(6)); // 1d4 + DEX + 1d6(Sneak Attack)
                        redis.DecrementResource(isPlayer1);
                    }
                    break;
                case "Sorcerer":
                    if (!RollSpellSave((int)Stat.Cha, (int)Stat.Con, opponent)) // 1d6(CON Save)
                        damage = RollDie(6);
                    break;
                case "Warlock":
                    if (RollAttack(opponent.ArmorClass))
                    {
                        int hex = 0;
                        if (redis.CheckIfEffectActive(isPlayer1, "Hexing"))
                            hex = RollDie(6);
                        damage = RollDamage(1, 10, (int)Stat.Cha, hex); // 1d10 + CHA
                    }
                    break;
                case "Wizard":
                    if (RollAttack(opponent.ArmorClass))
                        damage = RollDamage(1, 10, (int)Stat.Int, 0); // 1d10 + INT
                    break;
                default:
                    break;
            }

            redis.DecrementAction();

            bool over;
            if (damage != 0)
            {
                over = redis.ApplyDamage(isPlayer1, damage, Character.Name);
                if (over)
                {
                    //redis.MatchOver(); // Probably pass isPlayer
                    return true;
                }
            }

            return false;
        }

        public bool SecondaryAttack(bool isPlayer1, CharacterClass opponent) // returns true if killing blow
        {
            RedisManager redis = new RedisManager();
            int damage = 0;

            switch (ClassName)
            {
                case "Barbarian":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.ApplyEffect(isPlayer1, "Raging");
                        redis.DecrementResource(isPlayer1);
                        redis.AddToCombatLog(Character.Name + " goes into a rage, doing 2 extra damage on a successful hit!");
                    }
                    break;
                case "Bard":
                    if (redis.HasResource(isPlayer1) && redis.HasAction())
                    {
                        redis.DecrementResource(isPlayer1);
                        redis.AddToCombatLog(Character.Name + " used Hideous Laughter.");
                        if (!RollSpellSave((int)Stat.Cha, (int)Stat.Wis, opponent))
                        {
                            //redis.ApplyEffect(!isPlayer1, "Restrained");
                            redis.ApplyEffect(!isPlayer1, "Incapacitated");
                            redis.AddToCombatLog(opponent.Character.Name + " is incapacitated.");
                        }
                        redis.DecrementAction();
                    }
                    break;
                case "Cleric":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.DecrementResource(isPlayer1);
                        redis.HealDamage(isPlayer1, RollDamage(1, 4, (int)Stat.Wis, 3), this);
                    }
                    break;
                case "Druid":
                    if (redis.HasResource(isPlayer1) && redis.HasAction())
                    {
                        redis.DecrementResource(isPlayer1);
                        redis.AddToCombatLog(Character.Name + " used Entangle.");
                        if (!RollSpellSave((int)Stat.Wis, (int)Stat.Str, opponent))
                        {
                            redis.ApplyEffect(!isPlayer1, "Incapacitated");
                            redis.AddToCombatLog(opponent.Character.Name + " is incapacitated!");
                        }
                        else
                            redis.AddToCombatLog(opponent.Character.Name + " breaks through the vines, not being incapacitated!");
                        redis.DecrementAction();
                    }
                    break;
                case "Fighter":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.DecrementResource(isPlayer1);
                        redis.AddToCombatLog(Character.Name + " gathers their resolve, pushing past their injuries!");
                        redis.HealDamage(isPlayer1, RollDamage(1, 10, -1, 5), this);
                    }
                    break;
                case "Monk":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.AddToCombatLog(Character.Name + " focuses their Chi, striking with great speed!");
                        for (int i = 0; i < 2; i++)
                        {
                            if (RollAttack(opponent.ArmorClass))
                                damage = RollDamage(1, 4, (int)Stat.Dex, 0); // 1d4 + DEX
                        }
                        redis.DecrementResource(isPlayer1);
                    }
                    break;
                case "Paladin":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.ApplyEffect(isPlayer1, "Smiting");
                        redis.DecrementResource(isPlayer1);
                        redis.AddToCombatLog(Character.Name + "'s weapon glows with radiant energy! (Smite)");
                    }
                    break;
                case "Ranger":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.ApplyEffect(isPlayer1, "Marking");
                        redis.DecrementResource(isPlayer1);
                        redis.AddToCombatLog(Character.Name + " applies a Hunter's Mark on the opponent! Their attacks deal extra damage.");
                    }
                    break;
                case "Rogue":
                    if (RollAttack(opponent.ArmorClass))
                    {
                        int sneakAttack;
                        if (redis.HasResource(isPlayer1))
                        {
                            sneakAttack = RollDie(6);
                            redis.AddToCombatLog(Character.Name + " has the advantage of stealth, dealing extra damage with this attack!");
                        }
                        else sneakAttack = 0;
                        damage = RollDamage(1, 4, (int)Stat.Dex, sneakAttack); // 1d4 + DEX + 1d6(Sneak Attack)
                        redis.DecrementResource(isPlayer1);
                    }
                    break;
                case "Sorcerer":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.AddToCombatLog(Character.Name + " conjures up a bolt of chaotic energy!");
                        if (RollAttack(opponent.ArmorClass))
                            damage = RollDamage(2, 8, -1, RollDie(6)); // 2d8 + 1d6
                        redis.DecrementResource(isPlayer1);
                    }
                    break;
                case "Warlock":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.ApplyEffect(isPlayer1, "Hexing");
                        redis.DecrementResource(isPlayer1);
                        redis.AddToCombatLog(Character.Name + " hexes the opponent! Their attacks deal extra damage.");
                    }
                    break;
                case "Wizard":
                    if (redis.HasResource(isPlayer1))
                    {
                        redis.AddToCombatLog(Character.Name + " fires three magic missiles guaranteed to hit!");
                        damage = RollDamage(3, 4, -1, 3); // 3d4 + 3
                        redis.DecrementAction();
                        redis.DecrementResource(isPlayer1);
                    }
                    break;
                default:
                    break;
            }

            bool over;
            if (damage != 0)
            {
                over = redis.ApplyDamage(isPlayer1, damage, Character.Name);
                if (over)
                {
                    //redis.MatchOver(); // Probably pass isPlayer
                    return true;
                }
            }
            return false;
        }

    }
}
