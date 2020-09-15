using System;
using System.Collections.Generic;
using System.Text;

namespace GadeTask1
{
    class Map
    {
        //Question 3.1 : This is the Map class that contains : 
        //          A 2D Tile array to represent the map.
        //          A Hero object to represent the player character.
        //          An Enemy array for the enemies.
        //          Variables for storing the map’s width and height.
        //          A Random object for randomising numbers.

        protected Tile[,] mapArray = new Tile[10, 10];
        protected Enemy[] numEnemies;
        protected Hero newHero = new Hero();
        protected int mapWidth;
        protected int mapHeight;
        protected Random random = new Random();

        public Map (int minWidth, int maxWidth, int minHeight, int maxHeight, int numberEnemies)
        {
            int mapWidth = random.Next(minWidth, maxWidth);
            int mapHeight = random.Next(minHeight, maxHeight);

            mapArray = new Tile[mapWidth, mapHeight];
            numEnemies = new Enemy[(mapWidth + mapHeight) / 3];
            UpdateVision();
            newHero = Create();
        }

        public void UpdateVision()
        {

        }

        private Tile Create(Tile.TileType type)
        {
            Tile tempTile = null;
            switch (type)
            {
                case Tile.TileType.Hero:
                    tempTile = new Hero();
                    break;
                case Tile.TileType.Enemy:
                    tempTile = new Enemy();
                    break;
                case Tile.TileType.Gold:
                    break;
                case Tile.TileType.Weapon:
                    break;

            }

            int randomX = random.Next(mapWidth);
            int randomY = random.Next(mapHeight);
            return tempTile;
        }
    }
}
