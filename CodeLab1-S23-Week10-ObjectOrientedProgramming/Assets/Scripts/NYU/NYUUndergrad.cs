using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUUndergrad : NYUStudent
{
    private string degree = "";
    private string year = "";
    public NYUUndergrad(string name, string netId, string degree, string year, float gpa, int credits) : 
        base(name, netId, gpa, credits)
    {
        this.degree = degree;
        this.year = year; 
        
        type = "NYU Student";
    }
    
    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nDegree: " + degree + "\nyear: " + year;
    }
}
