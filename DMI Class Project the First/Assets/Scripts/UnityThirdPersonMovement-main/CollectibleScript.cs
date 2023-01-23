using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    public Collectible c;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(x, y, z);
    }

    public void Collect()
    {
        c.collectCurrent++;
        c.collectText.text = "Things: " + c.collectCurrent.ToString() + " / " + c.collectTotal.ToString();
        c.collectSource.clip = c.collectClip;
        c.collectSource.Play();
        if (c.collectCurrent == c.collectTotal)
        {
            c.gotThemAll.SetActive(true);
            c.removeGraphicTimer = 3;
        }
        Destroy(this.gameObject);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Collect();
        }
    }
}