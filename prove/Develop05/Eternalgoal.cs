public class EternalGoal:Goals{ 
public EternalGoal(){

}

    public override int CheckOff()
    {
        return _pointSet;
    }

    public override string ToString()
    {
       return $"EternalGoal: {_goalSet}, {_pointSet}";
    }

}