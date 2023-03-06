using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerActions
{
  IDLE,
  MOVE_LEFT,
  MOVE_RIGHT,
  FIGHT,
  ATTACK_1,
  COVER
}
public class ColliderScript : MonoBehaviour
{
  public int health = 100;
  public float speed = 7f;
  private float XLimit = 3.5f;
  public PlayerActions PlayerAction;
  public bool IsInAreaOfAttack = false;
  public GameObject EnemyRef;
  // 0 Golpe
  // 1 Moverse 3 pixeles a la Izquierda
  // 2 Moverse 3 pixeles a la Derecha

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float x = Input.GetAxisRaw("Horizontal");
    Vector2 BarPos = transform.position;

    BarPos.x = Mathf.Clamp(BarPos.x + x * speed * Time.deltaTime, -XLimit, XLimit);

    transform.position = BarPos;

    if (IsInAreaOfAttack)
    {

      Fight();
    }
    //Fight();
  }

  IEnumerator Attack1(GameObject player)
  {
    Debug.Log("Player Attacking");
    Enemy.instance.GetComponent<Renderer>().material.color = Color.cyan;
    PlayerAction = PlayerActions.ATTACK_1;
    Enemy.instance.ApplyDamage();
    yield return new WaitForSeconds(1f);
    Debug.Log("Player Attack:" + PlayerAction);
    Enemy.instance.GetComponent<Renderer>().material.color = Color.red;
    IsInAreaOfAttack = false;
  }

  public void Fight()
  {
    if (Input.GetKey(KeyCode.Q))
    {
      PlayerAction = PlayerActions.MOVE_LEFT;
      Debug.Log("Gancho Izquierdo");
    }
    if (Input.GetKey(KeyCode.E))
    {
      PlayerAction = PlayerActions.ATTACK_1;
      //Debug.Log("Gancho Derecho");
      StartCoroutine(Attack1(Enemy.instance.gameObject));
    }
    if (Input.GetKey(KeyCode.R))
    {
      PlayerAction = PlayerActions.COVER;
      Debug.Log("Upercut");
    }
  }

  private void OnTriggerStay2D(Collider2D collision)
  {
    if (collision.gameObject.CompareTag("Enemy"))
    {
      //IsInAreaOfAttack = true;
      EnemyRef = Enemy.instance.gameObject;
      Fight();
    }
  }


}
