using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI usernameField;

    public void PlayGame()
    {
        GameManager.Instance.Name = usernameField.text;
        SceneManager.LoadScene(1);
    }
}
