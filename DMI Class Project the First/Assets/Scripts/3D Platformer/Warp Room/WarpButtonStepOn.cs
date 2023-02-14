using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpButtonStepOn : MonoBehaviour
{
    public Texture buttonTexture;
    public Texture buttonSteppedOnTexture;
    public GameObject button;
    public AudioSource portalSource;
    public GameObject portal;
    public Texture portalTexture;
    public int level;
    public WarpRoomManager warp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Renderer renderer = GetComponent<Renderer>();
            Material material = renderer.material;
            material.mainTexture = buttonSteppedOnTexture;
            portalSource.Play();

            Renderer portalRenderer = portal.GetComponent<Renderer>();
            Material portalMaterial = portalRenderer.material;
            portalMaterial.mainTexture = portalTexture;
            portal.SetActive(true);
            warp.level = level;
        }
    }
}