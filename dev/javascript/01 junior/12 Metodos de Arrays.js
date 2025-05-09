const nombres=["pedro", "maria", "mayk", "jorge"]
// document.write(" original " + "<b>" + nombres + "</b><br><br>");

// __________transformadores__________

// pop() elimina el ultimo elemento del array y te lo devuleve
// let resultado = nombres.pop() // elimino a jorge y te lo devuelve para que lo veas


// shift() elimina el primer elemento del array y te lo devuleve
// let resultado = nombres.shift() // elimino a pedro  y te lo devuelve para que lo veas


// push() agrega un elemento al array hasta el final de este
// let resultado=nombres.push("pagis", "fransia") //lo agrega y te devuelve la cantidad de elementos que hay ahora en el array


// unshift() agrega un elemento al array al final de este
// let resultado=nombres.unshift("pagis", "fransia") //lo agrega y te devuelve la cantidad de elementos que hay ahora en el array


// reverse() nos invierte el orden de el array
// let resultado = nombres.reverse();


// sort() ordena los elementos del array en orden alfavetico o numerico respectivamente
// let resultado = nombres.sort();


// splice() cambia el contenido desde la posicion que tu determines eliminando y/o agregando elementos nuevos
// let resultado = nombres.splice(1,5,"RAFAELO")   //devuleve los elementos cambiados o eliminados



// __________ accesores __________

// join() une todos los elementos de un array en una cadena y la devuelve
// let resultado= nombres.join("-");


// slice() devulve la parte que tu quieras en un nuevo array
// let resultado= nombres.slice(0,3)

 
//metodos que tambien sirven como los de cadena: toString(), indexOf, lastIndexOf, includes
// el metodo indexOf() devuelve el indice de donde se encuentra el PRIMER caracter y si no se encuentraa devuelve -1
// let resultado = nombres.indexOf("pedro");  

// el metodo lastIndexOf() devuelve el indice de donde se encuentra el ULTIMO caracter y si no se encuentraa devuelve -1
// let resultado = nombres.lastIndexOf("pedro");

// el metodo includes() busca si una cadena se puede encontrar en otra devuelve true si encuerntra
// let resultado = nombres.includes("pedro");



// __________ De Repeticion __________ 

// forEach() ejecuta una funcion que le indiques una vez por cada elemento del array
// nombres.forEach(nombres=>{document.write(nombres+"<br>")})
// nombres.forEach(function (nombre){document.write( nombre + "<br>" )});



// filter() la misma repeticion que foreach pero este crea un array con los elementos que cumplan la condicion
// let resultado = nombres.filter(nombres=>nombres.length<5)

// document.write(resultado);