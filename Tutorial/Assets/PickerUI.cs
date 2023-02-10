using System.Collections;
using System.Collections.Generic;
using TMPro; // code connect to other pieces of code
using UnityEngine;

public class PickerUI : MonoBehaviour
{
    public PickerUpper player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = "Pickup Count; " + player.count;
    }
}
