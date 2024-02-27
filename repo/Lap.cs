using System;

public class Times
{
    public string name {get;}
    public List<Object> laps{get;}

    public Times(string str, List<Object> array){
        this.name = str;
        this.laps = array;
    }
}