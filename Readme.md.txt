En C#, todas las excepciones deben estar representadas por una instancia de un tipo de clase derivado de System.Exception . En C++, cualquier valor de cualquier tipo se puede utilizar para representar una excepción.
En C#, se puede usar un bloque finally (la instrucción try) para escribir el código de finalización que se ejecuta en la ejecución normal y en condiciones excepcionales. Este código es difícil de escribir en C++ sin duplicar el código.
En C#, las excepciones de nivel de sistema, como Overflow, división por cero y desreferencia nula, tienen clases de excepción bien definidas y se encuentran en un par de condiciones de error de nivel de aplicación.

La System.Exception clase es el tipo base de todas las excepciones. Esta clase tiene algunas propiedades importantes que comparten todas las excepciones:
Message es una propiedad de solo lectura de tipo string que contiene una descripción inteligible de la razón de la excepción.
InnerException es una propiedad de solo lectura de tipo Exception . Si su valor no es null, hace referencia a la excepción que provocó la excepción actual, es decir, la excepción actual se produjo en un bloque catch que controla el InnerException . De lo contrario, su valor es null, lo que indica que esta excepción no se produjo por otra excepción. El número de objetos de excepción encadenados de esta manera puede ser arbitrario.
El valor de estas propiedades se puede especificar en llamadas al constructor de instancia para System.Exception .

System.ArithmeticException	Una clase base para las excepciones que se producen durante las operaciones aritméticas, como System.DivideByZeroException y System.OverflowException.
System.ArrayTypeMismatchException	Se produce cuando se produce un error en un almacén de una matriz porque el tipo real del elemento almacenado es incompatible con el tipo real de la matriz.
System.DivideByZeroException	Se produce cuando se intenta dividir un valor entero por cero.
System.IndexOutOfRangeException	Se produce cuando se intenta indexar una matriz a través de un índice que es menor que cero o fuera de los límites de la matriz.
System.InvalidCastException	Se produce cuando se produce un error en el tiempo de ejecución de una conversión explícita de un tipo base o una interfaz a un tipo derivado.
System.NullReferenceException	Se produce cuando null se utiliza una referencia de una manera que hace que se requiera el objeto al que se hace referencia.
System.OutOfMemoryException	Se produce cuando se produce un error al intentar asignar memoria (Via new ).
System.OverflowException	Se inicia cuando se desborda una operación aritmética en un contexto checked.
System.StackOverflowException	Se produce cuando la pila de ejecución se agota debido a que hay demasiadas llamadas a métodos pendientes; normalmente indica una recursividad muy profunda o sin enlazar.
System.TypeInitializationException	Se produce cuando un constructor estático produce una excepción y no catch existe ninguna cláusula para detectarlo.