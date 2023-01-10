using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Color GameobjectColor=new Color (R,G,B, a);
    public Gameobject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseDown(.))
            {
            obj.color=GameobjectColor;
            }
        
    }
}
