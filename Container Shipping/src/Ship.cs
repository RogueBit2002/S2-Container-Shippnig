﻿using System.Collections;
using System.Data.Common;

namespace LaurensKruis.ContainerShipping
{
    public class Ship
    {
        private Container[][] grid;

        private int width;
        private int height;

        public int Width => width;
        public int Height => height;

        public Ship(int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Ship capacity should be atleast 1");
            this.width = width;
            this.height = height;

            grid = new Container[width][];
            for(int x = 0; x < width; x ++)
                grid[x] = new Container[height];

        }

        public Container this[int x, int y]
        {
            get => grid[x][y];
            internal set => grid[x][y] = value;
        }
    }
}