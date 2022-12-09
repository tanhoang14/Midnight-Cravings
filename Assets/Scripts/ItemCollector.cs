using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{   
    private int melons = 0;
    [SerializeField] private Text melonsText;
    [SerializeField] private AudioSource collectionSoundEffect;
   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.gameObject.CompareTag("Melon"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            melons++;
            melonsText.text = "Foods: " + melons;
        }
   }
}
