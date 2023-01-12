using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
  protected string Name = "Enemy";
  protected int Health = 100;
  protected List<string> Loot;

  public virtual void Init()
  {
    Loot = new List<string>();
  }

  public virtual void AddLoot(string Item)
  {
    Loot.Add(Item);
  }

  public virtual List<string> GetLoot()
  {
    return Loot;
  }

  public virtual int GetHealth()
  {
    return Health;
  }
}

public class Enemigo : EnemyBase
{
  public override void Init()
  {
    base.Init();
  }

  public override int GetHealth()
  {
    return base.GetHealth();
  }

  public override List<string> GetLoot()
  {
    return base.GetLoot();
  }

  public override void AddLoot(string Item)
  {
    base.AddLoot(Item);
    
  }

  // Start is called before the first frame update
  void Start()
  {
    Init();

    AddLoot("Sword");
    AddLoot("Shield");
    AddLoot("Gold");

    // Print the loot 
    for (int i = 0; i < GetLoot().Count; i++)
    {
      Debug.Log(GetLoot()[i]);
    }


  }

  void Update()
  {
  }
}
