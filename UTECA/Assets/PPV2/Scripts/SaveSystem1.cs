using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SaveSystem1 : MonoBehaviour
{
  public string filePath;
  public Vector3 lastPos;
  StreamWriter m_writer;
  void CreateFile()
  {
    string path = Application.dataPath + "/Log.txt";
    // Crear el archivo revisando que no exista uno anteriormente
    if (!File.Exists(path))
    {
      File.WriteAllText(path, "Log \n\n");
    }
    else
    {
      Debug.Log("A File already exist");
      return;
    }
    // Contenido del archivo
    string content = "Login date: " + System.DateTime.Now + "\n";
    // Agregar la informacion al archivo
    File.AppendAllText(path, content);
  }

  // Start is called before the first frame update
  void Start()
  {
    //CreateFile();
    //SavePosition();
    //GetPosition();

    filePath = Application.dataPath + "/Logs/position2.txt";
    // Store the last postion of the object(Initial Position)
    lastPos = transform.position;
    m_writer = new StreamWriter(filePath);
  }

  private void Update()
  {
    SavePostionInMovement();
  }

  public void SavePosition()
  {
    string path = Application.dataPath + "/position.txt";
    if (File.Exists(path))
    {
      File.Delete(path);
    }

    StreamWriter writer = new StreamWriter(path);

    // Set the position of the object in the file
    writer.WriteLine(transform.position.x + "," + transform.position.y + "," + transform.position.z);

    // close StreamWriter
    writer.Close();
  }

  public void GetPosition()
  {
    string path = Application.dataPath + "/position.txt";
    StreamReader reader = new StreamReader(path);

    string line = reader.ReadLine();
    string[] values = line.Split(',');

    // Convert the string values into position of a new vec3
    Vector3 newPos = new Vector3(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]));

    // Set the new Position into the object
    transform.position = newPos;

    // Close the Stream reader
    reader.Close();
  }

  public void SavePostionInMovement()
  {
    // Check if the objecto has move since the last frame
    if (transform.position != lastPos)
    {
      // Set the position of the object in the file
      m_writer.WriteLine(transform.position.x + "," + transform.position.y + "," + transform.position.z);
      Debug.Log("The current position" + transform.position + " has been saved.");
      // store the current position of the object
      lastPos = transform.position;
    }
  }

  private void OnDestroy()
  {
    if (m_writer != null)
    {
      m_writer.Close();
    }
  }
}
