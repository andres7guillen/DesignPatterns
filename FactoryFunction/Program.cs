using FactoryFunction.Entities._01_Tutorial;

var toyotaCar = Car.Create(brand: "Toyota", model: "Jetta", year: 2022, color: "White", 5000);
var mazdaCar = Car.Create(brand: "Mazda", model: "CX-30", year: 2025, color: "redWine", 5000);
toyotaCar.DisplayInfo();
mazdaCar.DisplayInfo();

//Factory function
var discountFunction = DiscountFactory.CreateDiscountFunction(DateTime.Now.Year);
Car car1 = Car.Create("Toyota", "Corolla", 2015, "White", 15000);
Car car2 = Car.Create("Ford", "Mustang", 2000, "Black", 30000);

Console.WriteLine($"Descuento para {car1.Model}: ${discountFunction(car1)}");
Console.WriteLine($"Descuento para {car2.Model}: ${discountFunction(car2)}");

//string word = "Hola mundo";
//char[] reverseWord = new char[word.Length];
//for (int i = 0, j = word.Length - 1; i < word.Length; i++, j--) 
//{
//    reverseWord[i] = word[j];
//}
//string reverse = new string(reverseWord);
//Console.WriteLine(reverse);
//int firstFactorial(int n) 
//{
//    int temp = 1;
//    for (int i = n; i > 0; i--) 
//    {
//        temp = i * temp;
//    }
//    return temp;
//}
//Console.WriteLine(firstFactorial(5));

// using System.Text.RegularExpressions;

//string longestWord(string sentence)
//{
//    sentence = sentence.Trim();
//    sentence = Regex.Replace(sentence,"[,.!]","");
//    int longest = 0;
//    string wordLongest = "";
//    string[] arrayWord = sentence.Split(' ');
//    for (int i = 0; i < arrayWord.Length; i++) 
//    {
//        if (arrayWord[i].Length > longest) 
//        {
//            wordLongest = arrayWord[i];
//            longest = arrayWord[i].Length;
//        }            
//    }
//    return wordLongest;
//}
//Console.WriteLine(longestWord("Hola, mundo!"));

//bool BracketMatcher(string sentence)
//{
//    int matcher = 0;
//    char[]array = sentence.ToCharArray();
//    for (int i = 0; i < array.Length; i++) 
//    {
//        if (array[i] == '(')
//        {
//            matcher++;
//        }
//        else if (array[i] == ')')
//        {
//            matcher--;
//            if (matcher < 0)
//                return false;
//        }        
//    }
//    return matcher == 0;
//} 
//Console.WriteLine(BracketMatcher(")Hola (mundo)("));