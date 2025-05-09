// arrays normales
let frutas=["manzana","pera","banana"];


// arrays asociativos(OBJETOS)
let pc={
    nombre:"rafaelPC",
    procesador:"ryzen 7",
    ram:"16 GB",
    espacio:"1TB"
}
//una forma de mostrar los elementos es agarrar una parte y hacerlo variable
let nombre= pc["nombre"]
//esta es mas eficiente agarras directamente la parte del objeto
let frase=`El nombre del pc es: ${pc["nombre"]} <br> Contiene el procesaror: ${pc["procesador"]}`;


// document.writeln(frase); 