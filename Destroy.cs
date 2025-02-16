using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    
    public GameObject player;
    public GameObject platformPrefab;
    private GameObject myPlat;
    public GameObject springPrefab;

    public GameObject gameOverUI;
    
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Hiermee worden platforms weggehaald bij collision met "de destroyer" en deze platforms worden dan random boven de camera view weer gerespawned zodat er oneindig lang platforms komen en gaan
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name.StartsWith("Platform"))
        {
            if (Random.Range(1, 7) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (4 + Random.Range(0.2f, 0.6f))) , Quaternion.identity);
            } 
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (4 + Random.Range(0.2f, 0.6f)));
            }
        } else if(collision.gameObject.name.StartsWith("Spring"))
        {
           if (Random.Range(1, 7) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (4 + Random.Range(0.2f, 0.6f)));
                 
            } 
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (4 + Random.Range(0.2f, 0.6f))) , Quaternion.identity);
            } 
        }

        if(collision.gameObject.name.StartsWith("Frio"))
        {
            gameOverUI.SetActive(true); 
        }

    }
}
