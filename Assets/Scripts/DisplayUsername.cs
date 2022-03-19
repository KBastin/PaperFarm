using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayUsername : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI welcomeText;

    // Start is called before the first frame update
    void Start()
    {
        welcomeText.text = $"Hi {GameManager.Instance.Name}!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
