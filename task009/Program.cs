// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = true;
bool y = true;
if ((!(x || y)) == (!x && !y))
    Console.WriteLine("выражение истино");
else
    Console.WriteLine("выражение ложно");

x = false;
y = true;
if ((!(x || y)) == (!x && !y))
    Console.WriteLine("выражение истино");
else
    Console.WriteLine("выражение ложно");

x = true;
y = false;
if ((!(x || y)) == (!x && !y))
    Console.WriteLine("выражение истино");
else
    Console.WriteLine("выражение ложно");

x = false;
y = false;
if ((!(x || y)) == (!x && !y))
    Console.WriteLine("выражение истино");
else
    Console.WriteLine("выражение ложно");

// (мысли)
// bool x=true;  
// bool y=true;
// bool valueOne = !(x || y);
// bool valueTwo = !x && !y;
// if(valueOne == valueTwo)
//     Console.WriteLine("выражение истино");
// else
//     Console.WriteLine("выражение ложно");  

// x=false;
// y=true;
// if(valueOne == valueTwo)
//     Console.WriteLine("выражение истино");
// else
//     Console.WriteLine("выражение ложно");  

// x=true;
// y=false;
// if(valueOne == valueTwo)
//     Console.WriteLine("выражение истино");
// else
//     Console.WriteLine("выражение ложно");  

// x=false;
// y=false;
// if(valueOne == valueTwo)
//     Console.WriteLine("выражение истино");
// else
//     Console.WriteLine("выражение ложно");  