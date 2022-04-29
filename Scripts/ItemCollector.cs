using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{

    private int bananas = 0;
    [SerializeField] private TextMeshProUGUI collectCount;

    public AudioSource audiosource;

    void Update()
    {
        if (bananas == 5)
        {
            SceneManager.LoadScene(3);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Banana"))
        {
            audiosource.Play();
            Destroy(other.gameObject);
            bananas++;
            collectCount.text = "Bananas collected: " + bananas + "/5";
        }
    }
}
