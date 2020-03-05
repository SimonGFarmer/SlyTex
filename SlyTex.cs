using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class SlyTex 
{
    public static Texture2D GetTexture2D(int width, int height)
    {
        Texture2D texture2D = new Texture2D(width, height);
        Color[] colors = new Color[width * height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int index = x + (y * width);
                colors[index] = Color.clear; // default color is clear
            }
        }
        texture2D.SetPixels(colors);
        texture2D.Apply();
        return texture2D;
    }

    public static Texture2D GetTexture2D(int width, int height, Color color)
    {
        Texture2D texture2D = new Texture2D(width, height);
        Color[] colors = new Color[width * height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int index = x + (y * width);
                colors[index] = color;
            }
        }
        texture2D.SetPixels(colors);
        texture2D.Apply();
        return texture2D;
    }

    public static Sprite GetSprite(Texture2D texture2D)
    {
        return Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
    }

}
