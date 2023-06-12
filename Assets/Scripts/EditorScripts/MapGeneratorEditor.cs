using System.Collections;

using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()    {

        /**
         This scripts overrides the Editor GUI. So that we can check things without hitting play. 
         */

        MapGenerator mapGen = (MapGenerator) target;

        //DrawDefaultInspector();

        if (DrawDefaultInspector())  // If any value is changed, generate the map. Live in edior.
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }

        if (GUILayout.Button("Generate"))        {
            mapGen.GenerateMap();
        }

        //base.OnInspectorGUI();
    }
}
