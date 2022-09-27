using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
  public int edad = 23;
  public float velocidad = 4.5f;
  public bool hasPowers = false;
  private string Name = "Roberto";
  int multiFactor = 2;
  int counter = 0;
  bool CounterIsGraterThanFive = false;
  int level = 1;


  // Start is called before the first frame update
  void Start()
  {
    name = Name;

    float result = velocidad * multiFactor;
  }

  // Update is called once per frame
  void Update()
  {
    if (level == 1)
    {
      // Basic Power
    }
    
    if (level == 5)
    {
      // Mid Power
    }
    
    if (level == 10)
    {
      // Advance Power
    }


    if (counter >= 5 && CounterIsGraterThanFive == false)
    {
      CounterIsGraterThanFive = true;
    }

    if (CounterIsGraterThanFive == true)
    {
      activateComboAnimation();
    }
  }


  public void activateComboAnimation()
  {

  }
}
