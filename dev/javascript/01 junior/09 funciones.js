//funciones
//es un bloque de codigo que funciona para reutilizarce y no tener demasiado codigo  en tu programa

//funcion simple que saluda la cual se puede ejcutar las veces que nececites
function saludar() {
    let estado=prompt("hola boludito como estas ")
    if (estado=="bien") {
        alert("que bueno me alegro")        
    }
    else{
        alert("ni modo pa") 
    }    
}
//saludar();


//funciones con variables no definidas
// let numero1=parseInt(prompt("dame el primer numero que quieres sumar")); 
// let numero2=parseInt(prompt("dame el segundo"));

function suma(n1,n2){
    r=n1+n2
    document.writeln(r)
};

// funciones flecha
const sumaflecha=(n1,n2)=>{
    r=n1+n2
    document.writeln(r)


}
// suma(numero1,numero2)
// sumaflecha(numero1,numero2)
