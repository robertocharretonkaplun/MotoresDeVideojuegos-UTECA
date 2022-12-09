using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBox : MonoBehaviour
{
  public bool IsInteracting = false;
  public GameObject dollar;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.E))
    {
      IsInteracting = true;
    }
    else
    {
      //IsInteracting = false;
    }
  }

  public void Interact()
  {
    if (IsInteracting == true)
    {
      IsInteracting = false;
    }
    else
    {
      IsInteracting = true;
    }

    dollar.SetActive(IsInteracting);
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {


  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
  }
}
