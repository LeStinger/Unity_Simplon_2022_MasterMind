using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] Color GameObjectColor;
    public GameObject obj;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButtonDown(0))
            {
                obj.GetComponent<MeshRenderer>().material.color=GameObjectColor; 
            }
        
    }
    void OnMouseOver()
    {
        Debug.Log("Curseur sur objet");
    }

    void OnMouseExit()
    {
        Debug.Log("Curseur pas sur objet");
    }
}
