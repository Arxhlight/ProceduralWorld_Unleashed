using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise 
{
    /**
     In this class i use a public static float [,] GenerationNoiseMap as a multidimensional array
    that has a withd and hegiht (with = row, hegith = colums). As this Noise class isnt used in the Editor 
    of Unity i dont need the class to have Monobehaviour. And static bcs it wont need any instancing. 

     */

   public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale)
    {
        float[,] noiseMap = new float[mapWidth, mapHeight];

        if (scale <= 0)
        {
            scale = Mathf.Clamp(scale, float.Epsilon, float.MinValue);
        }

       
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapHeight; x++)
            {
                float sampleX = x  / scale;
                float sampleY = y  / scale;

                float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);
                noiseMap[x, y] = perlinValue;
            }
           

        }

        return noiseMap;
    }
}
