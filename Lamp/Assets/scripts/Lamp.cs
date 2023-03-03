using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lamp : MonoBehaviour {

    public GameObject online;
    public GameObject offline;
    private bool online_1 = true;
    private bool offline_1 = false;

	// Update is called once per frame
	void Update ()
    {
		if (Input.GetMouseButtonDown(0))
        {
            online_1 = !online_1;
            online.gameObject.SetActive(online_1);
        }

		if (Input.GetMouseButtonDown(0))
        {
            offline_1 = !offline_1;
            offline.gameObject.SetActive(offline_1);
        }
    }
}
