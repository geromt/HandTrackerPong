using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamController : MonoBehaviour
{
	public MeshRenderer webCamRenderer;
	
	private WebCamDevice[] devices;
	
    // Start is called before the first frame update
    void Start()
    {
        devices = WebCamTexture.devices;
        foreach (WebCamDevice device in devices)
        {
        	Debug.Log(device.name);
        }

        WebCamTexture webCamTexture = new WebCamTexture(devices[0].name);
        webCamRenderer.material.mainTexture = webCamTexture;
        webCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
