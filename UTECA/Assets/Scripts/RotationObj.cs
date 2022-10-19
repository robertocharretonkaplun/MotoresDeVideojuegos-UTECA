using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj : MonoBehaviour
{
  public Vector3 rot;
  public float speed = 40f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    if (Input.GetKey(KeyCode.Q))
    {
      rot.z *= -1;
      transform.Rotate(rot * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.E))
    {
      rot.z *= 1;
      transform.Rotate(rot * speed * Time.deltaTime);
    }

  }
}
