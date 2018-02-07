using System.Collections.Generic;
using System;

namespace Tamagotchis.Models
{
    public class Tama
    {
        private string _name;
        private int _food;
        private int _play;
        private int _sleep;
        private bool _dead;

        public Tama(string name)
        {
          _name = name;
          _food = 80;
          _play = 80;
          _sleep = 80;
          _dead = false;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }

        public int GetFood()
        {
            return _food;
        }
        public void SetFood(int newFood)
        {
            _food = newFood;
        }

        public int GetPlay()
        {
            return _play;
        }
        public void SetPlay(int newPlay)
        {
            _play = newPlay;
        }

        public int GetSleep()
        {
            return _sleep;
        }
        public void SetSleep(int newSleep)
        {
            _sleep = newSleep;
        }

        public int GetDead()
        {
            return _dead;
        }
        public void SetDead(bool newDead)
        {
            _dead = newDead;
        }

        public void CheckIfDead()
        {
            if (_food <= 0 || _sleep <= 0 || _play <= 0)
            {
                _dead = true;
            }
            else
            {
                _dead = false;
            }
        }

        public void FeedTamagotchi()
        {
            _food += 15;
            _play -= 10;
            _sleep -= 10;
        }

        public void PlayTamagotchi()
        {
            _play += 15;
            _food -= 10;
            _sleep -= 10;
        }

        public void SleepTamagotchi()
        {
            _sleep += 15;
            _food -= 10;
            _play -= 10;
        }

        public void WaitTamagotchi()
        {
            _sleep -= 10;
            _food -= 10;
            _play -= 10;
        }

        public void CheckIfOverHundred()
        {
            if (_food > 100)
            {
                _food = 100;
            }
            if (_sleep > 100)
            {
                _sleep = 100;
            }
            if (_play > 100)
            {
                _play = 100;
            }
        }
    }
}
