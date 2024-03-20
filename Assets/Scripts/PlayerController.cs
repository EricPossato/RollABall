using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb; 
    private float movementX;
    private float movementY;
    public float speed = 0; 
    private int count;
    private int timer;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI timerText;
    public GameObject winTextObject;
    public AudioClip clownHorn;
    
    

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent <Rigidbody>();
     count = 0;
     SetCountText();
     winTextObject.SetActive(false);
     InvokeRepeating("SetTimer", 0, 1.0f);
    }

    private void FixedUpdate() 
   {
     Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
     rb.AddForce(movement * speed);
   }

    void OnMove (InputValue movementValue)
   {
     Vector2 movementVector = movementValue.Get<Vector2>(); 
     movementX = movementVector.x; 
     movementY = movementVector.y; 
   }

   void OnTriggerEnter(Collider other) 
   {
     if (other.gameObject.CompareTag("Pickup")) 
       {
          other.gameObject.SetActive(false);
          count = count + 1;
          AudioSource.PlayClipAtPoint(clownHorn, transform.position);
          SetCountText();
       }
   }

   void SetCountText() 
   {
       countText.text =  "Count: " + count.ToString();
       if (count >= 11)
       {
           winTextObject.SetActive(true);
       }
   }

   void SetTimer(){
    if (count < 11)
      {
        timerText.text = timer.ToString() + "s";
        timer ++;
      }
    
    }
   
}
