using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    /**
    In this script we create a color array and get the width and height from our mapGenerate noiseMap. The color array checks the width and height 
    lerps the black and white colors along with the noisemaps width and height. So for each Row and Element in the 2 dimensional noiseMap we set a new color for every pixel.
     */

    public Renderer textureRenderer;

    public void DrawNoiseMap(float[,] noiseMap)
    {
        int width = noiseMap.GetLength(0);
        int height = noiseMap.GetLength(1);

        Texture2D texture = new Texture2D(width, height);

        Color[] colorArr = new Color[width * height];   
        for (int y = 0; y < height; y++) {
            for(int x = 0; x < width; x++) {
                colorArr[y * width + x] = Color.Lerp(Color.black, Color.white, noiseMap[x, y]);  // Add random generation here?
            }
        }
        texture.SetPixels(colorArr);
        texture.Apply();

        textureRenderer.sharedMaterial.SetTexture("_UnlitColorMap", texture);
        textureRenderer.transform.localScale = new Vector3(width, 1, height);
    }
}
