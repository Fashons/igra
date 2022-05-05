using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class zadymka : MonoBehaviour
{
  void Start()
  {
      GetComponent<Text>().text = "42";
   }
}