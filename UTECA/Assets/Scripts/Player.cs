using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
 * 
public class Player : MonoBehaviour
{
  // Variables Globales
  public float velocidad = 4.5f;
  public int health = 100;

  // Inventario
  public bool TenemosLaLlave = false;

  public TMP_Text myTexto;
  
  // Start is called before the first frame update
  void Start()
  {
    myTexto.text = "wow esto es un texto";

    Debug.Log(myTexto);
    // >  | Mayor
    // <  | Menor
    // == | igual
    // != | Diferentes
    // >= | Mayor o igual que
    // <= | Menor o igual que

    if (velocidad >= 5)
    {
      Debug.Log("Excediste el limite de velocidad");
      // Cambiar color
      gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }
    else
    {

    }
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.R))
    {
      SetHealth(80);
    }
    
    if (Input.GetKey(KeyCode.Alpha0))
    {
      SetHealth(100);
    }

  }

  public Vector3 GetPlayerPositon()
  {
    return transform.position;
  }

  public void SetHealth(int _health)
  {
    health = _health;
    Debug.Log("Vida Actual: " + health);
  }

  public void ApplyDamage(int _health)
  {
    health = health -_health;
    Debug.Log("Se aplico Daño: " + health);
  }
}


*/