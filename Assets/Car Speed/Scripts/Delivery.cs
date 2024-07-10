using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hi iam ghada");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package");
            hasPackage = true;
            Destroy(other.gameObject, delay);
            spriteRenderer.color = hasPackageColor;

        }
        else if (other.tag == "Finish" && hasPackage)
        {
            Debug.Log("Finish");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

    }

}
