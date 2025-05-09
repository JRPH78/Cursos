// concat() junta dos o mas cadenas
// let cadena1="esto es una cadena de ejemplo ";
// let cadena2="esto se va a concatenar ";
// let resultado=cadena1.concat(cadena2);



// buscar cadenas y devolvernos un valor

// startsWith() y endWith verifican fi una cadena empiza o acaba con los caracteres de otra cadena devuelve tru si es verdadero o false
// let cadena1="esto es una cadena de ejemplo ";
// let cadena2="ejemplo ";
// let resultado=cadena1.startsWith(cadena2);
// let resultado2=cadena1.endsWith(cadena2);


// el metodo includes() busca si una cadena se puede encontrar en otra devuelve true si encuerntra
// let cadena1="esto es una cadena de ejemplo ";
// let resultado=cadena1.includes("una");


// el metodo indexOf() devuelve el indice de donde se encuentra el PRIMER caracter y si no se encuentraa devuelve -1
// let cadena1="esto es una cadena de ejemplo ";
// let resultado=cadena1.indexOf("una  ");


// el metodo lastIndexOf() devuelve el indice de donde se encuentra el ULTIMO caracter y si no se encuentraa devuelve -1
// let cadena1="esto es una una una una una cadena de ejemplo ";
// let resultado=cadena1.lastIndexOf("una");




// modificar la cadena 


// padStart() y padEnd() rellena la cadena que le des con los caracteres que quieras dependiendo si la quieres al principio o al final
//  let cadena1="hola"
//  let resultado=cadena1.padStart(10,"puto")
//  let resultado=cadena1.padEnd(10,"puto")


// repeat() devuelve la misma cadena pero la cantidad de veces deaseada .repeat(10)
// let cad="holis"
// let resultado=cad.repeat(10)


// split() divide la cadena como la pidamos y la combierte en un array
// let cadena="hola como estas"
// let resultado=cadena.split(" ")
// let cadena="hola,como,estas"
// let resultado=cadena.split(",")


// substring() nos retorna un pedazo de cadena que nosotros hallamos seleccionado .substring(0,5) nos devuelve del 0 al 5 sin contar 
// lo que haya en la posicion 5
// let cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ"
// let resultado = cadena.substring(0,2)


// toLowerCase() y toUpperCase convierten las cadenas a minuscula y mayuscula respectivamente
// let cadena = "ABCDefghIJKLMNñopqRSTUvwxyZ";
// let resultado = cadena.toLowerCase();        // lo convierte a minusculas
// let resultado = cadena.toUpperCase();       // lo convierte a mayusculas


// el metodo trim() elimina los espacios al principio y al final de una cadena, si solo quieres al principio o al final
// tienes el metodo trimStart y trimEnd()
// let cadena = "                  ABCDefghIJKLMNñopqRSTUvwxyZ           ";
// let resultado = cadena.trim();               // todos los espacios
// let resultado = cadena.trimStart();          // todos los espacios al principio
// let resultado = cadena.trimEnd();            // todos los espacios al final


// el metodo toString() convierte en cadena lo que le pongas
// let cadena = 5;
// let resultado = 2 + (cadena.toString());


// document.writeln(resultado);
 