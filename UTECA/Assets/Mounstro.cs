using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mounstro : MonoBehaviour
{
  [Header("ENEMIES")]
  public List<GameObject> Enemies;
  public Slider EnemyHealth;
  public int ActiveEnemy = 0;
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    var Enemy = Enemies[ActiveEnemy].GetComponent<Gasparin>();
    if (Enemy.health <=0)
    {
      ActiveEnemy++;
    }
    EnemyHealth.value = Enemy.health/100f;
  }
}
