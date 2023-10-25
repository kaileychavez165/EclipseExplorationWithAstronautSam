using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Moon_Trigger : MonoBehaviour {
public GameObject textBox;
public Dialogue dialogue;

  public void TriggerDialogue ()
  {
      FindObjectOfType<Moon_Manager>().StartDialogue(dialogue);

      

  }

}