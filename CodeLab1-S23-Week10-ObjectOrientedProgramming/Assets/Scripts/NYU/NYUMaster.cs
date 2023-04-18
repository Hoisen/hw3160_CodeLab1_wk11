using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUMaster : NYUGrad
{
    public string year = "";
    
    public NYUMaster(string name, string netId, string degree, string year, float gpa, int credits) :
        base(name, netId,  degree, gpa, credits)
    {
        this.year = year;

        type = "NYU Student";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nyear: " + year;
    }
}
