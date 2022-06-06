using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject weapon;
    // Start is called before the first frame update
    void Start()
    {
        //weapon = GetComponent<GameObject>();
    }

    public void Entersword()
    {
        weapon.SetActive(true);

    }

    public void Closesword()
    {
        weapon.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mermi")
        {
            Destroy(other.gameObject);
        }
    }
}
