using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public enum Classes { mage, warrior, rogue }

public class Class : Values {


    public System.Random rnd = new System.Random();
    Values val;

    void Start () {

        Classes c = (Classes)(rnd.Next(0, 3));
        switch (c)
        {
            case Classes.mage:
                itemStatsInt(0);
                break;

            case Classes.warrior:
                itemStatsStr(0);
                break;
            case Classes.rogue:
                itemStatsAgi(0);
                break;
        }
    {

    }		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void itemStatsInt(int x)
    {
        val.Intellect = x;
    }

    public void itemStatsStr(int x)
    {
        val.strength = x;
    }

    public void itemStatsAgi(int x)
    {
        val.agility = x;
    }
}
