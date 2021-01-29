using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetrunToMenu : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("MenuScreen");
    }
}
