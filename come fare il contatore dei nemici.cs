      #pragma strict
      var health = 100;
      var objectCounter : ObjectCounter;
     
     //Here's the important part:
      function Start()
      {
          objectCounter = GameObject.Find("PaperCounter").GetComponent("ObjectCounter");
      }
      
      function ApplyDamage (theDamage : int)
      {
          health -= theDamage;
          
          if (health <= 0)
          {
              Dead();
          }
      }
      
      function Dead()
      {
          objectCounter.Paper += 1;
          Destroy (gameObject);
      }
	  // da mettere dentro il codice dei bot nemici
	  
	  
	  
	  
	  
	  
	  
	  
	  
	  // questo è lo script da fare a parte come game object a qnt ho capito
	         #pragma strict
       var sfxHit: AudioClip;
       var objectCounter : ObjectCounter;
       function Start()
       {
           objectCounter = GameObject.Find("PaperCounter").GetComponent("ObjectCounter");
       }
       function OnTriggerEnter( other : Collider )
       {
           if (other.gameObject.tag == "Paper")
           {
               objectCounter.Paper += 1;
               Debug.Log("A paper was picked up. Total papers = " + Paper);
               Destroy(other.gameObject);
               GetComponent.<AudioSource>().PlayOneShot(sfxHit);
           }
       }
	   
	   
	// è un possibile modo; non so se è giusto; non ho modo di provarlo.   
	   
	   
	   // dove le ho trovate; https://answers.unity.com/questions/1154536/killed-enemies-counter.html
