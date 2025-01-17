using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CoinCollection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coin: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int coin = 0;
    public TextMeshProUGUI coinText;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin")){
            Destroy(other.gameObject);
            coin++;
            coinText.text= "Coin: "+coin;
            if (coin == 4)
            {
                SceneManager.LoadScene("Level2");
            }
        }
        if (other.gameObject.CompareTag("Bomb"))
        {  
            Destroy(other.gameObject);
            Destroy(gameObject);
            coin = 0;
            coinText.text = "Coin: " + coin;
        }
    }
}
