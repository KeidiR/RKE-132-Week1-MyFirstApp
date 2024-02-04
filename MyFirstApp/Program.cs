// This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:");//Output(väljund)
//string - sõne. Andmete tüübid, mis lähevad kastikesse(muutuja/variable).  Siia saab panna ainult sõnad.
// =märk tähendab salvesta väärtus(assign)
//Readline loeb andmeid konsoolist maha.
string userName = Console.ReadLine();//Input(deklaratsioon/sisend)

// 2 varianti, et lisada tühik. 1. kasuta plusse(teeb koodi kohmakaks ja pikaks) 
Console.WriteLine("Hello" + ", " + userName + "!"); //Output
// 2. variant String interpolation
Console.WriteLine($"Hello, {userName} !"); //Output

// Ühes programmis ei saa olla Ühe ja sama nimega muutujaid.
//Console - objekt, peale punkti omadus või käsk. Käsud on alati sulgudega. Suured algustähed ja vahepealsed tähed on väga olulised.