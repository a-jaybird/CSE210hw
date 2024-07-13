using System.Data;
using System.Xml;

public class Address{
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;
        // bool _InUSA;

        public Address(string street, string town, string state, string count){
            _streetName = street;
            _city = town;
            _state = state;
            _country = count;
        }    
    public string GetStreetName(){
        return _streetName;
    }
    public void SetStreetName(string streetName){
        _streetName = streetName;
    }
    public string GetCity(){
        return _city;
    }
    void SetCity(string city){
        _city = city;
    }

    public string GetState(){
        return _state;
    }
    public void SetState(string state){
        _state = state;
    }
    public string GetCountry(){
        return _country;
    }
    public void SetCountry(string country){
        _country = country;
    }
    public string FullAddress(){
        string FullAddress = $"{_streetName} \n{_city}, {_state} \n {_country} ";
        return FullAddress;
       
    }
    public Boolean USorNot(){
        return _country == "USA";
        
        }
    
}
