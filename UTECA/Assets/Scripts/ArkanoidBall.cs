using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBall : MonoBehaviour
{
  private Rigidbody2D RB;
  public float velocity = 4f;
  // Start is called before the first frame update
  void Start()
  {
    RB = GetComponent<Rigidbody2D>();
    int x = Random.Range(0, 2) == 0 ? -1 : 1;
    RB.velocity = new Vector2(x, 1) * velocity;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
