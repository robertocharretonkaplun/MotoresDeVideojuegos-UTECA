using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Actions
{
  IDLE,
  MOVE_LEFT,
  MOVE_RIGHT,
  FIGHT,
  ATTACK1,
  COVER
}

public class Enemy : MonoBehaviour
{
  public static Enemy instance;
  public int damge = 10;
  public int randomAction = 0;
  public Actions actions;
  public int health = 100;

  void Awake()
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
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnTriggerStay2D(Collider2D collision)
  {

  }
  
  public void ApplyDamage()
  {
    health -= 20;
  }

  IEnumerator Attack1(GameObject player)
  {
    Debug.Log("Enemy Attacking");
    player.gameObject.GetComponent<ColliderScript>().health -= 20;
    player.gameObject.GetComponent<Renderer>().material.color = Color.red;
    yield return new WaitForSeconds(.5f);
    actions = Actions.ATTACK1;
    Debug.Log("Enemy Attack:" + actions);
    player.gameObject.GetComponent<Renderer>().material.color = Color.white;
    LevelManagerLevelOne.instance.EnemyScoreValue += 1;
    LevelManagerLevelOne.instance.UpdateScore();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("Player"))
    {
      randomAction = Random.Range(0, 5);
      actions = (Actions)randomAction;
      switch (randomAction)
      {
        case 0:
          //GetComponent<Renderer>().material.color = new Color(0, 1, 1);
          Debug.Log("Enemy: IDLE");
          break;
        case 1:
          //GetComponent<Renderer>().material.color = new Color(0, 1, 1);
          Debug.Log("Enemy: Move left");
          break;
        case 2:
          Debug.Log("Enemy: Move Right");
          //GetComponent<Renderer>().material.color = new Color(0, 1, 0);
          break;
        case 3:
          if (LevelManagerLevelOne.instance.EneableEnemyAttacks == true)
          {
            // Ataques
          }
          else
          {
            // No hay ataques
            Debug.Log("Enemy: No hay daño");
          }
          //GetComponent<Renderer>().material.color = new Color(0, 0, 1);
          break;
        case 4:
          if (LevelManagerLevelOne.instance.EneableEnemyAttacks == true)
          {
            // Ataques
            StartCoroutine(Attack1(collision.gameObject));
            //Debug.Log("Enemy: Cover");
          }
          else
          {
            // No hay ataques
            Debug.Log("Enemy: No hay daño");
          }
          break;
        default:
          break;
      }
    }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (Input.GetKey(KeyCode.I))
    {
      randomAction = Random.Range(0, 5);
      actions = (Actions)randomAction;
      switch (randomAction)
      {
        case 0:
          //GetComponent<Renderer>().material.color = new Color(0, 1, 1);
          Debug.Log("IDLE");
          break;
        case 1:
          //GetComponent<Renderer>().material.color = new Color(0, 1, 1);
          Debug.Log("Move left");
          break;
        case 2:
          Debug.Log("Move Right");
          //GetComponent<Renderer>().material.color = new Color(0, 1, 0);
          break;
        case 3:
          if (LevelManagerLevelOne.instance.EneableEnemyAttacks == true)
          {
            // Ataques
            Debug.Log("Ataque 3");
          }
          else
          {
            // No hay ataques
            Debug.Log("No hay daño");
          }
          //GetComponent<Renderer>().material.color = new Color(0, 0, 1);
          break;
        case 4:
          if (LevelManagerLevelOne.instance.EneableEnemyAttacks == true)
          {
            // Ataques
            Debug.Log("Cover");
          }
          else
          {
            // No hay ataques
            Debug.Log("No hay daño");
          }
          break;
        default:
          break;
      }
    }


  }
}
