using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
  protected string ssn = "444-55-6666";
  protected string Name = "John L. Malgraine";

  public virtual void GetInfo()
  {
    Debug.Log("Name: " + Name);
    Debug.Log("SSN: " + ssn);
  }
}

public class ClaseBaseYClaseDerivada : Person
{
  public string id = "ABC567EFG";
  public override void GetInfo()
  {
    // Calling the base class GetInfo method:
    base.GetInfo();
    Debug.Log("Employee ID: " + id);
  }
  // Start is called before the first frame update
  void Start()
  {
    GetInfo();
  }
}
