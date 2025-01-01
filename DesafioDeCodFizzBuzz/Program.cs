for (int i = 1; i <= 100; i++){
  if (i % 3 == 0 && i % 5 == 0){
    Console.WriteLine ($"{i} - FizzBuzz");
  }
  else if (i % 3 == 0 ){
    Console.WriteLine($"{i} - Fizz");
  }
  else if (i % 5 == 0) {
    Console.WriteLine($"{i} - Buzz");
  }
  else
    Console.WriteLine(i);

}

/*Criar um programa que verifique se os numeros de 1 a 100 são divisivel por 3, 5 ou ambos*/


