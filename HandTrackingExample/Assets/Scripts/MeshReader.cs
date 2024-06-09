using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

using System.Linq;
using MeshElementData;

public class MeshReader : MonoBehaviour
{
    public MeshData data;

    public void GetJsonFromFilePath(string filePath)
    {
        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Read the content of the JSON file
            string jsonContent = File.ReadAllText(filePath);

            // Deserialize JSON into an object
            data = JsonConvert.DeserializeObject<MeshData>(jsonContent);
        }
        else
        {
            
            Debug.LogError("JSON file not found!");
        }
    }

    public void GetDataFromString(string jsonContent)
    {
        // Check if the file exists
        if (jsonContent!=null)
        {
            // Deserialize JSON into a dynamic object
            data = JsonConvert.DeserializeObject<MeshData>(jsonContent);
        }
        else
        {
            Debug.LogError("JSON file not found!");
        }
    }


}