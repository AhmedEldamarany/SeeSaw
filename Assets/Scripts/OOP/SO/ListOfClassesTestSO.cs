using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class ListOfClassesTestSO : ScriptableObject
{
    public thing[] things;
    public int x;

    
    public void SaveData()
    {
        //things = new thing[2];
        thing t1 = new thing();
        t1.number = 15;
        x = 70;
        thing t2 = new thing();
        t2.number = 25;
        things[0]=(t1);
        things[1]=(t2);
    }
}
 public class thing
{
    //public Sprite img;
    public int number;
}