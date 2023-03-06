using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SearchOnDirectory : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    foreach (string file in Directory.GetFiles("Assets/Logs"))
    {
      Debug.Log(file);
      string[] content = file.Split('.');
      if (content.Length < 3 && content[1] == "txt")
      {
        StreamReader reader = new StreamReader(file);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
      }
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
