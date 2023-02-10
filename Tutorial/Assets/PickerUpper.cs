using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerUpper : MonoBehaviour
{
    public int count = 0;
    public GameObject particlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Pickup"))
        {
            GameObject.Instantiate(particlePrefab, collision.collider.gameObject.transform.position,Quaternion.identity); // creates particle out of nowhere
            // respond to collidion, lookup what it is, what position it is and what to do there (quaterinion.identity - no roatation change)

            GameObject.Destroy
               (collision.collider.gameObject); // destroy pickup cube

            count = count + 1;

            this.GetComponent<AudioSource>().Play();

            Debug.Log("Pickup Count:" + count);

        }
    }
}
