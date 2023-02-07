using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardUI : MonoBehaviour
{
  public TMP_Text Name;
  public TMP_Text value;
  public TMP_Text type; // Un enum
  public Sprite image;
  public Button playBtn;

  private Card card;

  public void SetUp(Card newCard)
  {
    card = newCard;

    Name.text = card.name;
    value.text = "Value: " + card.value.ToString();
    type.text = "Type: " + card.type;
    image = card.image;

    playBtn.onClick.AddListener(PlayCard);
  }

  void PlayCard()
  {
    FindObjectOfType<CardUIManager>().PlayCard(card);
  }
}
