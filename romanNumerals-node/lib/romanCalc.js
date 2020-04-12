exports.convertToRoman = (num) => {
    var romanNmbs = { /*"M":100,"CD":900,"D":500*/ "C":100,"XC":90,"L":50,"XL":40,"X":10,"IX":9,"V":5,"IV":4,"I":1 }
    var str ='';
    for (var i in romanNmbs){
        
        while (num >= romanNmbs[i])
        {   
            num -= romanNmbs[i];
            str = i;
            return str + this.convertToRoman(num);
        }
    }
    return str;
  };
