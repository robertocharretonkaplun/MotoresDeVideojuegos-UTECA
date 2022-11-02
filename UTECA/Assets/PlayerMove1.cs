using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum MOVEMENT
{
  NULL,
  LEFT,
  RIGTH
}

public class PlayerMove1 : MonoBehaviour
{
  private Rigidbody2D RB;
  public float speed = 3f;
  public bool Movement = false;
  public MOVEMENT MoveState;
  // Start is called before the first frame update
  void Start()
  {
    RB = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      Movement = true;
      MoveState = MOVEMENT.LEFT;
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      Movement = true;
      MoveState = MOVEMENT.RIGTH;
    }
    else
    {
      Movement = false;
      MoveState = MOVEMENT.NULL;
    }
  }

  private void FixedUpdate()
  {
    if (MoveState == MOVEMENT.LEFT)
    {
     RB.AddForce(new Vector2(-speed, 0));
    }
    else if (MoveState == MOVEMENT.RIGTH)
    {
     RB.AddForce(new Vector2(speed, 0));
    }
    else 
    {
     // RB.velocity = new Vector2(0, 0);
    }
  }
}
