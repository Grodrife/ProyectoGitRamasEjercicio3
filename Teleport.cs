using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float range;
    RaycastHit hit;
    public LayerMask layerGround;
    LineRenderer line;
    Transform player;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        player = transform.parent.parent.parent.parent;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, range, layerGround)) 
            {
                line.enabled = true;
                line.SetPosition(0, transform.position);
                line.SetPosition(1, hit.point);
                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    player.GetComponent<CharacterController>().enabled = false;
                    player.GetComponent<OVRPlayerController>().enabled = false;
                    
                    if (hit.transform.tag.Equals("TeleportArea"))
                        player.transform.position = hit.transform.GetChild(0).position;
                    else
                        player.transform.position = hit.point;
                    
                    player.GetComponent<CharacterController>().enabled = true;
                    player.GetComponent<OVRPlayerController>().enabled = true;
                }
            } else
            {
                line.enabled = false;
            }
        } else
        {
            line.enabled=false;
        }
    }
}
