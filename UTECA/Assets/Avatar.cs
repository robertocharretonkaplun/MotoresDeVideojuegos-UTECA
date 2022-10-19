using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Avatar : MonoBehaviour
{
  public int AvatarIndex = 0;
  public List<AvatarAttributes> Avatars;
  public TMP_Text Name;
  public TMP_Text Desc;
  public TMP_Text XP;
  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    Name.text = Avatars[AvatarIndex].Name;
    Desc.text = "Information: " + Avatars[AvatarIndex].Description;
    XP.text = Avatars[AvatarIndex].XP.ToString() + "XP";

  }
}
