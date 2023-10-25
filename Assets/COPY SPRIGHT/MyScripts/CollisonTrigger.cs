using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonTrigger : MonoBehaviour
{
  public Dialogue dialogue;
  //public GameObject button;

  public void OnCollisionEnter2D(Collision2D collision)
  {
    if(collision.gameObject.CompareTag("Player"))
    {
       // button.SetActive(true);
      FindObjectOfType<LevelManager>().StartDialogue(dialogue);
      
    }
  }
}
