# Solución PooVueling.

### La solución consta de 3 proyectos.
* PooVueling que contiene una interface y una clase para los métodos de la calculadora.
* PooVuelingUnitTest contiene los IntegrationTest con MSTests.
* PooVuelingXUnitTests contiene los IntegrationTest con XUnit.

### PooVueling.
Tiene 4 métodos:
* Suma: Pide 2 integers y devuelve un integer con la suma de estos dos.
* Resuta: Pide 2 integers y devuelve un integer con la resta de estos dos (el primero menos el segundo).
* Multiplicacion: Pide dos integers y devuelve un integer con el producto de estos dos.
* Division: Pide dos integers y devuelve un integer con el primer núemro dividio por el segundo.
    * Excepción de division por cero: en el caso de que el num2 sea un 0, este método devovlera lanzara una excepción.

### PooVuelingUnitTest
Contiene pruebas para las siguientes opciones por MSTest.
* Suma: comprueba que el resultado de la suma sea correcta.
* Resta: Lo mismo que el anterior pero apra la resta del numero 1 - el numero 2.
* Multiplicacion: Lo mismo pero en caso del producto.
* Division: Lo mismo pero para la división del primero por el segundo.

### PooVuelingXUnitTest
Contiene pruebas para las siguientes opciones.
* Suma: comprueba que el resultado de la suma sea correcta.
* Resta: Lo mismo que el anterior pero apra la resta del numero 1 - el numero 2.
* Multiplicacion: Lo mismo pero en caso del producto.
* Division: Lo mismo pero para la división del primero por el segundo.
* DivisionBy0: Comprueba el throw del dividedbyzero exception.

### Para ejectuar los test.

#### XUnit:
Debemos instalar el xunitrunner y ejecutar la siguiente instrucción.
xunit.console [Path de la dll con los test].

Podemos usar también la extensión (instalada desde el nuget manager) xunit.runner.visualstudio para verlo por interfaz gráfica.

#### MStest:
MStest viene integrado con visualstudio por lo qe pdoemos ejecutar lso test desde el menu pruebas y ejecutar tdas las pruebas. Esto abrira la interfaz gráfica del msTest.


