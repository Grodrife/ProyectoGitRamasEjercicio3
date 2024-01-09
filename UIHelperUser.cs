using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHelperUser : MonoBehaviour
{
    GameObject line;

    // Start is called before the first frame update
    void Start()
    {
        line = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            line.SetActive(true);
        else
            line.SetActive(false);
    }
}
