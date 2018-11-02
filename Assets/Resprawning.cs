using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resprawning : MonoBehaviour 
{
  
  [SerializeField] private Transform Player2;
  [SerializeField] private Transform ResprawnPonit;
  [SerializeField] private Collider2D Player;
  
	
	void OnTriggerStay2D(Collider2D Player)
	{
	  if (Input.GetKeyDown(KeyCode.Space))
      //if (onSpacebar != null)
      
        Player2.transform.position = ResprawnPonit.transform.position;
        //onSpacebar.Invoke();
	  
	}

  void OnTriggerExit2D(Collider2D Player)
	{
	  //if (Input.GetKeyDown(KeyCode.Space))
      //if (onSpacebar != null)
      
        Player2.transform.position = ResprawnPonit.transform.position;
        //onSpacebar.Invoke();
	  
	}
}
