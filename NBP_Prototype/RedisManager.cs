﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using System.IO;


namespace NBP_Prototype
{
    class RedisManager
    {
        readonly RedisClient redis = new RedisClient("localhost", 6379);

        #region Match Functions

        public void MatchStart(CharacterClass player1Class, CharacterClass player2Class)
        {
            redis.Set("player1HP", player1Class.MaxHealth);
            redis.Set("player2HP", player2Class.MaxHealth);

            redis.Set("player1Resource", player1Class.MaxResource);
            redis.Set("player2Resource", player2Class.MaxResource);

            redis.Set("action", 1);

            //redis.Set("player1Class", player1Class);
            //redis.Set("player2Class", player2Class);

            redis.AddItemToSortedSet("damageTracker", player1Class.Character.Name, 0);
            redis.AddItemToSortedSet("damageTracker", player2Class.Character.Name, 0);

            redis.RemoveAllFromList("combatLog");
            redis.PushItemToList("combatLog", "Round started. Fight!");

            // redis.Set<bool>("matchInProgress", true);
        }

        public void SetTurn(bool isPlayer1sTurn)
        {
            redis.Set("player1sTurn", isPlayer1sTurn);
        }

        public bool GetTurn()
        {
            return redis.Get<bool>("player1sTurn");
        }

        /*
        public bool MatchIsInProgress()
        {
            return redis.Get<bool>("matchInProgress");
        }
        */

        public void MatchOver()
        {
            //redis.Set("matchInProgress", false);
            redis.FlushDb();
        }

        #endregion

        #region Health (Damage/Heal)

        public int GetHP(bool isPlayer1)
        {
            string player;
            if (isPlayer1)
                player = "player1HP";
            else player = "player2HP";

            return redis.Get<int>(player);
        }

        public bool ApplyDamage(bool isPlayer1, int damage, string characterName)
        {
            string opponent;
            if (isPlayer1)
                opponent = "player2HP";
            else opponent = "player1HP";

            int hp = redis.Get<int>(opponent); // Get opponents HP before damage
            hp -= damage;
            if (hp < 0)
                hp = 0;
            redis.Set(opponent, hp); // HP after taking damage
            AddToCombatLog(characterName + " has dealt " + damage + " damage.");
            DamageTracker(characterName, damage);
            if (hp == 0)
                return true;
            else return false;
        }

        public void HealDamage(bool isPlayer1, int healAmount, CharacterClass characterClass)
        {
            string player;
            if (isPlayer1)
                player = "player1HP";
            else player = "player2HP";

            int hp = redis.Get<int>(player);
            hp += healAmount;
            if (hp > characterClass.MaxHealth)
                hp = characterClass.MaxHealth;
            redis.Set(player, hp);
            AddToCombatLog(characterClass.Character.Name + " healed themselves for " + healAmount + " hitpoints.");
        }

        #endregion

        #region Resource

        public int GetResource(bool isPlayer1)
        {
            string player;
            if (isPlayer1)
                player = "player1Resource";
            else player = "player2Resource";

            return redis.Get<int>(player);
        }

        public bool HasResource(bool isPlayer1)
        {
            if (GetResource(isPlayer1) > 0)
                return true;
            else return false;
        }

        public void DecrementResource(bool isPlayer1)
        {
            if (isPlayer1)
            {
                if (redis.Get<int>("player1Resource") > 0)
                    redis.DecrementValue("player1Resource");
            }
            else if (redis.Get<int>("player2Resource") > 0)
                redis.DecrementValue("player2Resource");
        }

        public void IncrementResource(bool isPlayer1)
        {
            if (isPlayer1)
            {
                if (redis.Get<int>("player1Resource") < 1)
                    redis.IncrementValue("player1Resource");
            }
            else if (redis.Get<int>("player2Resource") < 1)
                redis.IncrementValue("player2Resource");
        }

        #endregion

        #region Effects

        public void ApplyEffect(bool toPlayer1, string effect)
        {
            string player;
            if (toPlayer1)
                player = "player1Effects";
            else player = "player2Effects";

            redis.AddItemToSet(player, effect);
        }

        public void RemoveEffect(bool isPlayer1, string effect)
        {
            string player;
            if (isPlayer1)
                player = "player1Effects";
            else player = "player2Effects";

            redis.RemoveItemFromSet(player, effect);
        }

        public bool CheckIfEffectActive(bool isPlayer1, string effect) // Checks if a player has a certain buff or debuff (effect)
        {
            string effects;
            if (isPlayer1)
                effects = "player1Effects";
            else
                effects = "player2Effects";
            return redis.SetContainsItem(effects, effect); // Does the player have the passed effect in redis set
        }

        #endregion

        #region Action

        public int GetAction()
        {
            return redis.Get<int>("action");
        }

        public bool HasAction()
        {
            if (GetAction() == 1)
                return true;
            else return false;
        }

        public void DecrementAction()
        {
            if (GetAction() == 1)
                redis.DecrementValue("action");
        }

        public void IncrementAction()
        {
            if (GetAction() == 0)
                redis.IncrementValue("action");
        }

        #endregion

        #region Combat Log

        public void AddToCombatLog(string text)
        {
            redis.PushItemToList("combatLog", text);
        }

        public string GetCombatLog()
        {
            string output = "";
            List<string> list = redis.GetAllItemsFromList("combatLog");
            foreach (string item in list)
            {
                output += item + Environment.NewLine;
            }
            return output;
        }

        #endregion

        #region Damage Tracker

        public void DamageTracker(string characterName, int damage)
        {
            int oldDamage = (int)redis.GetItemScoreInSortedSet("damageTracker", characterName);
            redis.AddItemToSortedSet("damageTracker", characterName, oldDamage + damage);
        }

        public IDictionary<string, double> GetDamageTracker()
        {
            // return redis.GetAllWithScoresFromSortedSet("damageTracker");
            return redis.GetRangeWithScoresFromSortedSetDesc("damageTracker", 0, -1);
        }

        #endregion

    }
}
