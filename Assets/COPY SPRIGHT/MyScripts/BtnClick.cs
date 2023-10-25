using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnClick : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("Full_moon");
    }
}