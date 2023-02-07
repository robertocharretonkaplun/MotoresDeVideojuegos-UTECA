using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public static Player instance;

  public int health;
  public int money;
  public int level;
  public int xp;

  private void Awake()
  {
    if (instance != null)
    {
      return;
    }
    else
    {
      instance = this;
    }
  }

  public void Start()
  {
    health = 100;
    money = 1000;
    level = 1;
    xp = 0;
  }

  public void TakeDamage(int damage)
  {
    health -= damage;
    if (health <= 0)
    {
      Debug.Log("The player has died!");
    }
  }

  public void EarnMoney(int amount)
  {
    money += amount;
  }

  public void SpendMoney(int amount)
  {
    money -= amount;

    if (money < 0)
    {
      Debug.Log("Not Enough Money!");
    }
  }
}
