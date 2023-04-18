using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUGrad : NYUStudent
{
    private string degree;
    public NYUGrad(string name, string netId, string degree, float gpa, int credits) : base(name, netId, gpa, credits)
    {
        this.degree = degree;
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nDegree: " + degree;
    }
}
