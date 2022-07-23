using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string name;
        private int level;

        public Hero(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Level
        {
            get => this.level;
            set => this.level = value;
        }

    }
}
