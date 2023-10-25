using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTrigger : MonoBehaviour {
 public Dialogue dialogue;

  public void TriggerDialogue ()
  {
      FindObjectOfType<LevelManager>().StartDialogue(dialogue);

  }

}

