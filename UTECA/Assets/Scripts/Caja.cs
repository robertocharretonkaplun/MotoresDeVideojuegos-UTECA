using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja : MonoBehaviour
{
  public Player player;
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    if (player.TenemosLaLlave == true)
    {
      Debug.Log("El jugador tiene la llave :D");
      gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }
    else
    {
      Debug.Log("El jugador no tiene la llave :(");
      gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
    }
  }
}
