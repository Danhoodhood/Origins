using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCollection : MonoBehaviour
{

    public void Open()
    {
        SceneManager.LoadScene("collections");
    }

}
