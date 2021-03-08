﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logic_games.Games.Battleship
{
    public class Ship
    {
        public int size, direction, X, Y, HP;
        public Image[] components;

        public void dir(int diff) 
        {
            direction += diff;
            if (direction < 0) { direction = 270; }
            else if (direction == 360) { direction = 0; }
        }
        public Ship(int siz, Image[] images, bool random) 
        {
            size = siz;
            direction = 90;
            HP = siz;
            components = images;
            if (random) 
            {
                Random r = new Random();
                dir(r.Next(-4, 4) * 90);
            }
        }
        public void placeShip(TableLayoutPanel board, int[,] placement) 
        {
            Image img;
            void Place(int x, int y)
            {
                placement[x, y] = 1;
                PictureBox cell = (PictureBox)board.GetControlFromPosition(x + 1, y + 1);
                cell.BackgroundImage = img;
                phase1.RotatedImage(img, direction);
            }
            if (direction == 90 || direction == 270)
            {
                int j = direction == 90 ? 1 : -1;
                for (int i = 0; i < size; i++)
                {
                    img = components[i];
                    Place(X + (j * i), Y);
                }
            }
            else
            {
                int j = direction == 180 ? 1 : -1;
                for (int i = 0; i < size; i++)
                {
                    img = components[i];
                    Place(X, Y + (j * i));
                }
            }
        }
        public void placeShip(int[,] placement) 
        {
            if (direction == 90 || direction == 270)
            {
                int j = direction == 90 ? 1 : -1;
                for (int i = 0; i < size; i++)
                {
                    placement[X + (j * i), Y] = 1;
                }
            }
            else
            {
                int j = direction == 180 ? 1 : -1;
                for (int i = 0; i < size; i++)
                {
                    placement[X, Y + (j * i)]=1;
                }
            }
        }
    }
}