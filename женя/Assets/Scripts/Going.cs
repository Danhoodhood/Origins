using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Going : MonoBehaviour
{
    public void Link(string LinkID)
    {
        Application.OpenURL(LinkID);
    }
}
