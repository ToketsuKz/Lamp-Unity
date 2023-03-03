using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject text;
    int textNo;
    private bool text_1 = false;

    void Update()
    {
		if (Input.GetMouseButtonDown(0))
        {
            text_1=!text_1;
            text.gameObject.SetActive(text_1);
        }
    }
}