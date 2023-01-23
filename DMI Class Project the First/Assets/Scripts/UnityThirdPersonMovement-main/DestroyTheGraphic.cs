using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTheGraphic : MonoBehaviour
{
    public Collectible c;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (c.removeGraphicTimer < -0.01)
        {
            this.gameObject.SetActive(false);
        }
    }
}