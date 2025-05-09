// programacion orientada a objetos(POO) todo en javascript son objetos

class Animal{
    constructor(especie,edad,color){
        this.especie = especie;
        this.edad = edad;
        this.color=color;
        
        this.info=`Soy un ${this.especie}, tengo ${this.edad} años 
        y soy de color ${this.color}`;
    }

    // funcion que hara el objeto
    verInfo(){
        document.write(this.info + "<br>")
    }

};

//herencia
class Perro extends Animal{
    //el constructor construye el objeto con todos los parametros o caracteristicas que le damos
    constructor(especie,edad,color,raza){
        super(especie,edad,color);
        
        this.raza=raza;
    }
    // funcion ladrar exclusivamente del perro
    //static es una funcion que no nececita la creeacion de un objeto funciona sola con la clase
    static ladrar(){
        alert(`WOAW`)
    }
    //los getters y setters se utilizan para acceder a datos o propiedades privadas(encapsuladas)
    get getRaza(){
        return this.raza;
    }
    set setRaza(newName){
        this.raza = newName;
    }
}

// definir cada objeto nuevo
let perro = new Perro("perro", 5, "Marron", "Pastor");
let gato= new Animal("gato", 2, "negro");
let pajaro=new Animal("cotorro", 1, "verde")

// funcion de la clase animal
// gato.verInfo();

// funcion exclusiva de la clase perro
// perro.verInfo();

perro.setRaza="Pug";

// document.writeln(perro.getRaza)

