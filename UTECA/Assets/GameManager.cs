using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  
  public GameObject MainMenu;
  public GameObject cube;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    

    if (Input.GetKey(KeyCode.Space))
    {
      MainMenu.SetActive(false);
      //Time.timeScale = 0; // Parar el juego
      Time.timeScale = 1; // Ejecutar el juego
    }

    if (Time.timeScale == 1)
    {
      var point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      point.z = 0f;
      cube.transform.position = point;

    }
  }
}
