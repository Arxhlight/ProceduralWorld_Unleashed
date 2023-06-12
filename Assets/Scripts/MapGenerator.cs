using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    /**
     This Script just handels the generator of the noiseMap. It creates the noisemap with a width, hegight and scale. Then sets display as a display script in the editor of unity.
    Then it draws the noisemap we created in the editor with our width, height and scale. 
     */

    public int mapWidth;
    public int mapHeight;
    public float noiseScale;
    public bool autoUpdate;

    public void GenerateMap()
    {
        float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, noiseScale);

        MapDisplay display = FindObjectOfType<MapDisplay>();

        display.DrawNoiseMap(noiseMap);
    }

}
