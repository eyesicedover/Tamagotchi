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
        private int _id;

        private static List<Tama> _instances = new List<Tama> {};

        public Tama(string name)
        {
            Random rnd = new Random();
            _name = name;
            _food = rnd.Next(40, 80);
            _play = rnd.Next(40, 80);
            _sleep = rnd.Next(40, 80);
            _dead = false;
            _id = _instances.Count;
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

        public bool GetDead()
        {
            return _dead;
        }

        public void SetDead(bool newDead)
        {
            _dead = newDead;
        }

        public void Save()
        {
            _instances.Add(this);
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Tama> GetAll()
        {
            return _instances;
        }

        public int GetId()
        {
            return _id;
        }

        public static Tama Find(int searchId)
        {
            return _instances[searchId-1];
        }

        public static void RemoveByIdAndReassignIds(int id)
        {
            for (int index = 0; index < _instances.Count; index++)
            {
                  if (_instances[index].GetId() == id)
                  {
                      _instances.RemoveAt(index);
                  }
            }
            for (int j = 0; j < _instances.Count; j++)
            {
                _instances[0]._id = j+1;
            }
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
            _food += 25;
            _play -= 10;
            _sleep -= 10;
        }

        public void PlayTamagotchi()
        {
            _play += 25;
            _food -= 10;
            _sleep -= 10;
        }

        public void SleepTamagotchi()
        {
            _sleep += 25;
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

        public static void CycleFeedTamas()
        {
            for (int index = 0; index < _instances.Count; index++)
            {
                _instances[index].FeedTamagotchi();
                _instances[index].CheckIfOverHundred();
                _instances[index].CheckIfDead();
            }
        }

        public static void CyclePlayTamas()
        {
            for (int index = 0; index < _instances.Count; index++)
            {
                _instances[index].PlayTamagotchi();
                _instances[index].CheckIfOverHundred();
                _instances[index].CheckIfDead();

            }
        }

        public static void CycleSleepTamas()
        {
            for (int index = 0; index < _instances.Count; index++)
            {
                _instances[index].SleepTamagotchi();
                _instances[index].CheckIfOverHundred();
                _instances[index].CheckIfDead();
              }
        }

        public static void CycleWaitTamas()
        {
            for (int index = 0; index < _instances.Count; index++)
            {
                _instances[index].WaitTamagotchi();
                _instances[index].CheckIfOverHundred();
                _instances[index].CheckIfDead();
            }
        }

    }
}
