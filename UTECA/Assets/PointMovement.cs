using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMovement : MonoBehaviour
{
  public float speed = 2f;
  public Vector2 Target;
  public Vector3 Offset;
  public float AreaOfSight = 5f;
  public float AreaOfAttack = 10f;
  // Start is called before the first frame update
  private void Awake()
  {
    Target = new Vector2(-4, Offset.y);
  }

  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    if (Input.GetMouseButtonDown(0))
    {
      Target = new Vector2(mousePos.x, Offset.y);
    }
    transform.position = Vector2.MoveTowards(transform.position, Target, speed * Time.deltaTime );
  }

  private void OnDrawGizmosSelected()
  {
    if (Vector3.Distance(Target, transform.position) <= AreaOfSight)
    {

    }
    Gizmos.color = Color.green;
    Gizmos.DrawWireSphere(transform.position, AreaOfSight);
    
    
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, AreaOfAttack);

  }
}
