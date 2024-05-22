 public class Fraction{
         private int _top;
         private int _bottom;
         public Fraction(){
          _top = 1;
          _bottom = 1;
         }
        //  if it shares the name of the class, its a constructor
         public Fraction(int wholeNumber ){
            _top =5;
            _bottom =1;
         }
         public Fraction(int _uptop, int _downlow){
            _top =_uptop;
            _bottom = _downlow;

            

         }
         int getTop(){
            return _top;
         }
         void setTop(int _Top){ 
            _top = _Top;
        
         }
         int getBottom(){
            return _bottom;
         }
         void setBottom(int _Bottom){
            _bottom =_Bottom;
         }

        public string GetFractionString(){
           string fraction = _top.ToString() +"/" + _bottom.ToString();
           return fraction;
        }

        public double GetDecimalValue(){
            
            return (double)_top/(double) _bottom;

        }
            






 }      