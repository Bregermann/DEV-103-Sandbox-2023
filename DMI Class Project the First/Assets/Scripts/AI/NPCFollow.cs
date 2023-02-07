using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    public GameObject thePlayer;
    public float targetDistance;
    public float allowedDistance;
    public GameObject theNPC;
    public float followSpeed;
    public RaycastHit shot;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.LookAt(thePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDistance = shot.distance;
            if (targetDistance >= allowedDistance)
            {
                followSpeed = .2f;
                theNPC.GetComponent<Animation>().Play("Toucan Movement");
                transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, followSpeed);
            }
            else
            {
                followSpeed = 0;
                theNPC.GetComponent<Animation>().Play("Toucan Movement");
            }
        }
    }
}