using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
public class DepthView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        //only do this on IOS
        #if UNITY_IOS
        // set up capture
        var capture = new DepthCapture();
        capture.Configure();
        capture.Start();

        // acquire captured frame
        int width = 0, height = 0;
        float[] pixels = null;
        capture.AcquireNextFrame((pVideoData, videoWidth, videoHeight, pDepthData, depthWidth, depthHeight) =>
        {
            width = depthWidth;
            height = depthHeight;
            pixels = new float[width * height];
            Marshal.Copy(pDepthData, pixels, 0, width * height);
        });

        var texture = new Texture2D(width, height);
        for (var y = 0; y < (int)height; y++)
        {
            for (var x = 0; x < (int)width; x++)
            {
                var v = pixels[y * width + x];
                Color color;
                if (float.IsNaN(v))
                {
                    color = new Color(0f, 1f, 0f);
                }
                else
                {
                    color = new Color(v, v, v);
                }
                texture.SetPixel(x, y, color);
            }
        }

        //quad.GetComponent<Renderer>().material.mainTexture = texture;
        //texture.Apply();
        Image image = this.GetComponent<Image>();
        if (image)
        {
            image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            texture.Apply();
        }
            
        // release capture
        capture.Stop();
        capture.Dispose();
        #endif
    }
}
