using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUFaculty : NYUStaff
{
    public string office = "";

    public NYUFaculty(
        string name, string netId, string office, float salary) :
        base(name, netId, salary)
    {
        this.office = office;
        type = "NYU faculty";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "\nOffice: " + office;
    }
}
